using System;



class ThirdDigit
{
    static void Main(string[] args)
    {
        Console.WriteLine("n = ");
        int n = int.Parse(Console.ReadLine());
        int result = n / 100;
        bool finalResult = (result % 10) == 7;
        Console.WriteLine("Third digit 7? {0}", finalResult);
    

    }
}

