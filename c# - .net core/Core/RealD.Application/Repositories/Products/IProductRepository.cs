using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RealD.Application.Repositories.Products.CQRS.Queries;
using RealD.Domain.Entities;

namespace RealD.Application.Repositories.Products
{
    public interface IProductRepository
    {
        Task<Product> GetSingle(GetSingleProductQuery query);
        Task<List<Product>> GetByName(GetProductsByNameQuery query);
    }
}
