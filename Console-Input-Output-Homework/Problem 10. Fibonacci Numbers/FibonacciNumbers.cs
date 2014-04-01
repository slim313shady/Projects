using System;

class FibonacciNumbers
{
    public static int Fibonacci(int number)
    {

        if (number <= 1)
        {

            return 1;
        }
        else
        {

            return Fibonacci(number - 2) + Fibonacci(number - 1);
        }

    }
    static void Main(string[] args)
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if ( number == 1)
        {
            Console.WriteLine("0");
        }
        else if (number == 2)
        {
            Console.WriteLine("0 1");
        } 
        else
        {
            Console.Write("0 1 1 ");

            for (int i = 2; i < number - 1; i++)
            {

                Console.Write(" {0}", Fibonacci(i));
            }
        }



    }
}

