using Microsoft.AspNetCore.Mvc;
using parlem.application.UseCases.Customer;

namespace parlem.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly GetCustomerByIdUseCase getCustomerByIdUseCase;
        private readonly GetCustomersListUseCase getCustomersListUseCase;

        public CustomerController(GetCustomerByIdUseCase getCustomerByIdUseCase, GetCustomersListUseCase getCustomersListUseCase)
        {
            this.getCustomerByIdUseCase = getCustomerByIdUseCase;
            this.getCustomersListUseCase = getCustomersListUseCase;
        }

        [HttpGet, Route("list")]
        public IActionResult GetList()
        {
            return Ok(getCustomersListUseCase.Execute());
        }


        [HttpGet, Route("{customerId}")]
        public IActionResult GetById(int customerId)
        {
            return Ok(getCustomerByIdUseCase.Execute(customerId));
        }

        [HttpGet, Route("{customerId}/products")]
        public IActionResult GetCustomerProductsList(int customerId)
        {
            return Ok(getCustomerByIdUseCase.Execute(customerId).CustomerProducts);
        }
    }
}
