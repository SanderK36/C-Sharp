using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Hobby { get; set; }
        public string FavMusic { get; set; }
        public Person(string name, int age, string hobby, string favMusic)
        {
            Name = name;
            Age = age;
            Hobby = hobby;
            FavMusic = favMusic;
        }

        public void Run()
        { 
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine($"Hallo! Jeg heter {Name} og er {Age} år gammel :)");
            Console.WriteLine($"Min hobby er {Hobby} og favoritt musikken min er {FavMusic}");
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
    }
}
