using Model = parlem.domain.Models.Customer;
using parlem.domain.Models.Customer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace parlem.infrastructure.Repositories.InMemory.Customer
{
    public class CustomerRepositoryInMemory : ICustomerRepository
    {

        private List<Model.Customer> customersListInMemory = new List<Model.Customer>()
        {
            new Model.Customer()
            {
                CustomerId = 1,
                DocType = "NIF",
                DocNum = "12345678A",
                Email = "test1@parlem.com",
                GivenName = "Josep Maria",
                FamilyName1 = "Segura",
                PhoneNumber = "612345678"
            },
            new Model.Customer()
            {
                CustomerId = 2,
                DocType = "NIF",
                DocNum = "11122233Z",
                Email = "test2@parlem.com",
                GivenName = "Montserrat",
                FamilyName1 = "Ivern",
                PhoneNumber = "600112234"
            }
        };

        public Model.Customer GetById(int customerId)
        {
            return customersListInMemory.FirstOrDefault(x => x.CustomerId == customerId);
        }
    }
}
