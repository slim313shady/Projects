using System;

class MatrixNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (1 <= n && n < 20)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {

                    Console.Write(i + j - 1 + " ");

                }
                Console.WriteLine();
            }

        }
        else
        {
            Console.WriteLine("n is out of range");
        }
    }
}

