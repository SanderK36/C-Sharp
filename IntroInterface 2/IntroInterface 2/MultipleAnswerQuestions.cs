using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroInterface_2
{
    internal class MultipleAnswerQuestions : IQuestion
    {
        private readonly string _question;
        private readonly string[] _answers;
        private readonly int _correctAnswerNo;

        public MultipleAnswerQuestions(string question, int correctAnswerNo, params string[] answers)
        {
            _question = question;
            _correctAnswerNo = correctAnswerNo;
            _answers = answers;
        }

        public bool Run()
        {
            Console.WriteLine(_question);
            Console.WriteLine("Svaralternativer");
            for (var index = 0; index < _answers.Length; index++)
            {
                var answerNo = index + 1;
                var answer = _answers[index];
                Console.WriteLine(answerNo + ": " + answer);
            }

            Console.Write("Velg svaralternativ: ");
            var selectedAnswerNoStr = Console.ReadLine();
            var selectedAnswerNo = Convert.ToInt32(selectedAnswerNoStr);
            return selectedAnswerNo == _correctAnswerNo;
        }

        public int Sander(int a, int b)
        {
            return 0;
        }
    }
}
