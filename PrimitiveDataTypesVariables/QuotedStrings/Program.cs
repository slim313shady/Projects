using System;

class QuotedStrings
{
    static void Main(string[] args)
    {
        string a = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(a);
        string s = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(a);

    }
}

