using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Cinema.Dominio
{

    public partial class Tbl_ASSENTO
    {
        public Tbl_ASSENTO()
        {
            Tbl_INGRESSO = new HashSet<Tbl_INGRESSO>();
        }

        [Key]
        public int Id_assento { get; set; }

        public int? Id_sala { get; set; }

        [StringLength(10)]
        public string Corredor { get; set; }

        [StringLength(10)]
        public string Fileira { get; set; }

        [ForeignKey("Id_sala")]
        public virtual Tbl_SALAS Tbl_SALAS { get; set; }

        public virtual ICollection<Tbl_INGRESSO> Tbl_INGRESSO { get; set; }
    }
}
