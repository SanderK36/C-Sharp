namespace PikachuObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = new Pikachu
            {
                Health = 50,
                Level = 21
            };
            x.Show();
        }
    }
}
