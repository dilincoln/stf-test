using Microsoft.EntityFrameworkCore;
using STFTest.Models;

namespace STFTest.Data.Seeds
{
    public class ProdutosSeed
    {
        public void Execute(ModelBuilder modelBuilder)
        {
            var products = new List<Produto> { };

            for (int i = 1; i <= 10; i++)
            {
                products.Add(new Produto
                {
                    Id = i,
                    NomeProduto = $"Produto {i}",
                    Valor = i * 10,
                });
            }

            modelBuilder.Entity<Produto>().HasData(products);
        }
    }
}