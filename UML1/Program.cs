    using System;
using System.Net.NetworkInformation;
using UML1;


    Console.WriteLine("Hello and welcome to our pizzaria!");
    Console.WriteLine("Here is our menu at the moment ;)");

    PizzaList pizzaMenu = new PizzaList();
    Pizza Pizza1 = new Pizza(1, "Pepperoni Pizza", 50, "En lækker pizza med krydret pepperoni og ost");
    Pizza Pizza2 = new Pizza(2, "Margherita Pizza", 50, "En klassisk pizza med tomat, mozzarella og basilikum");
    Pizza Pizza3 = new Pizza(3, "BBQ Chicken Pizza", 50, "En velsmagende pizza med saftigt barbecuemarineret kylling, løg og BBQ-sauce");


    pizzaMenu.AddPizza(Pizza1);
    pizzaMenu.AddPizza(Pizza2);
    pizzaMenu.AddPizza(Pizza3);

foreach (var i in pizzaMenu.GetAllPizzas().Values)
{
    Console.WriteLine(i);
}
Console.WriteLine("Press Enter");

Console.ReadLine();
Console.WriteLine("As You can see we dont have that many pizza yet");
Console.WriteLine("But we got 3 customers");

CustomerList customerList1 = new CustomerList();

Customer customer1 = new Customer(1, "John Doe", "25245663");
Customer customer2 = new Customer(2, "Smitty", "98654872");
Customer customer3 = new Customer(3, "Jason", "29756623");

customerList1.AddCustomer(customer1);
customerList1.AddCustomer(customer2);
customerList1.AddCustomer(customer3);

foreach (var i in customerList1.GetAllCustomers())
{
    Console.WriteLine(i);
}
Console.WriteLine("Press Enter");

Console.ReadLine();

Console.WriteLine("With 3 customers we need 3 orders");
Console.WriteLine("here they come, the 3 customers has choosen 3 pizza they want");


Order order1 = new Order(customer3, Pizza1);
Order order2 = new Order(customer2, Pizza3);
Order order3 = new Order(customer1, Pizza2);

Console.WriteLine(order1);
Console.WriteLine(order2);
Console.WriteLine(order3);

Console.WriteLine("Press Enter For the total price");

Console.ReadLine();
Console.WriteLine($"The Total price for the orders is {pizzaMenu.CalculateTotalPrice() * 1.25 + 40 }");


Console.WriteLine("Customer 1 har skrevet sit navn forkert og vil gerne ændre fra John Doe til John Yes i stedet...");
customerList1.EditCustomer(1, "John Yes", "25245663");
Console.WriteLine($"Som vi kan se her så har vi ændret hans navn {customer1.Name}");

Console.WriteLine("Det ser ud som en af pizzaernes pris er forkert, lad os rette det også");
Pizza1.Pris = 60;

Console.WriteLine("press Enter");
Console.ReadLine();

Console.WriteLine("Lets find a Customer using a name!!");

foreach ( var i in customerList1.GetFromName("John Yes"))
{
    Console.WriteLine(i);
}

Console.WriteLine("WE can also find a Pizza details just by using the nummer");

Console.WriteLine(pizzaMenu.GetPizza(1));

Console.WriteLine("Det var alt jeg havde, omkring mit system og så har jeg vist nogle af de funktioner systemet har ;)");