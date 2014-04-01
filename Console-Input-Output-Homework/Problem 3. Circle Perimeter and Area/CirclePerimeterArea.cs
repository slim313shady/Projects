using System;

class CirclePerimeterArea
{
    static void Main(string[] args)
    {
        Console.Write("r = ");
        double r = double.Parse(Console.ReadLine());

        Console.WriteLine("S(0,R = {0}) = {1:F2}", r, Math.PI * r * r);
        Console.WriteLine("P(0,R = {0}) = {1:F2}", r, 2 * Math.PI * r);
    }
}

