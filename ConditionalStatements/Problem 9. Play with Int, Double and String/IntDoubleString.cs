using System;

class IntDoubleString
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Please enter an int: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(b + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string c = Console.ReadLine();
                Console.WriteLine(c + "*");
                break;
            default:
                Console.WriteLine("Your choice must be between 1 and 3");
                break;
        }

    }
}

