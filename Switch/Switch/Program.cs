namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett number for å oversette til hvilken dag det er!");
            var input = Console.ReadLine();
            int number = 5;

            switch(input)
            {
                case "1":
                    Console.WriteLine("Det er mandag");
                    Main(args);
                    break;

                case "2":
                    Console.WriteLine("Det er tirsdag");
                    Main(args);
                    break;

                case "3":
                    Console.WriteLine("Det er onsdag");
                    Main(args);
                    break;

                case "4":
                    Console.WriteLine("Det er torsdag");
                    Main(args);
                    break;

                case "5":
                    Console.WriteLine("Det er fredag");
                    Main(args);
                    break;

                case "6":
                    Console.WriteLine("Det er lørdag");
                    Main(args);
                    break;

                case "7":
                    Console.WriteLine("Det er søndag");
                    Main(args);
                    break;

                default:
                    Console.WriteLine("Det er ikke en gyldig dag");
                    Main(args);
                    break;
            }

        }
    }
}
