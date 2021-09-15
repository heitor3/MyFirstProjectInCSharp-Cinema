using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Aplicacao
{
    public class VerificaLogin
    {
        private readonly ILoginRepositorio<Tbl_CLIENTES> repositorio;

        public VerificaLogin(ILoginRepositorio<Tbl_CLIENTES> repo)
        {
            repositorio = repo;
        }

        public Tbl_CLIENTES Login(string login, string senha)
        {
            return repositorio.Login(login, senha);
        }

    }
}
