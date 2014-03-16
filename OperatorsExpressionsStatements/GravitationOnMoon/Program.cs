using System;



class GravitationOnMoon
{
    static void Main(string[] args)
    {
        Console.Write("Weight = ");
        double n = double.Parse(Console.ReadLine());
        double result = (17 * n) / 100;
        Console.WriteLine("weight on the Moon = {0}", result);
    }
}

