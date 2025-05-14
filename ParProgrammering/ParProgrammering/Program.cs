namespace ParProgrammering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person("Sander", 24, "spille gitar", "Metal"),
                new Person("Ole", 28, "Trening-og-tur", "Hardstyle-og-Metal")
            };
            foreach (Person person in people)
            {
                person.Run();
            }
        }
    }
}
