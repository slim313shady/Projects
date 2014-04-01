using System;
using System.Globalization;

class BeerTime
{
    static void Main(string[] args)
    {
        CultureInfo provider = CultureInfo.InvariantCulture;

        Console.Write("Please enter Time in selected format 'h:mm tt': ");
        string dateString = Console.ReadLine();
        string format = "h:mm tt";

        try
        {
            DateTime result = DateTime.ParseExact(dateString, format, provider);

            Console.WriteLine("{0} converts to {1}.", dateString, result.ToString()); // to see how actual Time is represented
            if (result.Hour >= 13 || result.Hour <= 1)
            {

                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("{0} is not in the correct format.", dateString);
        }
    }
}

