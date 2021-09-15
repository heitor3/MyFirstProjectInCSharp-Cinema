using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.RepositorioEF
{
    public class LoginRepositorioEF : ILoginRepositorio<Tbl_CLIENTES>
    {
        private readonly Contexto contexto;

        public LoginRepositorioEF()
        {
            contexto = new Contexto();
        }

        public Tbl_CLIENTES Login(string login, string senha)
        {
            var usuario = contexto.Tbl_CLIENTES.FirstOrDefault(x => x.Email == login && x.Senha == senha);

            //if (usuario == null)
            //{
            //    usuario = null;
            //    return usuario;
            //}
            //else
            return usuario;


        }
    }
}
