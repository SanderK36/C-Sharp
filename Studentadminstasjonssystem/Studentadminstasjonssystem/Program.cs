namespace Studentadminstasjonssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Sander", 24, "Programmering", "4216");
            Student student2 = new Student("Kevin", 30, "Dataingeniør", "6533");


            List<Fag> fagListe = new List<Fag>
            {
                new Fag("C#101", "Grunnleggende programmering", 15),
                new Fag("MAT202", "Matematikk for ingeniører", 15),
                new Fag("INF102", "Databaser", 10)
            };

            student1.FagListe.Add(fagListe[0]);
            student1.FagListe.Add(fagListe[1]);
            student2.FagListe.Add(fagListe[0]);
            student2.FagListe.Add(fagListe[2]);



            Karakter karakter1 = new Karakter(student1, fagListe[0], "A");
            Karakter karakter2 = new Karakter(student1, fagListe[1], "B");
            Karakter karakter3 = new Karakter(student2, fagListe[0], "A");
            Karakter karakter4 = new Karakter(student2, fagListe[2], "C");

            student1.KarakterListe.Add(karakter1);
            student1.KarakterListe.Add(karakter2);
            student2.KarakterListe.Add(karakter3);
            student2.KarakterListe.Add(karakter4);

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("--- Studenter ---");
            Console.ForegroundColor = ConsoleColor.Cyan;
            student1.SkrivUtInfo();
            Console.WriteLine("----------------");
            student2.SkrivUtInfo();
            Console.ResetColor();

            Console.WriteLine("\n--- Fag ---");
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var karakter in student1.KarakterListe)
            {

                karakter.SkrivUtInfo();
            }

            foreach (var karakter in student2.KarakterListe)
            {
                karakter.SkrivUtInfo();
            }
            Console.ResetColor();

            Console.WriteLine("\n--- Gjennomsnittskarakter og studiepoeng ---");
            Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{student1.Navn}: Gjennomsnittskarakter = {student1.Gjennomsnittskarakter():F2}, Total studiepoeng = {student1.BeregnTotalStudiepoeng()}");
                Console.WriteLine($"{student2.Navn}: Gjennomsnittskarakter = {student2.Gjennomsnittskarakter():F2}, Total studiepoeng = {student2.BeregnTotalStudiepoeng()}");
                Console.ResetColor();
            Console.WriteLine("-----------------------------------------------------------------------------");

        }
    }
}
