namespace TesteIndra
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Endereco")]
    public partial class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }

        public int? IdEmpresa { get; set; }

        [StringLength(8)]
        public string CEP { get; set; }

        [StringLength(120)]
        public string NomeRua { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
