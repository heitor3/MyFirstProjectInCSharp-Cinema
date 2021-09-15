using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Cinema.Dominio
{


    public partial class Tbl_TIPO_INGRESSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_TIPO_INGRESSO()
        {
            Tbl_INGRESSO = new HashSet<Tbl_INGRESSO>();
        }

        [Key]
        public int Id_tipo_ingresso { get; set; }

        [StringLength(20)]
        public string Tipo_ingresso { get; set; }

        [StringLength(500)]
        public string Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_INGRESSO> Tbl_INGRESSO { get; set; }
    }
}
