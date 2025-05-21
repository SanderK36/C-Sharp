using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering
{
    public class Sander
    {
        private int Age = 24;
        private string Name = "Sander";
        private string Hobby = "Gitar";
        private string FavMusic = "Metal";

        public void run()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Hallo! Jeg heter {Name} og er {Age} år gammel :)");
            Console.WriteLine($"Min hobby er å spille {Hobby}");
            Console.WriteLine($"Min favoritt musikk er {FavMusic}");
            Console.WriteLine("----------------------------------------------------");
        }

    }

}
