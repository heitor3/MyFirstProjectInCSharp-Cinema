using Cinema.Dominio;
using Cinema.Dominio.contrato;
using Cinema.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Cinema.RepositorioADO
{
    public class FilmeRepositorioADO:IRepositorio<Tbl_FILMES>
    {
        private Contexto contexto;

        private void Inserir(Tbl_FILMES filme)
        {
            var strQuery = "";
            strQuery += " INSERT INTO filme (id_classificacao, nome, duracao, descricao ";
            strQuery += string.Format(" VALUES ('{0}','{1}','{2}','{3}') ",
                filme.Id_classificacao, filme.Nome, filme.Duracao, filme.Descricao
                );
            using (contexto = new Contexto())
            {
                contexto.executaComando(strQuery);
            }
        }

        private void Alterar(Tbl_FILMES filme)
        {
            var strQuery = "";
            strQuery += " UPDATE filme SET ";
            strQuery += string.Format(" id_classificacao = '{0}', ", filme.Id_classificacao);
            strQuery += string.Format(" nome = '{0}', ", filme.Nome);
            strQuery += string.Format(" duracao = '{0}', ", filme.Duracao);
            strQuery += string.Format(" id_classificacao = '{0}' ", filme.Id_classificacao);
            strQuery += string.Format(" WHERE id_filme = '{0}' ", filme.Id);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strQuery);
            }
        }

        public void Salvar(Tbl_FILMES filme)
        {
            if (filme.Id > 0)
            {
                Alterar(filme);
            }
            else
            {
                Inserir(filme);
            }
        }

        public void Excluir(Tbl_FILMES filme)
        {
            using (contexto = new Contexto())
            {
                var strQuery = string.Format(" DELETE FROM ALUNO WHERE id_filme = {0}", filme.Id);
                contexto.executaComando(strQuery);
            }
        }

        public IEnumerable<Tbl_FILMES> ListarTodos()
        {
            using (contexto = new Contexto())
            {
                var strQuery = " SELECT * FROM Filme";
                var returnoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjeto(returnoDataReader);

            }
        }

        public Tbl_FILMES ListarPorId(string id)
        {
            using (contexto = new Contexto())
            {
                var strQuery = string.Format(" SELECT * FROM Filme WHERE id_filme = {0}", id);
                var returnoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjeto(returnoDataReader).FirstOrDefault();

            }
        }

        private List<Tbl_FILMES> TransformaReaderEmListaDeObjeto(SqlDataReader reader)
        {
            var filmes = new List<Tbl_FILMES>();
            while (reader.Read())
            {
                var temObejto = new Tbl_FILMES()
                {
                    Id = int.Parse(reader["id_filme"].ToString()),
                    Id_classificacao = int.Parse(reader["id_classificacao"].ToString()),
                    Nome = reader["nome"].ToString(),
                    Duracao = DateTime.Parse(reader["duracao"].ToString()),
                    Descricao = reader["descricao"].ToString()
                };

                filmes.Add(temObejto);
            }
            reader.Close();
            return filmes;
        }

    }
}
