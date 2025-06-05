namespace IntroInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<ITransportation>();
            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
            }
        }
    }
}
