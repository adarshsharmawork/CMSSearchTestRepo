using System.Collections.Generic;
using CoreAPI.Models;

namespace CoreAPI.Data
{
    public interface ICustomerRepo
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerId(int Id);
    }
}
