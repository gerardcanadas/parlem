using parlem.domain.Models.Customer.Interfaces;
using Models = parlem.domain.Models.Customer;


namespace parlem.application.UseCases.Customer
{
    public class GetCustomerUseCase
    {
        private ICustomerRepository customerRepository;

        public GetCustomerUseCase(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public Models.Customer Execute(int customerId)
        {
            return customerRepository.GetById(customerId);
        }
    }
}
