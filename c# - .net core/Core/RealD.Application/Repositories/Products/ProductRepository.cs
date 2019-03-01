using RealD.Application.Repositories.Products.CQRS.Queries;
using RealD.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealD.Application.Repositories.Products
{
    public class ProductRepository : IProductRepository
    {
        public async Task<Product> GetSingle(GetSingleProductQuery query)
        {
            return await new GetSingleProductQueryHandler().GetSingleAsync(query);
        }

        public async Task<List<Product>> GetByName(GetProductsByNameQuery query)
        {
            return await new GetProductsByNameQueryHandler().GetByNameAsync(query);
        }
    }
}
