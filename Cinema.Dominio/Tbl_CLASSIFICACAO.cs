using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Cinema.Dominio
{


    public partial class Tbl_CLASSIFICACAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_CLASSIFICACAO()
        {
            Tbl_FILMES = new HashSet<Tbl_FILMES>();
        }

        [Key]
        public int Id_classificacao { get; set; }

        [StringLength(30)]
        public string Classificacao { get; set; }

        [StringLength(1000)]
        public string Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_FILMES> Tbl_FILMES { get; set; }
    }
}
