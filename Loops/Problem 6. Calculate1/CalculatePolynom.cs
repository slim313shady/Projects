using System;

class CalculatePolynom
{
    // Calculate N! / K! (1 < k < n < 100)
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        if (1 < k && k < n && n < 100)
        {
            ulong result = 1;
            for (int i = k + 1; i <= n; i++)
            {
                result *= (ulong)i;
            }
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}

