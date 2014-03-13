using System;


    class ComparingFloats
    {
        
        static void Main(string[] args)
        {
            float firstA = 5.00000001f;
            float firstB = 5.00000003f;
            Console.WriteLine(CompareNumbers((decimal)firstA, (decimal)firstB));
        }

        private static bool CompareNumbers(decimal numberA, decimal numberB)
        {
            if (Math.Abs(numberA - numberB) < 0.000001m) return true;

            return false;
        }

        
    }

