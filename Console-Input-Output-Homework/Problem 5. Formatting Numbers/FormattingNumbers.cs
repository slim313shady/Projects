using System;

class FormattingNumbers
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());

        if (a < 0 && a > 500)
        {
            Console.WriteLine("Integer 'a' need to be in interval 0-500");
        }
        
        Console.Write("b=");
        float b = float.Parse(Console.ReadLine());
        Console.Write("c=");
        float c = float.Parse(Console.ReadLine());

        string hexValueA = a.ToString("X"); // convert integer to hexadecimal format
        string binValueA = Convert.ToString(a, 2); // convert integer to binary format


        Console.Write("|{0,-10}", hexValueA);
        Console.Write("|{0,0}|", binValueA.PadLeft(10,'0'));
        Console.Write("{0,10:F2}|", b);
        Console.WriteLine("{0,-10:F3}|", c);                    
    } 
}

