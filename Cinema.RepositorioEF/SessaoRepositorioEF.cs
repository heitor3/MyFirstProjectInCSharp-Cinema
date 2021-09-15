using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Collections;
using System.Globalization;

namespace Cinema.RepositorioEF
{
    public class SessaoRepositorioEF : ISessaoRepositorio<Tbl_SESSAO>
    {

        private readonly Contexto contexto;

        public SessaoRepositorioEF()
        {
            contexto = new Contexto();
        }

        public IEnumerable<Tbl_SESSAO> ListarSessao(string id)
        {
            int intId;

            intId = int.Parse(id);

            //var listaSessao = contexto.Tbl_SESSAO.Include(x => x.Tbl_SALAS).ThenInclude("Tbl_ASSENTO").Where(x => x.Id_filme == 1);

            var listaSessao = contexto.Tbl_SESSAO.Include(x => x.Tbl_SALAS.Tbl_ASSENTO)
                .Where(x => x.Id_filme == intId)
                .ToList();

            return listaSessao;
        }
       
    }
}
