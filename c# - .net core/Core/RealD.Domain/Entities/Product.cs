using System;
using System.Collections.Generic;
using System.Text;

namespace RealD.Domain.Entities
{
    public class Product
    {
        public string BarCode { get; set; }
        public string ItemName { get; set; }
        public List<ProductPrice> PriceRecords { get; set; }
    }
}
