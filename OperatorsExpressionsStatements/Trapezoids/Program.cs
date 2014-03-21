using System;

class Trapezoids
{
    static void Main(string[] args)
    {
        Console.WriteLine("a = ");
        double aBase = double.Parse(Console.ReadLine());

        Console.WriteLine("b = ");
        double bBase = double.Parse(Console.ReadLine());

        Console.WriteLine("h = ");
        double height = double.Parse(Console.ReadLine());

        double trapezoidArea = ((aBase + bBase) / 2) * height;

        Console.WriteLine("S = {0}", trapezoidArea);
    }
}

