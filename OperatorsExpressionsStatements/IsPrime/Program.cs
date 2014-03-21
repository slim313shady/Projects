using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(isPrime(n));
    }

    public static Boolean isPrime(int number)
    {
        if (number <= 0) return false;
        if (number == 1) return false;
        if (number == 2) return true;

        for (int i = 3; i < number; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;

    }
}

