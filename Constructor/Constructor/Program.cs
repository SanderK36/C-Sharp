namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constructor oppgave 1:
            var pikachu = new Pokemon("Pikachu", 5, 100);
            var charmander = new Pokemon("Charmander", 7, 100);
            var bulbasaur = new Pokemon("Bulbasaur", 6, 100);
            var squirtle = new Pokemon("Squirtle", 4, 100);

            pikachu.show();
            charmander.show();
            bulbasaur.show();
            squirtle.show();
        }
    }
}
