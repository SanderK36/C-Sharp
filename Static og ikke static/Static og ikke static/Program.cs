using System.Reflection.Emit;

namespace Static_og_ikke_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonInfo.Name = "Sander";
            PersonInfo.age = "20";
            PersonInfo.adress = "Drammen";
            PersonInfo.ShowInfo();

            PersonInfo.Name = "Lars";
            PersonInfo.age = "30";
            PersonInfo.adress = "Oslo";
            PersonInfo.ShowInfo();
        }

       
    }
}
