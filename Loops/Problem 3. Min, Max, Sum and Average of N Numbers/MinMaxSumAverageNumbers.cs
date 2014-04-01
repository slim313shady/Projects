using System;

class MinMaxSumAverageNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double average = 0.00;
        int sum = 0;
        int minNumber = int.MaxValue;
        int maxNumber = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            sum += numbers;

            if (numbers > maxNumber)
            {
                maxNumber = numbers;
            }
            else if  (numbers < minNumber)
            {
                minNumber = numbers;
            }
            
        }
        Console.WriteLine("min = {0}", minNumber);
        Console.WriteLine("max = {0}", maxNumber);
        Console.WriteLine("avg = {0:F2}", (double)sum / n);
        Console.WriteLine("sum = {0}", sum);
    }
}

