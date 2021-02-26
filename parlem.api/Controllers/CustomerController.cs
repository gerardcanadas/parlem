using Microsoft.AspNetCore.Mvc;
using parlem.application.UseCases.Customer;

namespace parlem.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly GetCustomerUseCase getCustomerUseCase;

        public CustomerController(GetCustomerUseCase getCustomerUseCase)
        {
            this.getCustomerUseCase = getCustomerUseCase;
        }

        [HttpGet, Route("{customerId}")]
        public IActionResult GetById(int customerId)
        {
            return Ok(getCustomerUseCase.Execute(customerId));
        }        
    }
}
