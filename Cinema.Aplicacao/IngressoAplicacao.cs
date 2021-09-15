using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System.Collections.Generic;

namespace Cinema.Aplicacao
{
    public class IngressoAplicacao
    {
        private readonly IIngressoRepositorio<Tbl_INGRESSO> repositorio;

        public IngressoAplicacao(IIngressoRepositorio<Tbl_INGRESSO> repo)
        {
            repositorio = repo;
        }
        public IEnumerable<Tbl_INGRESSO> ListarIngressos()
        {
           return repositorio.ListarIngressos();
        }

        public void Comprar(Tbl_INGRESSO ingresso) 
        {
            repositorio.Comprar(ingresso);
        }

        public Tbl_INGRESSO ListarIngressosId(string id)
        {
            return repositorio.ListarIngressosId(id);
        }
    }
}
