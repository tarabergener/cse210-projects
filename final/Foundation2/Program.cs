using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product();
        p1.SetProdcutName("Procore Protien Drink");
        p1.SetProductId("265248201584");
        p1.SetPrice(3);
        p1.SetQuantity(5);

        Product p2 = new Product();
        p2.SetProdcutName("Lip Plumper");
        p2.SetProductId("265248202658");
        p2.SetPrice(10);
        p2.SetQuantity(2);

        Product p3 = new Product();
        p3.SetProdcutName("Seat Cusion");
        p3.SetProductId("265248204789");
        p3.SetPrice(25);
        p3.SetQuantity(6);

        Product p4 = new Product();
        p4.SetProdcutName("Floral Maxi Dress");
        p4.SetProductId("265248202593");
        p4.SetPrice(20);
        p4.SetQuantity(1);

        Product p5 = new Product();
        p5.SetProdcutName("Dell Gaming Laptop");
        p5.SetProductId("265248208585");
        p5.SetPrice(800);
        p5.SetQuantity(1);

        Product p6 = new Product();
        p6.SetProdcutName("Bronzer for Ivory Skin");
        p6.SetProductId("265248209249");
        p6.SetPrice(18);
        p6.SetQuantity(3);

        Address a1 = new Address();
        a1.SetStreetAddress("5569 Celtic Circle");
        a1.SetCity("Minneapolis");
        a1.SetState("MN");
        a1.SetCountry("United States");

        Address a2 = new Address();
        a2.SetStreetAddress("2 Valenzuela Calle");
        a2.SetCity("Ignacia");
        a2.SetState("Pollo");
        a2.SetCountry("Brazil");

        Customer c1 = new Customer();
        c1.SetCustomer("Ralph Johnson");

        Customer c2 = new Customer();
        c2.SetCustomer("Jose Gurerra");

        Order o1 = new Order();
        o1._products.Add(p1);
        o1._products.Add(p2);
        o1._products.Add(p3);

        Console.WriteLine("Order 1 Packing Label");
        o1.DisplayPackingLabel();
        Console.WriteLine("");
        Console.WriteLine("Order 1 Shipping Label");
        Console.WriteLine(c1.GetCustomer());
        a1.FullAddress();
        Console.WriteLine("");
        Console.WriteLine("Order 1 Invoice Total");
        //o1.CalculateCost();
        Console.WriteLine("");

        Order o2 = new Order();
        o2._products.Add(p4);
        o2._products.Add(p5);
        o2._products.Add(p6);

        Console.WriteLine("Order 2 Packing Label");
        o2.DisplayPackingLabel();
        Console.WriteLine("");
        Console.WriteLine("Order 2 Shipping Label");
        Console.WriteLine(c2.GetCustomer());
        a2.FullAddress();
        Console.WriteLine("");
        Console.WriteLine("Order 2 Invoice Total");
        //o2.CalculateCost();
        Console.WriteLine("");
    }
}