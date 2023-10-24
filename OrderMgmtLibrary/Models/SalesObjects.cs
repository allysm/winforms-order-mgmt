using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMgmtLibrary.Models
{
    public record Customer(int Id, string FirstName, string LastName, string Address, string City, string State, int ZipCode);

    public class Item
    {
        public Item(string ItemNumber, string ItemName, double ItemPrice)
        {
            this.Number = ItemNumber;
            this.Name = ItemName;
            this.Price = ItemPrice;
        }

        public string Number { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }
    }

    public class Order
    {
        public Order(int Id, string OrderName, Customer Customer, DateTime ShipDate, List<OrderDetails> OrderDetails)
        {
            this.Id = Id;
            this.OrderName = OrderName;
            this.CustomerId = Customer.Id;
            this.CustomerFullName = Customer.FirstName + " " + Customer.LastName;
            this.ShipDate = ShipDate;
            this.OrderDetails = OrderDetails;
        }

        public Order(int Id, string OrderName, int CustomerId, string CustomerFullName, DateTime ShipDate, List<OrderDetails> OrderDetails)
        {
            this.Id = Id;
            this.OrderName = OrderName;
            this.CustomerId = CustomerId;
            this.CustomerFullName = CustomerFullName;
            this.ShipDate = ShipDate;
            this.OrderDetails = OrderDetails;
        }

        public int Id { get; private set; }
        public string OrderName { get; private set; }
        public int CustomerId { get; private set; }
        public string CustomerFullName { get; private set; }
        public DateTime ShipDate { get; private set; }
        public List<OrderDetails> OrderDetails { get; private set; }
    }


    public class OrderDetails
    {
        public OrderDetails(Item Item, double Qty)
        {
            this.Item = Item;
            this.Quantity = Qty;
        }
        
        // Item fields for data grid view column population
        public string ItemNumber { get { return this.Item.Number; } }
        public string ItemName { get { return this.Item.Name; } }
        public double ItemPrice { get { return this.Item.Price; } }
        //==================================================

        public double Quantity {  get; set; }
        public Item Item {  get; private set; }

        public double Total 
        { 
            get
            {
                return Item.Price * Quantity;
            }
        }

    }
}
