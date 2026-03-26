using System;

class Program
{
    static void Main(string[] args)
    {
        Address addrS1 = new Address("67 Rot Street", "Ohio", "OH", "USA");
        Customer cusT1 = new Customer("Jane Doe", addrS1);

        Order ordR1 = new Order(cusT1);
        ordR1.AddProduct(new Product("Computer RAM", "P200", 500, 1));
        ordR1.AddProduct(new Product("Nvidia RTX 4090", "P350", 1599, 2));

        Address addrS2 = new Address("147 Mabini St", "Manila", "MNL", "Philippines");
        Customer cusT2 = new Customer("Boggart Mandaluyong", addrS2);
        
        Order ordR2 = new Order(cusT2);
        ordR2.AddProduct(new Product("Headphone", "P150", 8, 1));
        ordR2.AddProduct(new Product("Keyboard", "P152", 24, 2));

        DisplayOrder(ordR1);
        Console.WriteLine("------------------");
        DisplayOrder(ordR2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("Packing Label:" );
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order.GetTotalCost()}");
    }
}