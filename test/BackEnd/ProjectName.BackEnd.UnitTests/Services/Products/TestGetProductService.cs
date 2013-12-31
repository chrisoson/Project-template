using Moq;
using ProjectName.BackEnd.Data.Entiteis;
using ProjectName.BackEnd.Services.Products;
using ROP;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ProjectName.BackEnd.UnitTests.Services.Products
{
    public class TestGetProductService
    {
        [Fact]
        public async Task GetProductWhenCodeExist_ThenSuccess()
        {
            Mock<IGetProductServiceDependencies> dependencies = new Mock<IGetProductServiceDependencies>();
            Guid productId = Guid.NewGuid();
            Product product = new Product(productId.ToString(), "productName", "productDescription");

            dependencies.Setup(a => a.GetById(productId.ToString()))
                .ReturnsAsync(product);

            GetProductService _subject = new GetProductService(dependencies.Object);

            Result<Product> result = await _subject.Execute(productId);

            Assert.True(result.Success);
            Assert.Equal(product.ProductId, result.Value.ProductId);
            Assert.Equal(product.ProductName, result.Value.ProductName);
            Assert.Equal(product.ProductDescription, result.Value.ProductDescription);
        }

        [Fact]
        public async Task GetProductWhenCodeDoesNotExist_ThenError()
        {
            Mock<IGetProductServiceDependencies> dependencies = new Mock<IGetProductServiceDependencies>();
            Guid productId = Guid.NewGuid();

            dependencies.Setup(a => a.GetById(It.IsAny<string>()))
                .ReturnsAsync((Product?)null);

            GetProductService _subject = new GetProductService(dependencies.Object);

            Result<Product> result = await _subject.Execute(productId);

            Assert.False(result.Success);
            Assert.Single(result.Errors);
            Assert.Equal($"the product {productId} does not exist", result.Errors.First().Message);
        }
    }
}
