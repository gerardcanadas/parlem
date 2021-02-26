using parlem.domain.Models.Customer.Interfaces;
using System.Collections.Generic;
using Models = parlem.domain.Models.Customer;

namespace parlem.application.UseCases.Customer
{
    public class GetCustomersListUseCase
    {
        private ICustomerRepository customerRepository;

        public GetCustomersListUseCase(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public List<Models.Customer> Execute()
        {
            return customerRepository.GetList();
        }
    }
}
