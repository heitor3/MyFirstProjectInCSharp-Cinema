using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;

namespace Cinema.Aplicacao
{
    public class SessaoAplicacao
    {
        private readonly ISessaoRepositorio<Tbl_SESSAO> repositorio;

        public SessaoAplicacao(ISessaoRepositorio<Tbl_SESSAO> repo)
        {
            repositorio = repo;
        }

        public IEnumerable<Tbl_SESSAO> ListarSessao(string id)
        {
           
            var lista = repositorio.ListarSessao(id);
            return lista;
        }

    }
}
