using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministasjonssystem_test
{
    internal class Karakter
    {
        public int StudentID { get; private set; }
        public string Fagkode { get; private set; }
        public int KarakterVerdi { get; private set; }

        public Karakter(int studentID, string fagkode, int karakterVerdi)
        {
            StudentID = studentID;
            Fagkode = fagkode;
            KarakterVerdi = karakterVerdi;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"StudentID: {StudentID}");
            Console.WriteLine($"Fagkode: {Fagkode}");
            Console.WriteLine($"Karakterverdi: {KarakterVerdi}"); //takk
        }
    }
}
