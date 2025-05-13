using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PikachuObject
{
    public class Pikachu
    {
        public int Health;
        public int Level;

        internal void Show()
        {
            Console.WriteLine($"Pikachu har " + Health + " HP og er level " + Level);
        }
    }
}
