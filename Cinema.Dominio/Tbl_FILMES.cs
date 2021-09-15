using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Dominio
{
   
    public partial class Tbl_FILMES
    {

        
        public Tbl_FILMES()
        {
            Tbl_GENERO_FILME = new HashSet<Tbl_GENERO_FILME>();
            Tbl_INGRESSO = new HashSet<Tbl_INGRESSO>();
            Tbl_SESSAO = new HashSet<Tbl_SESSAO>();
        }


        [Key]
        [Column("id_filme")]
        public int Id { get; set; }

        [DisplayName("Classificação")]
        public int? Id_classificacao { get; set; }

        
        [DisplayName("Nome do Filme")]
        public string Nome { get; set; }

        
        [DisplayName("Duração")]
        [DisplayFormat(DataFormatString = "{0:HH:mm:ss}")]
        public DateTime Duracao { get; set; }

        
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        public virtual Tbl_CLASSIFICACAO Tbl_CLASSIFICACAO { get; set; }

        public virtual ICollection<Tbl_GENERO_FILME> Tbl_GENERO_FILME { get; set; }

        public virtual ICollection<Tbl_INGRESSO> Tbl_INGRESSO { get; set; }

        public virtual ICollection<Tbl_SESSAO> Tbl_SESSAO { get; set; }

    }
}
