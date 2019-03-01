using System.ComponentModel.DataAnnotations;

namespace RealD.Application.Repositories.Products.CQRS.Queries
{
    public class GetProductsByNameQuery
    {
        [Required]
        public string Name { get; set; }
    }
}
