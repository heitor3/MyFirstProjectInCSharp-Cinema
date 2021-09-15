using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Dominio.contrato
{
    public interface IIngressoRepositorio<T> where T : class
    {
        IEnumerable<Tbl_INGRESSO> ListarIngressos();

        void Comprar(T entidade);

        T ListarIngressosId(string id);
    }
}
