using System;

class NumberComparer
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        double c = Math.Max(a,b);
        Console.WriteLine("The greater number is {0:F1}",c);
    }
}

