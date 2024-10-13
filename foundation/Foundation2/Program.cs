using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 main st", "Los Angeles", "CA", "USA");
        Address address2 = new Address("562 El roble Ave", "San Antonio del Monte", "SO", "El Salvador");

        Customer customer1 = new Customer("Kenneth Anderson", address1);
        Customer customer2 = new Customer("Josue Smith", address2);

        Product product1 = new Product("Asus Zephyrus G14 RTX Laptop ", "P001", 1600, 1);
        Product product2 = new Product("Mouse Redragon Kumara", "P002", 50, 2);
        Product product3 = new Product("Samsung Oled 4K Monitor", "P003", 500, 3);

        List<Product> productsOrder1 = new List<Product> { product1, product2};
        List<Product> productsOrder2 = new List<Product> { product1, product3};

        Order order1 = new Order(productsOrder1, customer1);
        Order order2 = new Order(productsOrder2, customer2);

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order2.CalculateTotalCost()}\n");
    }
}