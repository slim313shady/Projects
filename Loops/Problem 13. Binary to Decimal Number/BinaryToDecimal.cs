using System;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        ulong binaryValue = 1;
        ulong result = 0;
        string StringToConvert = Console.ReadLine();

        foreach (char CharToConvert in StringToConvert)
        {
            if (CharToConvert.ToString() != "0" && CharToConvert.ToString() != "1")
            {
                Console.WriteLine("A binary digit can only be a 1 or a 0!");

                return;
            }

            result += ulong.Parse(CharToConvert.ToString()) * binaryValue;

            binaryValue *= 2;
        }
        Console.WriteLine(result);

    }
}

