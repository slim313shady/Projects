using System;

class Rectangles
{
    static void Main(string[] args)
    {
        Console.Write("Width = ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height = ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Area = {0};\nPerimeter = {1};", (width * height),(2*width + 2*height));
    }
}

