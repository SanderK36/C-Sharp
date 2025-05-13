namespace Objektorientering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var x = new { Width = 50, Height = 30 };
            var x = new Box
            {
                Width = 50,
                Height = 30
            };
            x.Show();
        }
    }
}
