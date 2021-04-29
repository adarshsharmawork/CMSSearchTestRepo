using System;
using System.Collections.Generic;
using CoreAPI.Models;

namespace CoreAPI.Data
{
    public class MockData : ICustomerRepo
    {
        IEnumerable<Customer> ICustomerRepo.GetAllCustomers()
        {
            List<Customer> result = new List<Customer>();

            for (int i = 0; i < 3; i++)
            {
                Customer customer = new Customer();
                customer.CustomerId = i;
                customer.CustomerName = "Adarsh" + i;
                customer.CustomerAddress = "New Address" + i;
                customer.CustomerNumber = "183938" + i;
                result.Add(customer);
            }
            return result;
        }

        Customer ICustomerRepo.GetCustomerId(int Id)
        {
            return new Customer { CustomerId = 1, CustomerName = "New Name", CustomerAddress = "great address", CustomerNumber = "4749393" };
        }
    }
}
