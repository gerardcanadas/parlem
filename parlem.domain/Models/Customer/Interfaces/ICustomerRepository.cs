using System;
using System.Collections.Generic;
using System.Text;

namespace parlem.domain.Models.Customer.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetById(int customerId);
    }
}
