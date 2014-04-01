using System;

class BonusScore
{
    static void Main(string[] args)
    {
        Console.Write("Enter number [1-9]: ");
        int a = int.Parse(Console.ReadLine());
        int result = 0;

        if (a >= 1 && a <= 3)
        {
            result = a * 10;
        }
        else if (a >= 4 && a <= 6)
        {
            result = a * 100;
        }
        else if (a >= 7 && a <= 9)
        {
            result = a * 1000;
        }
        else
        {
            Console.WriteLine("invalid score");
        }
        
        if (result != 0)
        {
            Console.WriteLine("result: {0}", result);
        }
        
    }
}

