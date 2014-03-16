using System;
using System.Text;



class PrintASCIITable
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 255; i++)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Dec {0} -> Char {1}", i, (char)i);
        }fsaf
    }
}

