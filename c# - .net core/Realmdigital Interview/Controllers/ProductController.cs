using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RD.Common.Extensions;
using RealD.Application.Repositories.Products;
using RealD.Application.Repositories.Products.CQRS.Queries;

namespace Realmdigital_Interview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"welcome"};
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductByIdAsync(string id)
        {
            if (Extension.IsNumeric(id))
            {
                return Ok(await _productRepository.GetSingle(new GetSingleProductQuery { ID = id }));
            }
            else
            {
                return BadRequest(new { message = "Invalid or no Id" });
            }
        }

        [HttpGet("search/{productName}")]
        public async Task<IActionResult> GetProductsByName(string productName)
        {
            if (!string.IsNullOrEmpty(productName))
            {
                return Ok(await _productRepository.GetByName(new GetProductsByNameQuery { Name = productName }));
            }
            else
            {
                return BadRequest(new { message = "Invalid or no product name" });
            }
        }
    }
}