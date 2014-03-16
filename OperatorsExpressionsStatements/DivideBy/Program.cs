using System;

class DivideBy
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        bool result = (n % 7 == 0 && n % 5 == 0);
        Console.WriteLine("Divided by 7 and 5 = {0}", result);
    }

}

