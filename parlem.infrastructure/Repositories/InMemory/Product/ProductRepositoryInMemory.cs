using Model = parlem.domain.Models.Product;
using parlem.domain.Models.Product.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;

namespace parlem.infrastructure.Repositories.InMemory.Product
{
    public class ProductRepositoryInMemory : IProductRepository
    {
        private readonly List<Model.Product> productsListInMemory = new List<Model.Product>()
        {
            new Model.Product()
            {
                ProductId = 1,
                ProductName = "FIBRA 1000 ADAMO",
                ProductTypeName = "ftth",
                TerminalNumeration = 94332333,
                SoldAt = DateTime.Now.AddDays(-3)
            },
            new Model.Product()
            {
                ProductId = 2,
                ProductName = "FIBRA 2000 ADAMO",
                ProductTypeName = "ftth",
                TerminalNumeration = 1112333,
                SoldAt = DateTime.Now.AddDays(-55)
            }
        };

        public Model.Product GetById(int productId)
        {
            return productsListInMemory.FirstOrDefault(x => x.ProductId == productId);
        }
    }
}
