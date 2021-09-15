using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Cinema.Dominio
{


    public partial class Tbl_ENDERECOS
    {
        [Key]
        public int Id_endereco { get; set; }

        public int? Id_cliente { get; set; }

        [StringLength(8)]
        public string Cep { get; set; }

        [StringLength(40)]
        public string Cidade { get; set; }

        [StringLength(2)]
        public string Uf { get; set; }

        [StringLength(50)]
        public string Rua { get; set; }

        [StringLength(40)]
        public string Bairro { get; set; }

        [StringLength(4)]
        public string Numero { get; set; }

        public virtual Tbl_CLIENTES Tbl_CLIENTES { get; set; }
    }
}
