using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Cinema.Dominio
{

    public partial class Tbl_GENEROS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_GENEROS()
        {
            Tbl_GENERO_FILME = new HashSet<Tbl_GENERO_FILME>();
        }

        [Key]
        public int Id_genero { get; set; }

        [StringLength(40)]
        public string Genero { get; set; }

        [StringLength(1000)]
        public string Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_GENERO_FILME> Tbl_GENERO_FILME { get; set; }
    }
}
