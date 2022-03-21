﻿using Catalog.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task CreateProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(string id);

        Task<Product> GetProduct(string id);
        Task<IEnumerable<Product>> GetProducts();
        Task<IEnumerable<Product>> GetProductByName(string name);
        Task<IEnumerable<Product>> GetProductByCategory(string category);
    }
}
