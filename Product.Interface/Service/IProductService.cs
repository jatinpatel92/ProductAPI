using System.Collections.Generic;
using Product.Domain;

namespace Product.Interface
{
    public interface IProductService
    {
        List<ProductDetail> GetAllProduct();
    }
}
