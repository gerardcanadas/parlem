using Microsoft.AspNetCore.Mvc;
using parlem.application.UseCases.Product;

namespace parlem.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly GetProductUseCase getProductUseCase;

        public ProductController(GetProductUseCase getProductUseCase)
        {
            this.getProductUseCase = getProductUseCase;
        }

        [HttpGet, Route("{productId}")]
        public IActionResult GetById(int productId)
        {
            return Ok(getProductUseCase.Execute(productId));
        }
    }
}
