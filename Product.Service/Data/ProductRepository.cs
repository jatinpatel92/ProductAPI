using Product.Domain;
using Product.Interface.Data;
using System.Collections.Generic;

namespace Product.Service.Data
{
    public class ProductRepository : IProductRepository
    {
        public List<ProductDetail> GetAllProduct()
        {
            List<ProductDetail> productDetails = new List<ProductDetail>() {
                    new ProductDetail() {
                        Id = 1,
                        ProductName = "Hand Mixture",
                        Brand = "Bajaj",
                        ModelNumber = "MX100",
                        Price = "500",
                        Category = "Kitchen",
                        IsActive = true
                    },
                    new ProductDetail() {
                        Id = 1,
                        ProductName = "Vaccume Cleaner",
                        Brand = "Philips",
                        ModelNumber = "VC200",
                        Price = "3500",
                        Category = "Home",
                        IsActive = true
                    }
                };
            return productDetails;
        }
    }
}
