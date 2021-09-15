using Cinema.Aplicacao;
using Cinema.Dominio;
using System.Web.Mvc;

namespace Cinema.UI.Web.Controllers
{
    
    public class FilmeController : Controller
    {
        private readonly FilmeAplicacao appFilme;
        
        public FilmeController()
        {
            appFilme = CinemaAplicacaoConstrutor.FilmeAplicacaoEF();
        }

       
        public ActionResult Index()
        {
            var listaDeFilmes = appFilme.ListarTodos();
            return View(listaDeFilmes);
        }

        public ActionResult Cadastrar()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Tbl_FILMES filme)
        {
            if (ModelState.IsValid)
            {
                appFilme.Salvar(filme);
                return RedirectToAction("Index");
            }
            else
                return View(filme);
        }

        public ActionResult Editar(string id)
        {
            var filme = appFilme.ListarPorId(id);

            if (filme == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(filme);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Tbl_FILMES filme)
        {
            if (ModelState.IsValid)
            {
                appFilme.Salvar(filme);
                return RedirectToAction("Index");
            }
            else
                return View(filme);
        }

        public ActionResult Detalhes(string id)
        {
            var filme = appFilme.ListarPorId(id);

            if (filme == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(filme);
            }

        }

        public ActionResult Excluir(string id)
        {
            var filme = appFilme.ListarPorId(id);

            if (filme == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(filme);
            }
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmado(string id)
        {
            var filme = appFilme.ListarPorId(id);
            appFilme.Excluir(filme);
            return RedirectToAction("Index");
        }
    }
}