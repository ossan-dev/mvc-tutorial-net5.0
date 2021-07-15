using Rocky.Models;
using System.Collections.Generic;

namespace Rocky.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers();
        IEnumerable<CustomerViewModel> GetCustomersBySubstring(string expr);
        //IEnumerable<CustomerViewModel> GetCustomerViewModels();
    }
}