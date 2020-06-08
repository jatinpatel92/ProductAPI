using Product.Domain;
using Product.Interface;
using Product.Interface.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Service
{
    public class ProductService : IProductService
    {
        #region Private Veriables

        private readonly IProductRepository productRepository;

        #endregion

        #region Constructor

        public ProductService(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }

        #endregion

        #region Public Methods

        public List<ProductDetail> GetAllProduct()
        {
            return productRepository.GetAllProduct();
        }

        #endregion
    }
}
