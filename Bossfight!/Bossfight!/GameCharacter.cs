using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        public bool IsAlive => Health > 0;
        public int InitialStamina { get; set; }
        private static Random random = new Random();

        public GameCharacter(string name, int health, int strength, int stamina, int initialStamina)
        {
            Health = health;
            Strength = strength;
            Stamina = stamina;
            Name = name;
            InitialStamina = initialStamina;
        }

        public void Fight(GameCharacter opponent)
        {
            if (Stamina >= 10)
            {
                if (Name == "Boss")
                {
                    Strength = random.Next(0, 31);
                }

                opponent.Health -= Strength;
                if (opponent.Health < 0)
                {
                    opponent.Health = 0;
                }
                Stamina -= 10;
                Console.WriteLine($"{Name} hit {opponent.Name} with {Strength} damage, {opponent.Name} now has {opponent.Health} health left!");
            }
            else
            {
                Console.WriteLine($"{Name} is too tired!");
            }
        }

        public void Recharge()
        {
            Stamina = InitialStamina;
            Console.WriteLine($"{Name} is recharging stamina!");
        }

        public void Status()
        {
            Console.WriteLine(IsAlive ? $"{Name} is alive! Health: {Health}, Stamina: {Stamina}" : $"{Name} is dead!");
        }
    }
}
