using Cinema.Dominio;
using System.Data.Entity;

namespace Cinema.RepositorioEF
{
    public partial class Contexto : DbContext
    {
        public Contexto() : base("CinemaProjeto")
        {

        }

        public virtual DbSet<Tbl_ASSENTO> Tbl_ASSENTO { get; set; }
        public virtual DbSet<Tbl_CLASSIFICACAO> Tbl_CLASSIFICACAO { get; set; }
        public virtual DbSet<Tbl_CLIENTES> Tbl_CLIENTES { get; set; }
        public virtual DbSet<Tbl_ENDERECOS> Tbl_ENDERECOS { get; set; }
        public virtual DbSet<Tbl_FILMES> Filmes { get; set; }
        public virtual DbSet<Tbl_GENERO_FILME> Tbl_GENERO_FILME { get; set; }
        public virtual DbSet<Tbl_GENEROS> Tbl_GENEROS { get; set; }
        public virtual DbSet<Tbl_INGRESSO> Tbl_INGRESSO { get; set; }
        public virtual DbSet<Tbl_SALAS> Tbl_SALAS { get; set; }
        public virtual DbSet<Tbl_SESSAO> Tbl_SESSAO { get; set; }
        public virtual DbSet<Tbl_TIPO_INGRESSO> Tbl_TIPO_INGRESSO { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Tbl_ASSENTO>()
           .Property(e => e.Corredor)
           .IsUnicode(false);

            modelBuilder.Entity<Tbl_ASSENTO>()
                .Property(e => e.Fileira)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_CLASSIFICACAO>()
                .Property(e => e.Classificacao)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_CLASSIFICACAO>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_CLIENTES>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_CLIENTES>()
                .Property(e => e.Cpf)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_CLIENTES>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_CLIENTES>()
                .Property(e => e.Senha)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_ENDERECOS>()
                .Property(e => e.Cep)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_ENDERECOS>()
                .Property(e => e.Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_ENDERECOS>()
                .Property(e => e.Uf)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_ENDERECOS>()
                .Property(e => e.Rua)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_ENDERECOS>()
                .Property(e => e.Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_ENDERECOS>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_FILMES>()
                .Property(e => e.Id)
                .IsRequired();

            modelBuilder.Entity<Tbl_FILMES>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_FILMES>()
                .Property(e => e.Duracao);


            modelBuilder.Entity<Tbl_FILMES>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_GENEROS>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_GENEROS>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SALAS>()
                .Property(e => e.Sala)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SESSAO>()
                .Property(e => e.Horario);


            modelBuilder.Entity<Tbl_TIPO_INGRESSO>()
                .Property(e => e.Tipo_ingresso)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_TIPO_INGRESSO>()
                .Property(e => e.Descricao)
                .IsUnicode(false);



            //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //    //modelBuilder.Entity<Tbl_FILMES>().Property(x => x.Id_classificacao).IsRequired();
            //   // modelBuilder.Entity<Tbl_FILMES>().Property(x => x.Nome).IsRequired().HasColumnType("varchar");
            //   // modelBuilder.Entity<Tbl_FILMES>().Property(x => x.Duracao).IsRequired().HasColumnType("varchar");
            //   // modelBuilder.Entity<Tbl_FILMES>().Property(x => x.Descricao).IsRequired().HasColumnType("varchar");

        }
    }
}
