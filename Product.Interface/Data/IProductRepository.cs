using Product.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Interface.Data
{
    public interface IProductRepository
    {
        List<ProductDetail> GetAllProduct();
    }
}
