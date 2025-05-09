namespace Krokkodillespillet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            Console.WriteLine("Velkommen til Krokkodillespillet!");
            Console.WriteLine("Her skal du velge hvilket tall som er størst.. Bruk <..> eller = hvis tallene er like!");
            Console.WriteLine("Tallene er: " + randomNumber + " _ " + (randomNumber + 1));
            Console.WriteLine("Skriv inn <, > eller = for å gjette hvilket tall som er størst.");
            string userGuess = Console.ReadLine();

            string correctAnswer;
            if (randomNumber < randomNumber + 1)
            {
                correctAnswer = ">";
            }
            else if (randomNumber > randomNumber + 1)
            {
                correctAnswer = "<";
            }
            else
            {
                correctAnswer = "=";
            }

            if(userGuess == correctAnswer)
            {
                Console.WriteLine("Riktig! Du gjettet riktig.");
            }
            else
            {
                Console.WriteLine("Feil! Riktig svar var: " + correctAnswer);
            }
            Console.WriteLine("Vil du spille igjen? (ja/nei)");
            string playAgain = Console.ReadLine();

            if (playAgain.ToLower() == "ja")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Takk for at du spilte!");
            }



        }
    }
}
