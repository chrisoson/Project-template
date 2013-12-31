using System;


namespace ProjectName.Shared.Dto
{
    public record ProductDto
    {
        public Guid ProductId { get; init; }
        public string ProductName { get; init; }
        public string ProductDescription { get; init; }

        public ProductDto(Guid productId, string productName, string productDescription)
        {
            ProductId = productId;
            ProductName = productName;
            ProductDescription = productDescription;
        }
    }
}
