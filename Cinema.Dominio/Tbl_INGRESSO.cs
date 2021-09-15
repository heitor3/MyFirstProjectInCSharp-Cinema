using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Cinema.Dominio
{


    public partial class Tbl_INGRESSO
    {
        [Key]
        public int Id_ingresso { get; set; }

        [ForeignKey(nameof(Tbl_FILMES))]
        public int? Id_filme { get; set; }

        public int? Id_sessao { get; set; }

        public int? Id_cliente { get; set; }

        public int? Id_assento { get; set; }

        public int? Id_tipo_ingresso { get; set; }

        public DateTime? DataCompra { get; set; }

        public virtual Tbl_ASSENTO Tbl_ASSENTO { get; set; }

        public virtual Tbl_CLIENTES Tbl_CLIENTES { get; set; }

        public virtual Tbl_FILMES Tbl_FILMES { get; set; }

        public virtual Tbl_SESSAO Tbl_SESSAO { get; set; }

        public virtual Tbl_TIPO_INGRESSO Tbl_TIPO_INGRESSO { get; set; }
    }
}
