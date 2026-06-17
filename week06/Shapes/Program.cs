using System;
using System.Formats.Asn1;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape>();
        Square one = new Square(5.0, "red");
        Rectangle two = new Rectangle(3.0, 6.0, "blue");
        Circle three = new Circle(2.0, "green");
        shapes.Add(one);
        shapes.Add(two);
        shapes.Add(three);

        foreach (Shape item in shapes)
        {
            Console.WriteLine($"The shape has an area of {item.GetArea()} and is the color {item.GetColor()}");
        }
    }
}