namespace TekstTkling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Meny
            Console.WriteLine("Velg en av følgende alternativer:");
            Console.WriteLine("1. RotateText (snur teksten)");
            Console.WriteLine("2. Change word (bytter ¨e¨ med ¨a¨)");
            Console.WriteLine("3. avslutt");

            string choice = Console.ReadLine();

            // avslutt hvis valget er 3
            if (choice == "3")
            {
                Console.WriteLine("Avslutter programmet...");
            }

            //ber user skrive ett ord hvis 1 eller 2 er valgt
            if (choice == "1" || choice == "2")
            {
                Console.WriteLine("Skriv inn ett ord");
                string input = Console.ReadLine();
                if( choice == "1")
                {
                    string result = rotateText(input);
                    Console.WriteLine("Resultatet er: " + result);
                }
                else if(choice == "2")
                {
                    string result = ChangeWord(input);
                    Console.WriteLine("Resultatet er: " + result);
                }

                Console.WriteLine("Vil du fortsette? (ja/nei)");
                string continueChoice = Console.ReadLine();

                if (continueChoice.ToLower() == "ja")
                {
                    Main(args);
                }
                else
                {
                    Console.WriteLine("Avslutter programmet...");
                }
            }
            else
            {
                Console.WriteLine("Ugyldig valg, vennligst velg 1, 2 eller 3.");
            }

            static string rotateText(string text)
            {
                char[] chars = text.ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            }

            static string ChangeWord(string text)
            {
                return text.Replace("e", "a");
            }
        }
    }
}
