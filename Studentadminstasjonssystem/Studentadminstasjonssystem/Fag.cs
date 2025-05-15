using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadminstasjonssystem
{
    internal class Fag
    {
        public string Fagkode { get; set; }
        public string Fagnavn { get; set; }
        public int Studiepoeng { get; set; }

        public Fag(string fagkode, string fagnavn, int studiepoeng)
        {
            Fagkode = fagkode;
            Fagnavn = fagnavn;
            Studiepoeng = studiepoeng;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Fag: {Fagnavn}, Fagkode: {Fagkode}, Studiepoeng: {Studiepoeng}");
        }
    }
}
