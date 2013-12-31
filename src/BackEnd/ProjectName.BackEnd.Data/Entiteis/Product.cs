using System;

namespace ProjectName.BackEnd.Data.Entiteis
{
    public class Product
    {
        public string ProductId { get; init; }
        public string ProductName { get; init; }
        public string ProductDescription { get; init; }

        public Product(string productId, string productName, string productDescription)
        {
            ProductId = productId;
            ProductName = productName;
            ProductDescription = productDescription;
        }
    }
}
