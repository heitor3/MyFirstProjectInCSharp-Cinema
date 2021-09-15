using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System.Collections.Generic;

namespace Cinema.Aplicacao
{
    public class ClienteAplicacao
    {
        private readonly IRepositorio<Tbl_CLIENTES> repositorio;

        public ClienteAplicacao(IRepositorio<Tbl_CLIENTES> repo)
        {
            repositorio = repo;
        }

        public void Salvar(Tbl_CLIENTES cliente)
        {
            repositorio.Salvar(cliente);
        }

        public void Excluir(Tbl_CLIENTES cliente)
        {
            repositorio.Excluir(cliente);
        }

        public IEnumerable<Tbl_CLIENTES> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public Tbl_CLIENTES ListarPorId(string id)
        {
            return repositorio.ListarPorId(id);
        }
    }
}
