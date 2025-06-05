namespace IntroInterface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = new IQuestion[]
            {
                new SingleAnswerQuestions("Hva er 2+2?", "4"),
                new MultipleAnswerQuestions("Hva er hovedstaden i Norge?", 3, "Stavern", "Larvik", "Oslo"),
            };

            var points = 0;
            foreach (var question in questions)
            {
                var isCorrect = question.Run();
                if(isCorrect)
                {
                    Console.WriteLine("Rikig!");
                }
                else
                {
                    Console.WriteLine("Feil!");
                }
            }
            Console.WriteLine($"Du fikk {points} poeng.");
        }
    }
}
