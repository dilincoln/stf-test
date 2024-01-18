using System.ComponentModel.DataAnnotations.Schema;

namespace STFTest.Models
{
    public class ItemPedido : BaseEntity
    {
        [ForeignKey("Produto")]
        public int IdProduto { get; set; }

        public int Quantidade { get; set; }

        public Produto Produto { get; set; }
    } 
}