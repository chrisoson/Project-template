using ProjectName.BackEnd.API.Mappers;
using ProjectName.BackEnd.Data.Entiteis;
using ProjectName.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjectName.BackEnd.UnitTests.API.Mappers
{
    public class TestProductMapper
    {
        [Fact]
        public async Task MapProduct_ToProductDto()
        {
            Product originalProduct = new Product("76F7FDFA-C94B-4387-BBBF-9567D0BCCFC0", "name", "description");

            ProductDto result = await ProductMapper.ToDto(originalProduct);

            Assert.Equal(originalProduct.ProductDescription, result.ProductDescription);
            Assert.Equal(originalProduct.ProductName, result.ProductName);
            Assert.Equal(Guid.Parse(originalProduct.ProductId), result.ProductId);
        }
    }
}
