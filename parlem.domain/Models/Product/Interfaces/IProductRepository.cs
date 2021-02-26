using System;
using System.Collections.Generic;
using System.Text;

namespace parlem.domain.Models.Product.Interfaces
{
    public interface IProductRepository
    {
        Product GetById(int productId);
    }
}
