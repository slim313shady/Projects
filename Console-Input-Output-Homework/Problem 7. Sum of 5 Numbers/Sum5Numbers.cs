using System;

class Sum5Numbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter five no's seperated by space: ");
        string s = Console.ReadLine();

        int a = Convert.ToInt32(s.Split(' ')[0]);
        int b = Convert.ToInt32(s.Split(' ')[1]);
        int c = Convert.ToInt32(s.Split(' ')[2]);
        int d = Convert.ToInt32(s.Split(' ')[3]);
        int e = Convert.ToInt32(s.Split(' ')[4]);

        int sum = a + b + c + d + e;

        Console.WriteLine("Sum is {0}", sum);
    }

}