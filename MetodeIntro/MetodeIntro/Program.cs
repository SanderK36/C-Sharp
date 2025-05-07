using System;
using System.Security.Cryptography.X509Certificates;

namespace MetodeIntro
{
    internal class Program
    {
        static int tall1 = 4;
        static int tall2 = 5;

        static void Main(string[] args)
        {
            Run();
            nothing();
        }
        public static int returnWholeNumber(int number, int number2)
        {
            return number + number2;
        }

        public static void Run()
        {
            Console.WriteLine($"summen av {tall1} og {tall2} er {returnWholeNumber(tall1, tall2)}");
        }
        public static void nothing()
        {
            Console.WriteLine("Denne metoden returnerer ingenting");
        }
    }
}
