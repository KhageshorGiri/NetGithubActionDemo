using EShop.Application.Dtos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/<ProductsController>
        [HttpGet("[action]")]
        public IEnumerable<ProductDto> GetAllProductList()
        {
            return null;
        }

        // GET api/<ProductsController>/5
        [HttpGet("[action]/{id}")]
        public ProductDto GetProductById(int id)
        {
            return null;
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void AddNewProduct([FromBody] CreateProductDto newProduct)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Update(Guid id, [FromBody] UpdateProductDto existingProduct)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
