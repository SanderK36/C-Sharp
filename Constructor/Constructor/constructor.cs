﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }

        public Pokemon(string name, int level, int health)
        {
            Name = name;
            Level = level;
            Health = health;
        }
        public void show()
        {
            Console.WriteLine($"Name: {Name}, Level: {Level}, HP: {Health}");
        }
    }

}
