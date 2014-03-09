using System;

    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            Console.Write("First 1000 members of the sequence: ");
            int a = 2;
            Console.Write("{0}, ",a);
            int b = -3;
            Console.Write("{0}, ", b);
            
            for ( int i = 0; i < 1000; i++ )
            {
                Console.Write("{0}, {1}, ", a += 2, b -= 2);
            }
        }
    }

