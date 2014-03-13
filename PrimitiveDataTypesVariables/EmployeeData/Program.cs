using System;

    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName="Nikolay";
            string lastName="Dobrev";
            sbyte ages=24;
            char gender='m';
            long idNumber = 8306112507;
            int empNumber = 27569999;

            Console.WriteLine("First name: {0},Last Name: {1},Age: {2},Gender: {3},idNumber: {4},empNumber: {5}", firstName, lastName, ages, gender, idNumber, empNumber);
        }
    }
