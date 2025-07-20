using System;

class Program
{
    static void Main(string[] args)
    {
        ///Customer 1
        Address address1 = new Address("11543 Shorpentine dr", "Florp Towm", "TX", "USA");
        Customer customer1 = new Customer("Billiam Hilliam", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("ground beef", 2534, 1.56, 6);
        order1.addProduct(product1);
        Product product2 = new Product("red bull", 1823, 2.0, 15);
        order1.addProduct(product2);
        Product product3 = new Product("laundry detergent", 2780, 5.34, 1);
        order1.addProduct(product3);
        Console.WriteLine($"Total: ${order1.calculateTotalCost()}");
        order1.packingLabel();
        Console.WriteLine(order1.shippingLabel());
        ///Customer 2
        Console.WriteLine("---");
        Address address2 = new Address("78234 Smellbert St", "Desert Dunes", "AA", "CAN");
        Customer customer2 = new Customer("Bort", address2);
        Order order2 = new Order(customer2);
        Product product4 = new Product("goldfish (crackers)", 0001, 2.45, 5);
        order2.addProduct(product4);
        Product product5 = new Product("goldfish (real)", 0002, .25, 6);
        order2.addProduct(product5);
        Console.WriteLine($"Total: ${order2.calculateTotalCost()}");
        order2.packingLabel();
        Console.WriteLine(order2.shippingLabel());
    }
}