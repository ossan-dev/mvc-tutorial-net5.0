using Rocky.DB;
using Rocky.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IDataProvider _dataProvider;

        public CustomerService(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            List<Customer> customers = new();
            var queryText = @"SELECT id, first_name, last_name FROM customer";
            var dt = _dataProvider.GetData(queryText);
            foreach (DataRow item in dt.Rows)
            {
                var customer = new Customer
                {
                    Id = Convert.ToInt32(item.ItemArray[0]),
                    FirstName = Convert.ToString(item.ItemArray[1]),
                    LastName = Convert.ToString(item.ItemArray[2])
                };

                customers.Add(customer);
            }

            return customers;
        }

        //public IEnumerable<CustomerViewModel> GetCustomerViewModels()
        //{
        //    List<CustomerViewModel> customers = new();
        //    var queryText = @"SELECT id, name FROM customer";
        //    var dt = _dataProvider.GetData(queryText);
        //    foreach (DataRow item in dt.Rows)
        //    {
        //        var customer = new CustomerViewModel
        //        {
        //            CustomerId = Convert.ToInt32(item.ItemArray[0]),
        //            CustomerName = Convert.ToString(item.ItemArray[1])
        //        };

        //        customers.Add(customer);
        //    }

        //    return customers;
        //}

        public IEnumerable<CustomerViewModel> GetCustomersBySubstring(string expr)
        {
            List<CustomerViewModel> customers = new();
            var queryText = $"SELECT id, name FROM customer WHERE name LIKE '%{expr}%'";
            var dt = _dataProvider.GetData(queryText);
            foreach (DataRow item in dt.Rows)
            {
                var customer = new CustomerViewModel
                {
                    CustomerId = Convert.ToString(item.ItemArray[0]),
                    CustomerName = Convert.ToString(item.ItemArray[1])
                };

                customers.Add(customer);
            }

            return customers;
        }
    }
}
