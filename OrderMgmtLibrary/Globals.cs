using OrderMgmtLibrary.DataAccess;
using OrderMgmtLibrary.DataAccess.Implementation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMgmtLibrary
{
    public class Globals
    {
        public static readonly string SalesProcessDBConnStr = ConfigurationManager.ConnectionStrings["SalesProcess"].ConnectionString; 
        
        public static ICustomerRepository CustomerRepository { get; private set; }
        public static IOrderRepository OrderRepository { get; private set; }

        public static void InitializeRepositories()
        {
            CustomerRepository = new CustomerRepository();
            OrderRepository = new OrderRepository();
        }
    }
}
