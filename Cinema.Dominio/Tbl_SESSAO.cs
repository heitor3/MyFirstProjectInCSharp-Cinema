using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Cinema.Dominio
{


    public partial class Tbl_SESSAO
    {

        public Tbl_SESSAO()
        {
            Tbl_INGRESSO = new HashSet<Tbl_INGRESSO>();
        }

        [Key]
        public int Id_sessao { get; set; }

        public int Id_filme { get; set; }

        public int Id_sala { get; set; }

        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public DateTime Horario { get; set; }

        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Data { get; set; }

        [ForeignKey("Id_filme")]
        public virtual Tbl_FILMES Tbl_FILMES { get; set; }

        public virtual ICollection<Tbl_INGRESSO> Tbl_INGRESSO { get; set; }

        public virtual Tbl_SALAS Tbl_SALAS { get; set; }
    }
}
