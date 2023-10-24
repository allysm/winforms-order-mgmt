using OrderMgmtLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMgmtLibrary.DataAccess
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();

        bool AddNewCustomer(Customer newCustomer);

        bool UpdateCustomerInfo(Customer updatedCustomer);

        bool DeleteCustomer(int customerId);
    }
}
