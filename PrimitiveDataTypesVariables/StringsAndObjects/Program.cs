using System;

    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            Object helloWorld = hello + " " + world;

            Console.WriteLine(helloWorld);

            string anotherhelloWorld = (String)helloWorld;
            Console.WriteLine(anotherhelloWorld);

        }
    }

