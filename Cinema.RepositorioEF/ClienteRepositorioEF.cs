using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.RepositorioEF
{
    public class ClienteRepositorioEF : IRepositorio<Tbl_CLIENTES>
    {

        private readonly Contexto contexto;

        public ClienteRepositorioEF()
        {
            contexto = new Contexto();
        }

        public void Salvar(Tbl_CLIENTES entidade)
        {
            if (entidade.Id_cliente > 0)
            {
                var clienteAlterar = contexto.Tbl_CLIENTES.First(x => x.Id_cliente == entidade.Id_cliente);
                clienteAlterar.Nome = entidade.Nome;
                clienteAlterar.Cpf = entidade.Cpf;
                clienteAlterar.Nascimento = entidade.Nascimento;
                clienteAlterar.Senha = entidade.Senha;

            }
            else
            {
                contexto.Tbl_CLIENTES.Add(entidade);
            }
            contexto.SaveChanges();
        }

        public void Excluir(Tbl_CLIENTES entidade)
        {
            var clienteExcluir = contexto.Tbl_CLIENTES.First(x => x.Id_cliente == entidade.Id_cliente);
            contexto.Set<Tbl_CLIENTES>().Remove(clienteExcluir);
            contexto.SaveChanges();
        }

        public IEnumerable<Tbl_CLIENTES> ListarTodos()
        {


            return contexto.Tbl_CLIENTES;
        }

        public Tbl_CLIENTES ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            return contexto.Tbl_CLIENTES.First(x => x.Id_cliente == idInt);
        }


       
    }
}
