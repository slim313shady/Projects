using System;


class BankAccountData
{
    static void Main(string[] args)
    {
        string firstName = "Nikolay";
        string middleName = "Georgiev";
        string lastName = "Dobrev";
        decimal money = 00.00m;
        string bankName = "CCB";
        string iban = "BG XX CECB 9790 AAAA AAAA AA";
        long cardNumber1 = 123456789123567;
        long cardNumber2 = 234265455323456;
        long cardNumber3 = 121455215256692;
        Console.WriteLine("{0} {1} {2}\nAvailable amount of money: {3}\n{4} IBAN: {5}\nCard number: {6}\nCard number: {7}\nCard number: {8}", firstName, middleName, lastName, money, bankName, iban, cardNumber1, cardNumber2, cardNumber3);

    }
}

