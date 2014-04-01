using System;

class BiggestOf3Numbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers.");

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double maxAB = Math.Max(a, b);

        if (maxAB < c)
        {
            Console.WriteLine("Max number is {0} ",c);
        }
        else
        {
            Console.WriteLine("Max number is {0} ", maxAB);
        }

    }
}

