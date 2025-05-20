using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministasjonssystem_test
{
    internal class Fag
    {
        public string Fagnavn { get; private set; }
        public string Fagkode { get; private set; }
        public int AntallStudiepoeng { get; private set; }

        public Fag(string fagnavn, string fagkode, int antallStudiepoeng)
        {
            Fagnavn = fagnavn;
            Fagkode = fagkode;
            AntallStudiepoeng = antallStudiepoeng;

        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Fagnavn: {Fagnavn}");
            Console.WriteLine($"Fagkode: {Fagkode}");
            Console.WriteLine($"AntallStudiepoeng: {AntallStudiepoeng}");
        }


    }
}
