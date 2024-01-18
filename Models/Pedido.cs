using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STFTest.Models
{
    public class Pedido : BaseEntity
    {
        [Required(ErrorMessage = "O nome do cliente é obrigatório")]
        [Column(TypeName = "varchar(60)")]
        public string NomeCliente { get; set; }

        [Required(ErrorMessage = "O e-mail do cliente é obrigatório")]
        [Column(TypeName = "varchar(60)")]
        public string EmailCliente { get; set; }
        
        public bool Pago { get; set; }
    } 
}