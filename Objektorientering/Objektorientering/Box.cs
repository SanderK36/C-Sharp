using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientering
{
    internal class Box
    {
        public int Width;
        public int Height;

        internal void Show()
        {
            Console.WriteLine("Bredden er: " + Width + " og høyden er: " +Height);
        }
    }
}
