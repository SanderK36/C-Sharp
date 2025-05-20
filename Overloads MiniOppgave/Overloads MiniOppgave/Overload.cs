using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloads_MiniOppgave
{
    public class Overload
    {
        //public static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Hei og velkommen!");
        //}

        public static void PrintWelcomeMessage(string kompliment = "Du er snill!")
        {
            Console.WriteLine($"Hei og velkommen {kompliment}");
        }
    }
}

        
