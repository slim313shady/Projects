using System;

class PointInCircle
{
    static void Main(string[] args)
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());

        bool result = (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= 2 * 2;

        Console.Write(result);


    }
}

