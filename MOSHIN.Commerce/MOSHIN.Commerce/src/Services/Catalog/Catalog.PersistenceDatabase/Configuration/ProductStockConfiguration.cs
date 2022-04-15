using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.PersistenceDatabase.Configuration
{
    public class ProductStockConfiguration
    {
        public ProductStockConfiguration(EntityTypeBuilder<ProductInStock> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ProductInStockId);

            var Stocks = new List<ProductInStock>();
            var random = new Random();

            for (var i = 1; i <= 100; i++)
            {
                Stocks.Add(new ProductInStock
                {
                    ProductInStockId = i,
                    ProductId = i,
                    Stock = random.Next(0, 20)
                });
            }
            entityBuilder.HasData(Stocks);
        }
    }
}
