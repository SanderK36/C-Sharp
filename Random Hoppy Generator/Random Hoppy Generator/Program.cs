namespace Random_Hoppy_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hva heter du?");
            string navn = Console.ReadLine();

            Random random = new Random();
            int tall = random.Next(1, 6);
            string hobby = "";
            if (tall == 1) hobby = "å male";
            if (tall == 2) hobby = "å spille fotball";
            if (tall == 3) hobby = "å kode";
            if (tall == 4) hobby = "å game";
            if (tall == 5) hobby = "å spille gitar";

            Console.WriteLine($"Hei {navn}, din nye hobby er {hobby}!");
        }
    }
}
