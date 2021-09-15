using System;
using System.Collections.Generic;

namespace Cinema.Dominio.contrato
{
    public interface ISessaoRepositorio<T> where T : class
    {
        IEnumerable<Tbl_SESSAO> ListarSessao(string id);
       
    }
}
