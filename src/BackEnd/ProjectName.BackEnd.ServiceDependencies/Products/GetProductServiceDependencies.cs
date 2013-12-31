using ProjectName.BackEnd.Data.Database;
using ProjectName.BackEnd.Data.Entiteis;
using ProjectName.BackEnd.Services.Products;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectName.BackEnd.ServiceDependencies.Products
{
    public class GetProductServiceDependencies : IGetProductServiceDependencies
    {
        private readonly DatabaseContext _db;

        public GetProductServiceDependencies(DatabaseContext databaseContext)
        {
            _db = databaseContext;
        }

        public async Task<Product?> GetById(string productId)
        {
            return await _db.Product.FirstOrDefaultAsync(a => a.ProductId == productId);
        }
    }
}
