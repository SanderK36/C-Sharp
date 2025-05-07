namespace Datatyper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opgave 1
            int tall = 8;

            float desimalTall = 4.05F;
            double desimalTall2 = 2.03;
            decimal desimalTall3 = 6.4M;

            char bokstav = 'a';
            string tekst = "Hei på deg";

            bool heterJegSander = true;

            int[] tallArray = { 1, 2, 3, 4, 5 };
            string[] tekstArray = { "Hei", "på", "deg" };

            List<int> listeMedTall = new List<int>();


            // Oppgave 2

            int a = 5;
            decimal b = 3;
            decimal sum = a + b;
            Console.WriteLine($"Summen av {a} og {b} er {sum}");



        }
    }
}
