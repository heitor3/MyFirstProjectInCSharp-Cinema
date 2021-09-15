using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.RepositorioEF
{
    public class FilmeRepositorioEF : IRepositorio<Tbl_FILMES>
    {

        private readonly Contexto contexto;

        public FilmeRepositorioEF()
        {
            contexto = new Contexto();
        }

        public void Salvar(Tbl_FILMES entidade)
        {
            if (entidade.Id > 0)
            {
                var filmeAlterar = contexto.Filmes.First(x => x.Id == entidade.Id);
                filmeAlterar.Id_classificacao = entidade.Id_classificacao;
                filmeAlterar.Nome = entidade.Nome;
                filmeAlterar.Duracao = entidade.Duracao;
                filmeAlterar.Descricao = entidade.Descricao;
            }
            else
            {
                contexto.Filmes.Add(entidade);
            }
            contexto.SaveChanges();
        }

        public void Excluir(Tbl_FILMES entidade)
        {
            var filmeExcluir = contexto.Filmes.First(x => x.Id == entidade.Id);
            contexto.Set<Tbl_FILMES>().Remove(filmeExcluir);
            contexto.SaveChanges();
        }

        public IEnumerable<Tbl_FILMES> ListarTodos()
        {

            return contexto.Filmes.Include("Tbl_CLASSIFICACAO").ToList();
        }

        public Tbl_FILMES ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            return contexto.Filmes.First(x => x.Id == idInt);
        }



    }
}
