using System.ComponentModel.Design;

namespace Bossfight_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameCharacter Hero = new GameCharacter("Hero", 150, strength: 31, 30, 30);
            GameCharacter Boss = new GameCharacter("Boss", 400, strength: 20, 20, 20);


            while (Hero.IsAlive && Boss.IsAlive)
            {
                Console.Clear();
                Console.WriteLine("--- New Round! ---");

                if (Hero.Stamina >= 10)
                {
                    Hero.Fight(Boss);
                }
                else
                {
                    Hero.Recharge();
                }

                if (Boss.IsAlive)
                {
                    if (Boss.Stamina >= 10)
                    {
                        Boss.Fight(Hero);
                    }
                    else
                    {
                        Boss.Recharge();
                    }
                }

                Hero.Status();
                Boss.Status();

                if (!Hero.IsAlive && !Boss.IsAlive)
                {
                    Console.WriteLine("It's a tie!");
                    break;
                }
                else if (!Hero.IsAlive)
                {
                    Console.WriteLine("Boss is the winner!");
                    break;
                }
                else if (!Boss.IsAlive)
                {
                    Console.WriteLine("Hero is the winner!");
                    break;
                }

                Console.WriteLine("\nTrykk en tast for å fortsette...");
                Console.ReadKey();
            }
        }
    }
}
