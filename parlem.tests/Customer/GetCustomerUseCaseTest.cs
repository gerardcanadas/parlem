using NUnit.Framework;
using Moq;
using parlem.domain.Models.Customer.Interfaces;
using CustomerModel = parlem.domain.Models.Customer;
using ProductModel = parlem.domain.Models.Product;
using System.Collections.Generic;
using System;
using parlem.application.UseCases.Customer;

namespace parlem.tests.Customer
{
    public class GetCustomerUseCaseTest
    {
        private GetCustomerByIdUseCase getCustomerByIdUseCase;
        private Mock<ICustomerRepository> customerRepoMock;

        private CustomerModel.Customer mockCustomer = new CustomerModel.Customer()
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
        };

        [SetUp]
        public void Setup()
        {
            customerRepoMock = new Mock<ICustomerRepository>();
            customerRepoMock
                .Setup(x => x.GetById(It.IsAny<int>()))
                .Returns(mockCustomer);

            getCustomerByIdUseCase = new GetCustomerByIdUseCase(customerRepoMock.Object);
        }

        [Test]
        public void GetCustomerById()
        {
            Assert.AreEqual(getCustomerByIdUseCase.Execute(1).DocNum, "12345678A");
        }
    }
}
