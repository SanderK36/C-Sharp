using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroInterface_2
{
    internal class SingleAnswerQuestions : IQuestion
    {
        private readonly string _question;
        private readonly string _correctAnswer;

        public SingleAnswerQuestions(string question, string correctAnswer)
        {
            _correctAnswer = correctAnswer;
            _question = question;
        }

        public bool Run()
        {
            Console.WriteLine(_question + " ");
            var answer = Console.ReadLine();
            return answer == _correctAnswer;
        }
    }
}
