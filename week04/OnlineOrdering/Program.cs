using System;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product("Eldors Mixture", 3467, 13.99f, 2);
        Product product1 = new Product("Electric Fan", 10100, 50.99f, 1);
        Address address = new Address("Nigeria", "Abeokuta", "Ogun state", "Obada");
        Customer customer = new Customer("Olumide Ogunyemi", address);
        Order order = new Order(customer);
        order.AddOrders(product);
        order.AddOrders(product1);
        order.DisplayShippingLabel();
        order.DisplayLabel();

        Product product2 = new Product("Eldors Bitter", 3347, 33.99f, 2);
        Product product3 = new Product("Dynabook", 50089, 100.99f, 1);
        Address address2 = new Address("Nigeria", "Abeokuta", "Ogun state", "Obada");
        Customer customer2 = new Customer("Raphael Ogunyemi", address2);
        Order order2 = new Order(customer2);
        order2.AddOrders(product2);
        order2.AddOrders(product3);
        order2.DisplayShippingLabel();
        order2.DisplayLabel();
    }
}