using System;

class OddOrEven
{
    static void Main(string[] args)
    {
        Console.WriteLine("n = ");
        int n = int.Parse(Console.ReadLine());
        bool even = (n % 2 == 0 && n > 0);
        Console.WriteLine("Odd? {0}",even);

    }
}

