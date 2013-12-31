using ProjectName.BackEnd.Data.Entiteis;
using ProjectName.Shared.Dto;
using ROP;
using System;
using System.Threading.Tasks;

namespace ProjectName.BackEnd.API.Mappers
{
    public static class ProductMapper
    {
        public static Task<ProductDto> ToDto(Product p)
        => Task.FromResult(new ProductDto(Guid.Parse(p.ProductId), p.ProductName, p.ProductDescription));
    }
}
