using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Product beans = new Product("Beans", 1, 1.2, 4);
        Product laptop = new Product("Laptop", 2, 270.56);
        Product cheese = new Product("Cheese", 3, 2.50, 2);
        Product lettuce = new Product("Lettuce", 4, 1.25, 5);
        Address debraHome = new Address("123 W Bonnie Way", "Hell", "Alaska", "USA");
        Customer debra = new Customer("Debra", debraHome);
        Order debraOrder = new Order(debra);
        Address thomasHome = new Address("AHH Cliff St", "Milan", "Something", "ITL");
        Customer thomas = new Customer("Thomas", thomasHome);
        Order thomasOrder = new Order(thomas);
        debraOrder.AddProduct(beans);
        debraOrder.AddProduct(lettuce);
        Console.WriteLine($"Products:\n{debraOrder.GetPackingLabel()}\nAddress:\n{debraOrder.GetShippingLabel()}\nTotal Cost:{debraOrder.GetTotalCost()}\n");
        thomasOrder.AddProduct(cheese);
        thomasOrder.AddProduct(laptop);
        Console.WriteLine($"Products:\n{thomasOrder.GetPackingLabel()}\nAddress:\n{thomasOrder.GetShippingLabel()}\nTotal Cost:{thomasOrder.GetTotalCost()}\n");
    }
}