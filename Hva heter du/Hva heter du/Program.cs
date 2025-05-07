namespace Hva_heter_du
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei på deg! Hva heter du?");
            var userName = Console.ReadLine();
            Console.WriteLine($"Hei {userName}!");
        }
    }
}
