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
        public Empresa()
        {
            Endereco = new List<Endereco>();
            Telefone = new List<Telefone>();
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

     
        public virtual List<Endereco> Endereco { get; set; }

       
        public virtual List<Telefone> Telefone { get; set; }
        
       

    }
}
