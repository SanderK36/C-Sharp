namespace Organ_Transplant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Emergency! Bernt has been in an accident and needs a kidney transplant!");
                Thread.Sleep(2000);

                Person Bernt = new Person("Bernt", 0, true);
                Person Kåre = new Person("Kåre", 2, true);

                Console.Clear();
                Console.WriteLine("Status:");
                Bernt.CheckStatus();
                Kåre.CheckStatus();
                Thread.Sleep(3500);

                Console.Clear();
                Console.WriteLine("Preparing transplatation...");
                Thread.Sleep(3500);
                Console.Clear();
                Console.Write("Checking compatibility...");
                Thread.Sleep(3500);
                Console.Write("....");
                Thread.Sleep(3500);
                Console.Write("Success!");
                Thread.Sleep(3500);

                Console.Clear();
                Console.WriteLine("Performing transplatation...");
                Thread.Sleep(3500);
                Console.Clear();
                Kåre.DonateKidney();
                bool transplantSuccess = Bernt.ReceiveKidney();
                Thread.Sleep(3500);

                Console.Clear();
                Console.WriteLine("Final status");
                Console.Clear();
                Bernt.CheckStatus();
                Kåre.CheckStatus();
                Thread.Sleep(3500);

                if (transplantSuccess)
                {
                    Console.Clear();
                    Console.WriteLine("The transplatation was successful! Bernt is saved!");
                    Thread.Sleep(3500);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("The transplantation failed. Bernt could not be saved...");
                    Thread.Sleep(3500);
                }

                break;
            }

        }
    }
}
