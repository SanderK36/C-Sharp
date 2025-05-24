using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight_
{
    internal class GameCharacter
    {
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public string Name { get; set; }

        public GameCharacter(int health, int strength, int stamina)
        {
            Health = health;
            Strength = strength;
            Stamina = stamina;
        }

        public void Fight()
        {
            if (Stamina < 10)
            {
                Console.WriteLine($"{Name}");
            }
        }
    }
}
