using System;
using System.ComponentModel.DataAnnotations;

namespace PrimeiroEF.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage="Insira um nome com até 50 caracteres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(75,ErrorMessage="Entre com seu email")]
        public string Email { get; set; }
        [Required]
        [Range(1,100)]
        public int Idade { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }
    }
}