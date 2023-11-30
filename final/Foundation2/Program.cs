using System;

class Program
{
    static void Main(string[] args)
    {
        // create new addresses
        Address address1 = new("495 Grove Street", "New York", "New York", "USA");
        Address address2 = new("650 Hipolito Yrigoyen", "Lomas de Zamora", "Buenos Aires", "Argentina");

        // create customers
        Customer customer1 = new("John Frunciante", address1);
        Customer customer2 = new("Lionel Messi", address2);

        // create products and add them to an order
        Product product1 = new(1001, "Sport Watch", 15.88m, 1);
        Product product2 = new(1034, "Professional Guitar", 2799.95m, 1);
        Product product3 = new(1007, "Bluetooth Selfie Stick",  7.50m, 2);

        Product product4 = new(1008, "Professional Soccer Football", 159.99m, 3);
        Product product5 = new(1010, "Mate Set", 21.30m, 1);

        Order order1 = new(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // display label and total price 
        Console.WriteLine($"{order1.RenderPackingLabel()}\nTOTAL: ${order1.CalculateTotal()} (shipping included)\n{order1.RenderShippingText()}");
        Console.WriteLine($"{order2.RenderPackingLabel()}\nTOTAL: ${order2.CalculateTotal()} (shipping included)\n{order2.RenderShippingText()}");
    }
}