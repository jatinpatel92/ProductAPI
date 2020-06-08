using Microsoft.AspNetCore.Mvc;
using Product.Domain;
using Product.Interface;
using System.Collections.Generic;

namespace Product.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region Private Veriables

        private readonly IProductService productService;

        #endregion

        #region Constructor

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        #endregion

        #region Public Methods

        [HttpGet]
        public ActionResult<List<ProductDetail>> Get()
        {
            return productService.GetAllProduct();
        }

        ////[HttpGet("{id}")]
        ////public ActionResult<string> Get(int id)
        ////{
        ////    return "value";
        ////}

        ////[HttpPost]
        ////public void Post([FromBody] string value)
        ////{
        ////}

        ////[HttpPut("{id}")]
        ////public void Put(int id, [FromBody] string value)
        ////{
        ////}

        ////[HttpDelete("{id}")]
        ////public void Delete(int id)
        ////{
        ////}

        #endregion

        #region Private Methods



        #endregion
    }
}
