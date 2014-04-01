using System;

class PrintCompanyInformation
{
    static void Main(string[] args)
    {
        Console.Write("Company Name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company Address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Company Number: ");
        string companyNumber = Console.ReadLine();
        Console.Write("Company Fax: ");
        string companyFax = Console.ReadLine();
        Console.Write("Company Website: ");
        string companySite = Console.ReadLine();
        Console.Write("Company Manager: ");
        string companyManager = Console.ReadLine();
        Console.Write("Manager First name: ");
        string managerName = Console.ReadLine();
        Console.Write("Manager Last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager Age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager Number: ");
        string managerNumber = Console.ReadLine();

        Console.WriteLine("Company Name: {0}", companyName);
        Console.WriteLine("Company Address: {0}", companyAddress);
        Console.WriteLine("Company Number: {0}", companyNumber);
        Console.WriteLine("Company Fax: {0}", companyFax);
        Console.WriteLine("Company Website: {0}", companySite);
        Console.WriteLine("Company Manager: {0}", companyManager);
        Console.WriteLine("Manager : {0} {1}", managerName, managerLastName);
        Console.WriteLine("Manager Number: {0}", managerNumber);
        Console.WriteLine("Manager Age: {0}", managerAge);
    }
}

