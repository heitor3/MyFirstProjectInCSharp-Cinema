using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Cinema.Dominio
{


    public partial class Tbl_SALAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_SALAS()
        {
            Tbl_ASSENTO = new HashSet<Tbl_ASSENTO>();
            Tbl_SESSAO = new HashSet<Tbl_SESSAO>();
        }

        [Key]
        public int Id_sala { get; set; }

        [StringLength(50)]
        public string Sala { get; set; }

        public short? Lotacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_ASSENTO> Tbl_ASSENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_SESSAO> Tbl_SESSAO { get; set; }
    }
}
