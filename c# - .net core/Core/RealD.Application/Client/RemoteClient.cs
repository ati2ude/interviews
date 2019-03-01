using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace RealD.Application.Client
{
    public class RemoteClient
    {
        private Uri uri;
        private WebClient client;

        public RemoteClient()
        {
            client = new WebClient();
            uri = new Uri("http://192.168.0.241/eanlist?type=Web");
        }

        public async Task<string> sendRequest(string requestType, Dictionary<string, string> data)
        {
            //return test fro list
            //return "[{\"BarCode\":\"bar_code_1\",\"ItemName\":\"item_name_1\",\"PriceRecords\":[{\"SellingPrice\":100,\"CurrencyCode\":\"USD\"},{\"SellingPrice\":1000,\"CurrencyCode\":\"ZAR\"},{\"SellingPrice\":90,\"CurrencyCode\":\"EUR\"}]}]"; //returns for list

            //return test for single
            //return "{\"BarCode\":\"bar_code_1\",\"ItemName\":\"item_name_1\",\"PriceRecords\":[{\"SellingPrice\":100,\"CurrencyCode\":\"USD\"},{\"SellingPrice\":1000,\"CurrencyCode\":\"ZAR\"},{\"SellingPrice\":90,\"CurrencyCode\":\"EUR\"}]}";

            return await client.UploadStringTaskAsync(uri, requestType, JsonConvert.SerializeObject(data));
        }
    }
}
