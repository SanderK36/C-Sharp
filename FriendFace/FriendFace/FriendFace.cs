using System;
using System.Collections.Generic;

namespace FriendFace
{
    internal class FriendFace
    {
        private User mainUser;
        private List<User> allUsers;

        public FriendFace()
        {
            InitializeUsers();
        }

        private void InitializeUsers()
        {
            mainUser = new User("Sander Karlsen", 24, "Liker koding og spille gitar");

            allUsers = new List<User>
            {
                mainUser,
                new User("Ola Hansen", 30, "Gamer og kaffeentusiast"),
                new User("Per Olsen", 28, "Liker sport og musikk"),
                new User("Anna Larsen", 22, "Elsker å reise")
            };
        }

        public void Run()
        {
            bool running = true;
            while (running)
            {
                ShowMenu();
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Ugyldig valg, prøv igjen!");
                    Console.WriteLine("Trykk en tast for å fortsette...");
                    Console.ReadKey();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddFriend();
                        break;
                    case 2:
                        RemoveFriend();
                        break;
                    case 3:
                        Console.Clear();
                        mainUser.ShowFriends();
                        Console.WriteLine("Trykk en tast for å fortsette...");
                        Console.ReadKey();
                        break;
                    case 4:
                        ShowFriendProfile();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Takk for at du brukte FriendFace!");
                        running = false;
                        break;
                }
            }
        }

        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine($"\nVelkommen til FriendFace, {mainUser.Name}!");
            Console.WriteLine("1. Legg til en venn");
            Console.WriteLine("2. Fjern en venn");
            Console.WriteLine("3. Vis vennelisten min");
            Console.WriteLine("4. Vis en venns profil");
            Console.WriteLine("5. Avslutt");
            Console.WriteLine("Velg et alternativ (1-5):");
        }

        private void AddFriend()
        {
            Console.Clear();
            List<User> availableUsers = new List<User>();
            for (int i = 0; i < allUsers.Count; i++)
            {
                User user = allUsers[i];
                if (user != mainUser && !mainUser.Friends.Contains(user))
                {
                    availableUsers.Add(user);
                }
            }

            if (availableUsers.Count == 0)
            {
                Console.WriteLine("Ingen brukere å legge til som venn!");
                Console.WriteLine("Trykk en tast for å fortsette...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Velg en bruker å legge til som venn:");
            for (int i = 0; i < availableUsers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {availableUsers[i].Name}");
            }

            string input = Console.ReadLine();
            if (!int.TryParse(input, out int choice) || choice < 1 || choice > availableUsers.Count)
            {
                Console.WriteLine("Ugyldig valg!");
                Console.WriteLine("Trykk en tast for å fortsette...");
                Console.ReadKey();
                return;
            }

            User selectedUser = availableUsers[choice - 1];
            mainUser.AddFriend(selectedUser);
            Console.WriteLine("Trykk en tast for å fortsette...");
            Console.ReadKey();
        }

        private void RemoveFriend()
        {
            Console.Clear();
            if (mainUser.Friends.Count == 0)
            {
                Console.WriteLine("Du har ingen venner å fjerne!");
                Console.WriteLine("Trykk en tast for å fortsette...");
                Console.ReadKey();
                return;
            }

            mainUser.ShowFriends();
            Console.WriteLine("Velg en venn å fjerne:");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int choice) || choice < 1 || choice > mainUser.Friends.Count)
            {
                Console.WriteLine("Ugyldig valg!");
                Console.WriteLine("Trykk en tast for å fortsette...");
                Console.ReadKey();
                return;
            }

            User selectedFriend = mainUser.Friends[choice - 1];
            mainUser.RemoveFriend(selectedFriend);
            Console.WriteLine("Trykk en tast for å fortsette...");
            Console.ReadKey();
        }

        private void ShowFriendProfile()
        {
            Console.Clear(); 
            if (mainUser.Friends.Count == 0)
            {
                Console.WriteLine("Du har ingen venner å vise profilen til!");
                Console.WriteLine("Trykk en tast for å fortsette...");
                Console.ReadKey();
                return;
            }

            mainUser.ShowFriends();
            Console.WriteLine("Velg en venn å vise profilen til:");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int choice) || choice < 1 || choice > mainUser.Friends.Count)
            {
                Console.WriteLine("Ugyldig valg!");
                Console.WriteLine("Trykk en tast for å fortsette...");
                Console.ReadKey();
                return;
            }

            User selectedFriend = mainUser.Friends[choice - 1];
            Console.Clear();
            selectedFriend.ShowProfile();
            Console.WriteLine("Trykk en tast for å fortsette...");
            Console.ReadKey();
        }
    }
}