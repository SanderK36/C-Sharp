namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppgave 1

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Terje er kul");
            }

            //Oppgave 2
            string[] navn = { "S", "A", "N", "D", "D", "E", "R" };

            foreach (string i in navn)
            {
                Console.WriteLine(i);
            }

            //Oppgave 3
            int num = 1;
            while(num < 10)
            {
                Console.WriteLine("Runde nummer:" + num);
                num++;
            }
        }
    }
}
