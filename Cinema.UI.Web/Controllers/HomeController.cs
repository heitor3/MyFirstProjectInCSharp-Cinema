using Cinema.Dominio;
using Cinema.Aplicacao;
using System.Web.Mvc;
using Cinema.UI.Web.Models;
using System.Security.Claims;
using Cinema.UI.Web.Managers;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Cinema.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly VerificaLogin verifica;
        private readonly ClienteAplicacao appCliente;

        public HomeController()
        {
            verifica = CinemaAplicacaoConstrutor.LoginRepositorioEF();
            appCliente = CinemaAplicacaoConstrutor.ClienteAplicacaoEF();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Tbl_CLIENTES cliente)
        {

            if (ModelState.IsValid)
            {
                appCliente.Salvar(cliente);
                return RedirectToAction("index", "Home");

            }
            return View(cliente);
        }



        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Tbl_CLIENTES cliente)
        {

            var validar = verifica.Login(cliente.Email, cliente.Senha);

            Session["id"] = validar.Id_cliente;

            if (validar != null)
            {
                IAuthContainerModel model = GetJWTContainerModel(cliente.Email, cliente.Senha);
                IAuthService authService = new JWTService(model.SecretKey);

                string token = authService.GenerateToken(model);
                if (!authService.IsTokenValid(token))
                    throw new UnauthorizedAccessException();
                else
                {
                    using (var client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Accept.Clear();

                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    }

                    return RedirectToAction("Index", "Filme");
                }


            }
            else
            {
                return View();
            }

        }

        private static JWTContainerModel GetJWTContainerModel(string email, string senha)
        {
            return new JWTContainerModel()
            {
                Claims = new Claim[]
                {
                    new Claim(ClaimTypes.Email, email),
                    new Claim(ClaimTypes.Name, senha)
                }
            };
        }


    }

}