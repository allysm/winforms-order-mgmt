using OrderMgmtLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMgmtLibrary.DataAccess
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrders();

        List<Order> GetCustomerOrders(Customer customer);

        bool CreateNewOrder(Order newOrder);

        List<Item> GetAllItems();
    }
}
