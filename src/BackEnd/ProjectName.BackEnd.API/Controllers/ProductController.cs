using Microsoft.AspNetCore.Mvc;
using ProjectName.BackEnd.API.Mappers;
using ProjectName.BackEnd.Services.Products;
using ROP;
using ROP.APIExtensions;
using System;
using System.Threading.Tasks;

namespace ProjectName.BackEnd.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProductController : Controller
    {
        private readonly GetProductService _getProduct;

        public ProductController(GetProductService getProduct)
        {
            _getProduct = getProduct;
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetById(Guid productId)
        {
            return await _getProduct.Execute(productId)
                .Map(ProductMapper.ToDto)
                .ToActionResult();
        }
    }
}
