using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Cinema.Dominio
{

    public partial class Tbl_GENERO_FILME
    {
        [Key]
        public int Id_generoFilme { get; set; }

        public int? Id_filme { get; set; }

        public int? Id_genero { get; set; }

        public virtual Tbl_FILMES Tbl_FILMES { get; set; }

        public virtual Tbl_GENEROS Tbl_GENEROS { get; set; }
    }
}
