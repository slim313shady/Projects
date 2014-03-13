using System;



class NullValuesArithmetic
{
    static void Main(string[] args)
    {
        int? someVariable = null;
        double? someOtherVariable = null;
        byte add = 5;
        someVariable += add;
        someOtherVariable += add;
        //someVariable += null;
        //someOtherVariable += null;


        Console.WriteLine("This is some null varibales {0} and {1}", someVariable, someOtherVariable);
    }
}