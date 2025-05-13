using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloads_og_Default_values
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }


        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public void PrintInfo(string extraInfo = " heter jeg")
        {
            Console.WriteLine(Name + extraInfo);
        }
    }
}
