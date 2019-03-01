using Newtonsoft.Json;
using RealD.Application.Client;
using RealD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealD.Application.Repositories.Products.CQRS.Queries
{
    public class GetSingleProductQueryHandler
    {
        public async Task<Product> GetSingleAsync(GetSingleProductQuery query)
        {
            var client = new RemoteClient();
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("id", query.ID);

            var response = await client.sendRequest("POST", data);

            Product product = JsonConvert.DeserializeObject<Product>(response);

            product.PriceRecords = product.PriceRecords.Where(x => x.CurrencyCode == "ZAR").ToList();

            return product;
        }
    }
}
