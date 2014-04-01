using System;

class CalculateCombination
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        double nFactorial = 1;
        double kFactorial = 1;
        double differenceFactorial = 1;
        double result = 0;

        if (1 < k && k < n && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
                    
                if (i <= k)
                {
                    kFactorial *= i;
                }
            }
            for (int i = 1; i <= n - k; i++)
            {
                differenceFactorial *= i;
            }

            result = nFactorial / (kFactorial * differenceFactorial);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}

