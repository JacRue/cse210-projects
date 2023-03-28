using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create products
            Product product1 = new Product("Product 1", "P0001", 10.0m, 2);
            Product product2 = new Product("Product 2", "P0002", 15.0m, 1);
            Product product3 = new Product("Product 3", "P0003", 5.0m, 3);

            // Create addresses
            Address address1 = new Address("123 Main St", "Anytown", "TX", "USA");
            Address address2 = new Address("456 Maple Ave", "Somewhere", "ON", "Canada");

            // Create customers
            Customer customer1 = new Customer("John Smith", address1);
            Customer customer2 = new Customer("Jane Doe", address2);

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            // Display packing label, shipping label, and total cost for order 1
            Console.WriteLine("Order 1:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine("Total cost: $" + order1.GetTotalCost());

            // Display packing label, shipping label, and total cost for order 2
            Console.WriteLine("Order 2:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine("Total cost: $" + order2.GetTotalCost());
        }
    }
}