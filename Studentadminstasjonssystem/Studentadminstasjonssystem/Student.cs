using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadminstasjonssystem
{
    internal class Student
    {
        public string Navn { get; set; }
        public int Alder { get; set; }
        public string Studieprogram { get; set; }
        public string StudentID { get; set; }
        public List<Fag> FagListe { get; set; }
        public List<Karakter> KarakterListe { get; set; }

        public Student(string navn, int alder, string studieprogram, string studentID)
        {
            Navn = navn;
            Alder = alder;
            Studieprogram = studieprogram;
            StudentID = studentID;
            FagListe = new List<Fag>();
            KarakterListe = new List<Karakter>();
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Student: {Navn}, Alder: {Alder}, Studieprogram: {Studieprogram}, StudentID: {StudentID}");
        }

        public double Gjennomsnittskarakter()
        {
            if (KarakterListe.Count == 0) return 0.0;

            double total = 0.0;
            foreach (var karakter in KarakterListe)
            {
                switch (karakter.Karakterverdi.ToUpper())
                {
                    case "A": total += 5; break;
                    case "B": total += 4; break;
                    case "C": total += 3; break;
                    case "D": total += 2; break;
                    case "E": total += 1; break;
                    case "F": total += 0; break;
                    default: break;

                }
            }
            return total / KarakterListe.Count;
        }

        public int BeregnTotalStudiepoeng()
        {
            int totalStudiepoeng = 0;
            foreach (var fag in FagListe)
            {
                totalStudiepoeng += fag.Studiepoeng;
            }

            return totalStudiepoeng;
        }
    }
}
