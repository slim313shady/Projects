using System;

class OddEvenProductEqul
{
    static void Main()
    {

        string s = Console.ReadLine();
        string[] values = s.Split(' ');
        int evenProduct = 1;
        int oddProduct = 1;

        for (int i = 0; i < values.Length; i++)
        {
            int value = int.Parse(values[i]);

            if (i % 2 == 0) // the value is even
            {
                evenProduct *= value;
            }
            else            // the value is odd
            {
                oddProduct *= value;
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("product = {0}",evenProduct);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }
    }
}
