using Cinema.Aplicacao;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;

namespace Cinema.UI.Web.Controllers
{

    public class SessaoController : Controller
    {
        private readonly SessaoAplicacao appSessao;

        public SessaoController()
        {
            appSessao = CinemaAplicacaoConstrutor.SessaoRepositorioEF();
        }


        public ActionResult Index(string id)
        {
            Session["idFilme"] = id;

            var listaSessao = appSessao.ListarSessao(id);

            return View(listaSessao);
        }

        [HttpGet]
        public IEnumerable Verificar(string data, string hora) {

            string id = Session["idFilme"].ToString();

            //hora 1900 - 01 - 01 11:30:00.000        data 2021 - 06 - 27 00:00:00.000
            DateTime dt = DateTime.ParseExact(data, "d", CultureInfo.CurrentCulture);
            DateTime hr = DateTime.ParseExact(hora, "t", CultureInfo.CurrentCulture);

            var listaSessao = appSessao.ListarSessao(id);

            var dataSessao = listaSessao.FirstOrDefault(x => x.Data == dt && x.Horario.TimeOfDay == hr.TimeOfDay);

            var idSessao = dataSessao.Id_sessao.ToString();

            Session["idSessao"] = idSessao;

            return idSessao;

        }

    
    }
}