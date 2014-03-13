using System;
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int secondNumber = 10;
            int exchange = firstNumber;

            Console.WriteLine("First number {0} & Second number {1} before exchange", firstNumber, secondNumber);

            firstNumber = secondNumber;
            secondNumber = exchange;

            Console.WriteLine("First number {0} & Second number {1} after exchange", firstNumber, secondNumber);

        }
    }

