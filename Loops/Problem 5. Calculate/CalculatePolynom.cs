using System;

class CalculatePolynom
{
    static void Main()
    {
        //Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double sum = 1.0;
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += (factorial) / Math.Pow(x, i);
        }
        Console.WriteLine("sum = {0:F5}", sum);
    }
}

