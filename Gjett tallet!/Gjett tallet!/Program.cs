namespace Gjett_tallet_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til Gjett tallet!!");
            Console.WriteLine("Jeg har tenkt på et tall mellom 1 og 20.");
            Console.WriteLine("Kan du gjette hvilket tall det er?");
            Random random = new Random();
            int randomNumber = random.Next(1, 21);
            int guess = 0;
            int attempts = 0;
            
            while (guess != randomNumber)
            {
                string userInput = Console.ReadLine();
                if(userInput == "")
                {
                    Console.WriteLine("Du må skrive inn et tall!");
                    continue;
                }

                int parsedNumber = 0;
                parsedNumber = Convert.ToInt32(userInput);

                if (parsedNumber < 1 || parsedNumber > 20)
                {
                    Console.WriteLine("Tallet må være mellom 1 og 20!");
                }
                else
                {
                    guess = parsedNumber;
                    attempts++;

                    if(guess < randomNumber)
                    {
                        Console.WriteLine("Høyere! gjett igjen");
                    }
                    else if(guess > randomNumber)
                    {
                        Console.WriteLine("Lavere! gjett igjen:");
                    }
                    else
                    {
                        Console.WriteLine($"Gratulerer! Du gjettet tallet {randomNumber} på {attempts} forsøk!");
                        Console.WriteLine("Vil du spille igjen? (ja/nei)");
                        string playAgain = Console.ReadLine();
                        if (playAgain.ToLower() == "ja")
                        {
                            Main(args); // Restart the game
                        }
                        else
                        {
                            Console.WriteLine("Takk for at du spilte! Ha en fin dag!");
                            break;
                        }
                    }
                }
            }
        }
    }
}
