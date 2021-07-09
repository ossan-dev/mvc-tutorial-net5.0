using Rocky.Models;
using System.Collections.Generic;

namespace Rocky.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers();
    }
}