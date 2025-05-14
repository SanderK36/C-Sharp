using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering
{
    public class Ole()
    {
        private int Age = 28;
        private string Name = "Ole";
        private string Hobby = "Trening-og-tur";
        private string FavMusic = "Hardstyle-og-Metal";

        public void run()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Hallo! Jeg heter {Name} og er {Age} år gammel :)");
            Console.WriteLine($"Mine hobbyer er å {Hobby}");
            Console.WriteLine($"Min favortitt musikk er {FavMusic} ");
            Console.WriteLine("----------------------------------------------------");
        }
    }


}
