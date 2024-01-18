using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STFTest.Models
{
    public class Produto : BaseEntity
    {
        [Required(ErrorMessage = "O nome do produto é obrigatório")]
        [Column(TypeName = "varchar(20)")]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage = "O preço do produto é obrigatório")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }
    } 
}