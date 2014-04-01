using System;

class NumbersDividableGivenNumber
{
    static void Main(string[] args)
    {
        Console.Write("a=");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b=");
        int b = int.Parse(Console.ReadLine());

        int c = 0;
        int d = 0;

        if (a > b ) 
        {
            c = b;
            d = a;
        }
        else if ( a < b ) 
        {
             c = a;
             d = b;
        }
        else
        {
            c = a;
            d = b;
        }

        int count = 0;
        Console.Write("Numbers: ");

        for (int i = c; i >= c && i <= d; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write("{0} ", i);
                count++;
            }
        }
        Console.WriteLine("From {0} - {1}: {2} numbers can be % 5 without reminder", c, d, count);
    }
}

