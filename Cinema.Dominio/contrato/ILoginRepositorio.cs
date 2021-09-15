using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Dominio.contrato
{
    public interface ILoginRepositorio<T> where T : class
    {
        Tbl_CLIENTES Login(string login, string senha);
        
    }
}
