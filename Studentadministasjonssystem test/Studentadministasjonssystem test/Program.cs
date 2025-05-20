namespace Studentadministasjonssystem_test
{
    internal class Program
    {
        List<Karakter> Karakk = new List<Karakter>();
        static void Main(string[] args)
        {
            Fag Naturfag = new Fag("Naturfag", "Nat101", 15);
            Fag Norsk = new Fag("Norsk", "Nor105", 20);
            Fag Matte = new Fag("Matte", "Mat109", 25);

            Fag Test = new Fag("Matte", "Mat109", 25);

            List<Fag> AktiveFag = new List<Fag>();
            AktiveFag.Add(Naturfag);
            AktiveFag.Add(Norsk);
            List<Fag> AktiveFag2 = new List<Fag>();
            AktiveFag2.Add(Matte);
            
           
            Student student1 = new Student("Ole Nordmann", 20, AktiveFag, 12345);
            Student student2 = new Student("Kari Nordmann", 22, AktiveFag2, 67890);
            Karakter karakter1 = new Karakter(student1.StudentID, Naturfag.Fagkode, "A");
            Karakter karakter2 = new Karakter(student2.StudentID, Norsk.Fagkode, "B");

           


            student1.SkrivUtInfo();
            Console.WriteLine("-------------------------------------------------------");
            student2.SkrivUtInfo();
            

            
        }
    }
}
