using System;

class PrintDeck
{
    static void Main()
    {
        char a = '♠';
        char b = '♥';
        char c = '♦';
        char d = '♣';

        for (int row = 2; row <= 14; row++)
        {
            for (int column = 1; column <= 4; column++)
            {
                if (row >= 2 && row <= 10)  // we miss 9 more cases
                {
                    Console.Write("{0}", row);
                }

                switch (row)
                {
                    case 11: Console.Write("J");
                        break;
                    case 12: Console.Write("Q");
                        break;
                    case 13: Console.Write("K");
                        break;
                    case 14: Console.Write("A");
                        break;
                }

                switch (column)
                {
                    case 1: Console.Write(d + " ");
                        break;
                    case 2: Console.Write(c + " ");
                        break;
                    case 3: Console.Write(b + " ");
                        break;
                    case 4: Console.Write(a + " ");
                        break;
                }

            }
            Console.WriteLine();
        }

    }
}

