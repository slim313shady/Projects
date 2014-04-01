using System;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        
        ulong result = 0;
        string StringToConvert = Console.ReadLine();
        ulong binaryValue = (ulong)StringToConvert.Length - 1;
        
        foreach (char CharToConvert in StringToConvert)
        {
            if (CharToConvert.ToString() != "0" && CharToConvert.ToString() != "1")
            {
                Console.WriteLine("A binary digit can only be a 1 or a 0!");

                return;
            }

            result += ulong.Parse(CharToConvert.ToString()) * (ulong)Math.Pow(2, binaryValue);
            binaryValue--;
            
        }
        Console.WriteLine(result);

    }
}

