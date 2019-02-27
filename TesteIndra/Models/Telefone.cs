namespace TesteIndra
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Telefone")]
    public partial class Telefone
    {
        [Key]
        public int IdTelefone { get; set; }

        public int? IdEmpresa { get; set; }

        [Column("Telefone")]
        [Required]
        [StringLength(11)]
        public string Telefone1 { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
