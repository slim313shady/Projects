using System;

class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers.");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = a;

        if (a > b)
        {
            a = b;
            b = c;
        }

        Console.WriteLine("Result {0} {1}", a, b);

    }
}

