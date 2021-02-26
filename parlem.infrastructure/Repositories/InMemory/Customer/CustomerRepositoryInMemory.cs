using CustomerModel = parlem.domain.Models.Customer;
using ProductModel = parlem.domain.Models.Product;
using parlem.domain.Models.Customer.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System;

namespace parlem.infrastructure.Repositories.InMemory.Customer
{
    public class CustomerRepositoryInMemory : ICustomerRepository
    {
        private List<CustomerModel.Customer> customersListInMemory = new List<CustomerModel.Customer>()
        {
            new CustomerModel.Customer()
            {
                CustomerId = 1,
                DocType = "NIF",
                DocNum = "12345678A",
                Email = "test1@parlem.com",
                GivenName = "Josep Maria",
                FamilyName1 = "Segura",
                PhoneNumber = "612345678",
                CustomerProducts = new List<ProductModel.Product>()
                {
                    new ProductModel.Product()
                    {
                        ProductId = 1,
                        ProductName = "FIBRA 1000 ADAMO",
                        ProductTypeName = "ftth",
                        TerminalNumeration = 94332333,
                        SoldAt = DateTime.Now.AddDays(-3)
                    },
                    new ProductModel.Product()
                    {
                        ProductId = 2,
                        ProductName = "FIBRA 2000 ADAMO",
                        ProductTypeName = "ftth",
                        TerminalNumeration = 1112333,
                        SoldAt = DateTime.Now.AddDays(-55)
                    }
                }
            },
            new CustomerModel.Customer()
            {
                CustomerId = 2,
                DocType = "NIF",
                DocNum = "11122233Z",
                Email = "test2@parlem.com",
                GivenName = "Montserrat",
                FamilyName1 = "Ivern",
                PhoneNumber = "600112234",
                CustomerProducts = new List<ProductModel.Product>() 
                {
                    new ProductModel.Product()
                    {
                        ProductId = 2,
                        ProductName = "FIBRA 2000 ADAMO",
                        ProductTypeName = "ftth",
                        TerminalNumeration = 1112333,
                        SoldAt = DateTime.Now.AddDays(-55)
                    }
                }
            }
        };

        public CustomerModel.Customer GetById(int customerId)
        {
            return customersListInMemory.FirstOrDefault(x => x.CustomerId == customerId);
        }

        public List<CustomerModel.Customer> GetList()
        {
            return customersListInMemory.ToList();
        }
    }
}
