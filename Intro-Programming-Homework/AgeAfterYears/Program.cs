using System;

    class AgeAfterYears
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please your birthday year: ");
            int years = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please your birthday month: ");
            int months = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please your birthday day: ");
            int days = int.Parse(Console.ReadLine());

            DateTime birthDay = new DateTime(years, months, days);
            DateTime today = DateTime.Today;

            int age = today.Year - birthDay.Year;
            if (birthDay > today.AddYears(-age)) age--; // if your birhtday > today Date Before age (years)

            Console.WriteLine("You are {0} years old and after 10 years you will be {1}", age, age + 10);
        }
    }

