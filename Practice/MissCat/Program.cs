using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MissCat
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());     // number of juries
        List<int> votes = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Jury {0} votes: ", i);
            int currentCat = int.Parse(Console.ReadLine()); // from 1 to 10 cats

            votes[currentCat - 1]++;
        }

        int indexOfWinner = votes.IndexOf(votes.Max()) + 1;

        Console.WriteLine("The winner is: {0}",indexOfWinner);
    }
}

