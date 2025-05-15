using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadminstasjonssystem
{
    internal class Karakter
    {
        public Student Student { get; set; }
        public Fag Fag { get; set; }
        public string Karakterverdi { get; set; }

        public Karakter (Student student, Fag fag, string karakterverdi)
        {
            Student = student;
            Fag = fag;
            Karakterverdi = karakterverdi;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Student: {Student.Navn}, Fag: {Fag.Fagnavn}, Karakter: {Karakterverdi}");
        }
    }
}
