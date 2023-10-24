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
    internal class CustomerRepository :ICustomerRepository
    {
        public CustomerRepository() { }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            DataTable customersTable = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(Globals.SalesProcessDBConnStr))
                {
                    conn.Open();
                    string sql = "SELECT * FROM [Customers]";

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        customersTable.Load(reader);
                    }
                }

                foreach (DataRow row in customersTable.Rows)
                {
                    customers.Add(
                        new Customer(
                           Convert.ToInt32(row["Id"]),
                           Convert.ToString(row["FirstName"]),
                           Convert.ToString(row["LastName"]),
                           Convert.ToString(row["Address"]),
                           Convert.ToString(row["City"]),
                           Convert.ToString(row["State"]),
                           Convert.ToInt32(row["ZipCode"])
                        ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in retrieving customer records: " + ex.Message);
            }

            return customers;
        }

        public bool AddNewCustomer(Customer newCustomer)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Globals.SalesProcessDBConnStr))
                {
                    conn.Open();

                    string sql = "INSERT INTO [Customers] ([FirstName], [LastName], [Address], [City], [State], [ZipCode]) " +
                        "VALUES (@firstName, @lastName, @address, @city, @state, @zipCode)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Create and set the parameters values 
                        cmd.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = newCustomer.FirstName;
                        cmd.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = newCustomer.LastName;
                        cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = newCustomer.Address;
                        cmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = newCustomer.City;
                        cmd.Parameters.Add("@state", SqlDbType.NVarChar).Value = newCustomer.State;
                        cmd.Parameters.Add("@zipCode", SqlDbType.Int).Value = newCustomer.ZipCode;

                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded <= 0) throw new Exception("No row was added");
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

        public bool UpdateCustomerInfo(Customer updatedCustomer)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Globals.SalesProcessDBConnStr))
                {
                    conn.Open();

                    string sql = "UPDATE [Customers] SET [FirstName] =  @firstName, [LastName] = @lastName, " +
                        "[Address] = @address, [City] = @city, [State] = @state, [ZipCode] = @zipCode " +
                        "WHERE [Id] = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Create and set the parameters values 
                        cmd.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = updatedCustomer.FirstName;
                        cmd.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = updatedCustomer.LastName;
                        cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = updatedCustomer.Address;
                        cmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = updatedCustomer.City;
                        cmd.Parameters.Add("@state", SqlDbType.NVarChar).Value = updatedCustomer.State;
                        cmd.Parameters.Add("@zipCode", SqlDbType.Int).Value = updatedCustomer.ZipCode;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = updatedCustomer.Id;

                        int rowsUpdated = cmd.ExecuteNonQuery();
                        if (rowsUpdated <= 0) throw new Exception("No row was updated");
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
        
        public bool DeleteCustomer(int customerId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Globals.SalesProcessDBConnStr))
                {
                    conn.Open();

                    string sql = "DELETE FROM [Customers] WHERE [Id] = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Create and set the parameters values 
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = customerId;

                        int rowsUpdated = cmd.ExecuteNonQuery();
                        if (rowsUpdated <= 0) throw new Exception("No row was deleted");
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
    }
}
