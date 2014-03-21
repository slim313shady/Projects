using System;

class FourDigitNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("n = ");
        int n = int.Parse(Console.ReadLine());
        int digit4 = (n % 10); // 4 digit
        int digit3 = (n / 10) % 10; // 3 digit
        int digit2 = (n / 100) % 10; // 2 digit
        int digit1 = (n / 1000); // 1 digit
        int sumDigit = digit1 + digit2 + digit3 + digit4;
        int reverseDigit = 1000 * digit4 + 100 * digit3 + 10 * digit2 + digit1;
        int reverseDigit1 = 1000 * digit4 + 100 * digit1 + 10 * digit2 + digit3;
        int reverseDigit2 = 1000 * digit1 + 100 * digit3 + 10 * digit2 + digit4;
        Console.WriteLine("Sum = {0}", sumDigit);
        Console.WriteLine("reverseDigit = {0}", reverseDigit);
        Console.WriteLine("reverseDigit1 = {0}", reverseDigit1);
        Console.WriteLine("reverseDigit2 = {0}", reverseDigit2);

        // For test 
        //int reversednumber = 0;
        //int couunt = 0;
        //while (n > 0)
        //{
        //    reversednumber = reversednumber * 10 + n % 10;
        //    n /= 10;

        //}

        //int couunt = 0;
        //while (n/(int)Math.Pow(10, couunt) > 0 )
        //{
        //    couunt++;
        //}

        //Console.WriteLine("reversed number = {0}", (n % 10) * (int)Math.Pow(10, couunt - 1) + n / 10);

    }
}


