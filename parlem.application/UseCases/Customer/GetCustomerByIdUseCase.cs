using parlem.domain.Models.Customer.Interfaces;
using Models = parlem.domain.Models.Customer;


namespace parlem.application.UseCases.Customer
{
    public class GetCustomerByIdUseCase
    {
        private ICustomerRepository customerRepository;

        public GetCustomerByIdUseCase(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public Models.Customer Execute(int customerId)
        {
            return customerRepository.GetById(customerId);
        }
    }
}
