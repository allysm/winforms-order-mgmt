using Microsoft.Data.SqlClient;
using OrderMgmtLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMgmtLibrary.DataAccess.Implementation
{
    internal class OrderRepository : IOrderRepository
    {
        public bool CreateNewOrder(Order newOrder)
        {
            try
            {
                int addedOrderId;

                using (SqlConnection conn = new SqlConnection(Globals.SalesProcessDBConnStr))
                {
                    conn.Open();

                    // Add to Orders table
                    string sql = "INSERT INTO [Orders] ([OrderName], [CustomerId], [ShipDate]) " +
                        "VALUES (@orderName, @customerId, @shipDate) " +
                        "SELECT SCOPE_IDENTITY()";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Create and set the parameters values 
                        cmd.Parameters.Add("@orderName", SqlDbType.NVarChar).Value = newOrder.OrderName;
                        cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = newOrder.CustomerId;
                        cmd.Parameters.Add("@shipDate", SqlDbType.Date).Value = newOrder.ShipDate;

                        object ret = cmd.ExecuteScalar();
                        if (ret == null) throw new Exception("No row was added");

                        addedOrderId = Convert.ToInt32(ret);
                    }

                    // Add to OrderDetails table
                    sql = "INSERT INTO [OrderDetails] ([OrderId], [ItemNumber], [Qty], [Total]) " +
                        "VALUES (@orderId, @itemNumber, @qty, @total)";

                    foreach (OrderDetails detail in newOrder.OrderDetails)
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            // Create and set the parameters values 
                            cmd.Parameters.Add("@orderId", SqlDbType.Int).Value = addedOrderId;
                            cmd.Parameters.Add("@itemNumber", SqlDbType.NVarChar).Value = detail.Item.Number;
                            cmd.Parameters.Add("@qty", SqlDbType.Decimal).Value = detail.Quantity;
                            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = detail.Total;

                            int rowsAdded = cmd.ExecuteNonQuery();
                            if (rowsAdded <= 0) throw new Exception("No row was added");
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in the database call: " + ex.Message);
                return false;
            }
        }

        public List<Item> GetAllItems()
        {
            List<Item> items = new List<Item>();
            DataTable itemsTable = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(Globals.SalesProcessDBConnStr))
                {
                    conn.Open();
                    string sql = "SELECT * FROM [Items]";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (IDataReader reader = cmd.ExecuteReader())
                        {
                            itemsTable.Load(reader);
                        }

                    }
                }

                foreach (DataRow row in itemsTable.Rows)
                {
                    items.Add(
                        new Item(
                           Convert.ToString(row["ItemNumber"]),
                           Convert.ToString(row["ItemName"]),
                           Convert.ToDouble(row["ItemPrice"])
                        ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in retrieving order records: " + ex.Message);
            }

            return items;
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            DataTable ordersTable = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(Globals.SalesProcessDBConnStr))
                {
                    conn.Open();
                    string sql = "SELECT * FROM [Orders] " +
                        "INNER JOIN [Customers] ON [Orders].CustomerId = [Customers].Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (IDataReader reader = cmd.ExecuteReader())
                        {
                            ordersTable.Load(reader);
                        }

                    }
                }

                foreach (DataRow row in ordersTable.Rows)
                {
                    orders.Add(
                        new Order(
                           Convert.ToInt32(row["Id"]),
                           Convert.ToString(row["OrderName"]),
                           Convert.ToInt32(row["CustomerId"]),
                           Convert.ToString(row["FirstName"]) + " " + Convert.ToString(row["LastName"]),
                           Convert.ToDateTime(row["ShipDate"]),
                           GetOrderDetails(Convert.ToInt32(row["Id"]))
                        ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in retrieving order records: " + ex.Message);
            }

            return orders;
        }

        public List<Order> GetCustomerOrders(Customer customer)
        {
            List<Order> orders = new List<Order>();
            DataTable ordersTable = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(Globals.SalesProcessDBConnStr))
                {
                    conn.Open();
                    string sql = "SELECT * FROM [Orders] WHERE [CustomerId] = @customerId";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Create and set the parameters values 
                        cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customer.Id;

                        using (IDataReader reader = cmd.ExecuteReader())
                        {
                            ordersTable.Load(reader);
                        }

                    }
                }

                foreach (DataRow row in ordersTable.Rows)
                {
                    orders.Add(
                        new Order(
                           Convert.ToInt32(row["Id"]),
                           Convert.ToString(row["OrderName"]),
                           customer,
                           Convert.ToDateTime(row["ShipDate"]),
                           GetOrderDetails(Convert.ToInt32(row["Id"]))
                        ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in retrieving order records: " + ex.Message);
            }

            return orders;
        }

        private List<OrderDetails> GetOrderDetails(int orderId)
        {
            List<OrderDetails> details = new List<OrderDetails>();
            DataTable orderDetailsTable = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(Globals.SalesProcessDBConnStr))
                {
                    conn.Open();
                    string sql = "SELECT * FROM [OrderDetails] " +
                        "INNER JOIN [Items] ON [Items].ItemNumber = [OrderDetails].ItemNumber " +
                        "WHERE [OrderId] = @orderId";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Create and set the parameters values 
                        cmd.Parameters.Add("@orderId", SqlDbType.Int).Value = orderId;

                        using (IDataReader reader = cmd.ExecuteReader())
                        {
                            orderDetailsTable.Load(reader);
                        }

                    }
                }

                foreach (DataRow row in orderDetailsTable.Rows)
                {
                    string itemName = Convert.ToString(row["ItemName"]);
                    string itemNumber = Convert.ToString(row["ItemNumber"]);
                    double itemPrice = Convert.ToDouble(row["ItemPrice"]);

                    details.Add(
                        new OrderDetails(
                           new Item(itemNumber, itemName, itemPrice),
                           Convert.ToDouble(row["Qty"])
                        ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in retrieving order records: " + ex.Message);
            }

            return details;
        }
    }
}
