namespace TesteIndra
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empresa")]
    public partial class Empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresa()
        {
            Endereco = new HashSet<Endereco>();
            Telefone = new HashSet<Telefone>();
        }

        [Key]
        public int IdEmpresa { get; set; }

        [Required]
        [StringLength(120)]
        public string NomeEmpresa { get; set; }

        [Required]
        [StringLength(14)]
        public string CNPJ { get; set; }

        [Required]
        [StringLength(120)]
        public string NomeRepresentante { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Endereco> Endereco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Telefone> Telefone { get; set; }
    }
}
