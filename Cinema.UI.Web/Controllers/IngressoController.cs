using Cinema.Aplicacao;
using Cinema.Dominio;
using System;
using System.Collections;
using System.Linq;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace Cinema.UI.Web.Controllers
{
    public class IngressoController : Controller
    {
        private readonly IngressoAplicacao appIngresso;

        public IngressoController()
        {
            appIngresso = CinemaAplicacaoConstrutor.IngressoRepositorioEF();
        }

        [HttpPost]
        public JsonResult Index(Tbl_INGRESSO ingresso)
        {

            ingresso.Id_cliente = (int?)Session["id"];
            ingresso.Id_filme = Convert.ToInt32(Session["idFilme"]);
            ingresso.Id_sessao = Convert.ToInt32(Session["idSessao"]);
            ingresso.DataCompra = DateTime.Now;

            appIngresso.Comprar(ingresso);

            return Json(ingresso.Id_ingresso);
        }

        [HttpGet]
        public IEnumerable Verificar(string id)
        {

            int idInt;
            Int32.TryParse(id, out idInt);

            var lista = appIngresso.ListarIngressos()
                .Where(x => x.Id_sessao == idInt);

            var recebe = lista.Select(x => x.Id_assento).ToList();

            return JsonConvert.SerializeObject(recebe);
        }

        
        public ActionResult Sucesso(string id)
        {

            var lista = appIngresso.ListarIngressosId(id);
           
            return View(lista);
        }

    }
}