using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ONLINE ORDERING SYSTEM");
        Console.WriteLine("======================\n");

        // Create addresses
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Address address2 = new Address("456 Oak Ave", "Toronto", "Ontario", "Canada");
        Address address3 = new Address("789 Pine Rd", "Los Angeles", "CA", "USA");

        // Create customers
        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Marie Dubois", address2);
        Customer customer3 = new Customer("Robert Johnson", address3);

        // Create products
        Product product1 = new Product("LAP001", "Laptop", 899.99, 1);
        Product product2 = new Product("MOU002", "Wireless Mouse", 24.99, 2);
        Product product3 = new Product("KEY003", "Mechanical Keyboard", 79.99, 1);
        Product product4 = new Product("MON004", "27-inch Monitor", 249.99, 1);
        Product product5 = new Product("HEA005", "Gaming Headset", 59.99, 1);
        Product product6 = new Product("WEB006", "Webcam", 45.50, 1);

        // Create orders and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product2);

        Order order3 = new Order(customer3);
        order3.AddProduct(product6);
        order3.AddProduct(product3);
        order3.AddProduct(product1);

        // Display order details
        List<Order> orders = new List<Order> { order1, order2, order3 };

        foreach (Order order in orders)
        {
            order.DisplayOrderDetails();
        }
    }
}