using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Bio { get; set; }
        public List<User> Friends { get; set; }

        public User(string name, int age, string bio)
        {
            Name = name;
            Age = age;
            Bio = bio;
            Friends = new List<User>();
        }

        public void AddFriend(User friend)
        {
            if (friend == null)
            {
                Console.WriteLine("Ugyldig bruker!");
                return;
            }

            if (friend == this)
            {
                Console.WriteLine("Du kan ikke legge til deg selv som venn!");
                return;
            }
            if (Friends.Contains(friend))
            {
                Console.WriteLine($"{friend.Name} er allerede vennen din!");
                return;
            }

            Friends.Add(friend);
            friend.Friends.Add(this);
            Console.WriteLine($"Venn lagt til: {friend.Name}");
        }

        public void RemoveFriend(User friend)
        {
            if (friend == null)
            {
                Console.WriteLine("Ugyldig bruker!");
                return;
            }
            if (!Friends.Contains(friend))
            {
                Console.WriteLine($"{friend.Name} er ikke i vennelisten din!");
                return;
            }

            Friends.Remove(friend);
            friend.Friends.Remove(this);
            Console.WriteLine($"Venn fjernet: {friend.Name}");
        }

        public void ShowFriends()
        {
            if (Friends.Count == 0)
            {
                Console.WriteLine("Du har ingen venner ennå.");
                return;
            }

            Console.WriteLine("Dine venner;");
            for (int i = 0; i < Friends.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Friends[i].Name}");
            }
        }

        public void ShowProfile()
        {
            Console.WriteLine($"Profile for {Name}");
            Console.WriteLine($"Alder: {Age}");
            Console.WriteLine($"Bio: {Bio}");
            Console.WriteLine($"Antall venner: {Friends.Count}");
        }
    }
}
