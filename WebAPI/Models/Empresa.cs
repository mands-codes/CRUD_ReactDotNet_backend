using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Empresa
    {
        
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName="varchar(100)")]
        public string RazaoSocial { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string CNPJ { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string NomeFantasia { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }
        [Column(TypeName = "decimal(18,0)")]
        public decimal Telefone { get; set; }
    }
}
