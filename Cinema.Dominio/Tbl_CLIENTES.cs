using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Dominio
{


    public partial class Tbl_CLIENTES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_CLIENTES()
        {
            Tbl_ENDERECOS = new HashSet<Tbl_ENDERECOS>();
            Tbl_INGRESSO = new HashSet<Tbl_INGRESSO>();
        }

        [Key]
        public int Id_cliente { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "* Preenchimento obrigatorio")]
        public string Nome { get; set; }

        [StringLength(11)]
        [DisplayName("CPF")]
        [Required(ErrorMessage = "* Preenchimento obrigatorio")]
        public string Cpf { get; set; }

        [DisplayName("Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:ddmmyyyy}")]
        [Required(ErrorMessage = "* Preenchimento obrigatorio")]
        public DateTime? Nascimento { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "* Preenchimento obrigatorio")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Insira um email válido")]
        public string Email { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "* Preenchimento obrigatorio")]
        public string Senha { get; set; }

        [DisplayName("Confirmar senha")]
        [Compare("Senha", ErrorMessage = "As senhas não conferem")]
        [NotMapped]
        public string ConfirmaSenha { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_ENDERECOS> Tbl_ENDERECOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_INGRESSO> Tbl_INGRESSO { get; set; }
    }
}
