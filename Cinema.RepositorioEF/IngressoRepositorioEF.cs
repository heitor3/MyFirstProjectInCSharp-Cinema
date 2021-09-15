using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.RepositorioEF
{
    public class IngressoRepositorioEF : IIngressoRepositorio<Tbl_INGRESSO>
    {

        private readonly Contexto contexto;

        public IngressoRepositorioEF()
        {
            contexto = new Contexto();
        }

        public IEnumerable<Tbl_INGRESSO> ListarIngressos()
        {
            return contexto.Tbl_INGRESSO;
        }

        public void Comprar(Tbl_INGRESSO ingresso)
        {
            contexto.Tbl_INGRESSO.Add(ingresso);
            contexto.SaveChanges();
        }
        public Tbl_INGRESSO ListarIngressosId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            return contexto.Tbl_INGRESSO.First(x => x.Id_ingresso == idInt);
        }
    }
}
