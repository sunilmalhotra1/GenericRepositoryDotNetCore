using Models.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
   public interface ICustomerService
    {

        List<Customer> GetCustomers();
    }
}
