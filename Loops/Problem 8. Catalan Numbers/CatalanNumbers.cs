using System;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double c = 1; // Very important, because we loose digits with some devision which are not integers
 
        if (0 <= n && n < 100)
        {
            for (int k = 2; k <= n; k++)
            {
                c *= (double)(n + k) / (double)k;
            }
            Console.WriteLine(c);
        }
        else
        {
            Console.WriteLine("n is out of range");
        }
    }
}

