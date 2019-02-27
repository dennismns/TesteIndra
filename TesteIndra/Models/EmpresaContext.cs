namespace TesteIndra
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmpresaContext : DbContext
    {
        public EmpresaContext()
            : base("name=EmpresaContext")
        {
        }

        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Telefone> Telefone { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresa>()
                .Property(e => e.NomeEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.NomeRepresentante)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.NomeRua)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Telefone>()
                .Property(e => e.Telefone1)
                .IsUnicode(false);
        }
    }
}
