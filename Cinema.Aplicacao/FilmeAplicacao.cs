using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System.Collections.Generic;

namespace Cinema.Aplicacao
{
    public class FilmeAplicacao
    {
        private readonly IRepositorio<Tbl_FILMES> repositorio;

        public FilmeAplicacao(IRepositorio<Tbl_FILMES> repo)
        {
            repositorio = repo;
        }

        public void Salvar(Tbl_FILMES filme)
        {
            repositorio.Salvar(filme);
        }

        public void Excluir(Tbl_FILMES filme)
        {
            repositorio.Excluir(filme);
        }

        public IEnumerable<Tbl_FILMES> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public Tbl_FILMES ListarPorId(string id)
        {
            return repositorio.ListarPorId(id);
        }


    }
}
