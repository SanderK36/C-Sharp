using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloads_MiniOppgave
{
    public class Overload
    {
        public void PrintWelcomeMessage()
        {
            Console.WriteLine("Velkommen!");
        }

        public void PrintWelcomeMessage(string compliment = "Du er snill!")
        {
            Console.WriteLine($"Hei og velkommen! {compliment}");
        }
    }
}
