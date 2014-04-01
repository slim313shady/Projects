using System;

class RandomNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random rand = new Random();
        
            for (int j = 0; j < n; j++)
            {
                Console.Write(rand.Next(min, max) + " ");
            }
        
    }
}

