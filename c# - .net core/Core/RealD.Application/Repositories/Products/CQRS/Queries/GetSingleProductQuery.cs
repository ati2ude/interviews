using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RealD.Application.Repositories.Products.CQRS.Queries
{
    public class GetSingleProductQuery
    {
        [Required]
        public string ID { get; set; }
    }
}
