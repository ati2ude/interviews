using Newtonsoft.Json;
using RealD.Application.Client;
using RealD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealD.Application.Repositories.Products.CQRS.Queries
{
    public class GetProductsByNameQueryHandler
    {
        public async Task<List<Product>> GetByNameAsync(GetProductsByNameQuery query)
        {
            var client = new RemoteClient();
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("name", query.Name);

            var response = await client.sendRequest("POST", data);

            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(response);

            foreach (var product in products)
            {
                product.PriceRecords = product.PriceRecords.Where(x => x.CurrencyCode == "ZAR").ToList();
            }

            return products;
        }
    }
}
