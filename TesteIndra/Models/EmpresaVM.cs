using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TesteIndra.Models
{
    public class EmpresaVM
    {
        public int IdEmpresa { get; set; }

        //public int IdTelefone { get; set; }
       
        //public int IdEndereco { get; set; }

        [Required]
        [StringLength(120)]
        public string NomeEmpresa { get; set; }

        [Required]
        [StringLength(14)]
        public string CNPJ { get; set; }

        [Required]
        [StringLength(120)]
        public string NomeRepresentante { get; set; }


        public List<Endereco> Enderecos { get; set; }

        public List<Telefone> Telefone { get; set; }

       

        //public List<EmpresaVM> GetEmpresas()
        //{

        //    using (var context = new EmpresaContext())
        //    {
        //        var resultado = context.Database.SqlQuery<EmpresaVM>("SP_Empresa").ToList();
        //        return resultado.ToList();
        //    }


        //    return null;
        //}


    }
}