// See https://aka.ms/new-console-template for more information


while (true)
{
    Console.WriteLine("Skriv ett number for å oversette til hvilken dag det er!");
    var input = Console.ReadLine();
    int number = 5;

    switch (input)
    {
        case "1":
            Console.WriteLine("Det er mandag");

            break;

        case "2":
            Console.WriteLine("Det er tirsdag");

            break;

        case "3":
            Console.WriteLine("Det er onsdag");

            break;

        case "4":
            Console.WriteLine("Det er torsdag");

            break;

        case "5":
            Console.WriteLine("Det er fredag");

            break;

        case "6":
            Console.WriteLine("Det er lørdag");

            break;

        case "7":
            Console.WriteLine("Det er søndag");

            break;

        default:
            Console.WriteLine("Det er ikke en gyldig dag");

            break;
    }

}