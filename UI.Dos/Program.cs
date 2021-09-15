using Cinema.Aplicacao;
using Cinema.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Dos
{
    class Program
    {
        static void Main(string[] args)
        {
            var appFilme = CinemaAplicacaoConstrutor.FilmeAplicacaoADO();

            Console.Write("Escolha uma classificação para o Filme: Livre = 13, 10 = 14, 12 = 15, 14 = 16, 16 = 17, 18 = 18");
            string id_classificao = Console.ReadLine();

            Console.Write("Nome do filme");
            string nome = Console.ReadLine();

            Console.Write("Duração do filme em horas, minutos e segundos");
            string duracao = Console.ReadLine();

            Console.Write("descrição do filme");
            string descricao = Console.ReadLine();

            var filme = new Tbl_FILMES
            {
                Id_classificacao = Convert.ToInt32(id_classificao),
                Nome = nome,
                Duracao = DateTime.Parse(duracao),
                Descricao = descricao
            };


            //filme.Id = 4;
            appFilme.Salvar(filme);


            var dados = appFilme.ListarTodos();

            foreach (var filmes in dados)
            {
                Console.WriteLine("Id: {0}, id_classificacao: {1}, Nome: {2} ", filmes.Id, filmes.Id_classificacao,
                    filmes.Nome);

            }
        }
        
    }
}
