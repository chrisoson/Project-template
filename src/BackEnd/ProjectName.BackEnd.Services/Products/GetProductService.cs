using ProjectName.BackEnd.Data.Entiteis;
using ROP;
using System;
using System.Threading.Tasks;

namespace ProjectName.BackEnd.Services.Products
{
    public interface IGetProductServiceDependencies
    {
        Task<Product?> GetById(string productId);
    }

    public class GetProductService
    {

        private readonly IGetProductServiceDependencies _dependencies;

        public GetProductService(IGetProductServiceDependencies dependencies)
        {
            _dependencies = dependencies;
        }

        public async Task<Result<Product>> Execute(Guid productId)
        {
            return await GetFromDatabase(productId); 
        }

        private async Task<Result<Product>> GetFromDatabase(Guid productId)
        {
            Product? product = await _dependencies.GetById(productId.ToString());

            //TODO: add translations?.
            if (product == null)
                return Result.NotFound<Product>($"the product {productId} does not exist");
            
            return product;
        }
    }
}
