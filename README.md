# Order Management

*Getting Started*
- Startup project is OrderMgmtUI. Please run this project to start the application.

*Application Description*

The solution is divided into two parts: OrderMgmtUI and OrderMgmtLibrary. OrderMgmtUI holds all the forms and UI logic. OrderMgmtLibrary is responsible for communicating with the database and storing the connections. 

There are two forms that a user can open: `CustomerGridForm` and `CustomerOrderListForm`.

- `CustomerGridForm` 
    - This form lists all the customers and allows the users to add, edit, and delete customers. 
    - This form has a button that says "View Customer Orders" which will open the `CustomerOrderListForm`. 
    - Adding and editing customers will open up `CustomerForm` that will either add or edit customers depending if it's in edit or add mode.
    - The add and edit customer form requires the user to input all fields and fill in a valid zipcode.

- `CustomerOrderListForm`
    - This form lists all and each customer orders. 
    - "Select All" option in the dropdown will list all orders, while selecting a specific customer in the dropdown will list all that customer's orders. 
    - Once a user selects an orders, it will display the Order Details at the right side. 
    - If a customer is selected, there is a button that says "Add New Order" which opens the Add New Order form, `AddNewOrderForm`. 
        - The add new order form has a grid which allows the user to select an item in the dropdown. Then, item total price and order total price is automatically updated and calculated. 
        - The add new order form requires the user to fill in an order name and ship date. Also, total quantity of items should be at least 1 and no multiple item entries are allowed. Otherwise, the order is not created for the customer.


*Data Assumptions*
- All customer, order, and item fields are not nullable. 
- `OrderDetails` maps an `Order` and `Item` together. This means that `OrderDetails` will include how many of that item is in the order and what is the total price of that item in the order (calculated as quantity of item * its unit price).
- `OrderDetails` cannot have multiple item entries of the same item for an orders. In other words, `ItemNumber` and `OrderId` are considered a primary key pair.
