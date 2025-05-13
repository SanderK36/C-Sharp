using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_og_ikke_static
{
     class PersonInfo
    {
        public static string Name;
        public static string age;
        public static string adress;
        public static void ShowInfo()
        {
            var Width = 20;
            ShowSeperatorRow(Width);
            ShowNameAndAge("Navn", Width, Name);
            ShowNameAndAge("Alder", Width, age);
            ShowNameAndAge("Adresse", Width, adress);
            ShowSeperatorRow(Width);
        }

        private static void ShowNameAndAge(string name, int Width, string age)
        {
            Width -= name.Length;
            Console.WriteLine("  " + name + ":" + string.Empty.PadLeft(Width, ' ') + age);
        }


        private static void ShowSeperatorRow(int Width)
        {
            Width += 14;
            Console.WriteLine(string.Empty.PadLeft(Width, '*'));
        }
    }
}
