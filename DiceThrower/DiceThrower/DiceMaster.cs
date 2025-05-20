using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower
{
    internal class DiceMaster
    {
        public static Random random = new Random();
        public static int NumberOfThrownNumberOne = 0;
        public static int NumberOfThrownNumberTwo = 0;
        public static int numberOfThrows = 10;

        public static void CompleteDiceThrows()
        {
            for (int i = 0; i < numberOfThrows; i++)
            {
                ThrowDiceAndIncStats();
            }
        }

        public void SetNumberOfthrows(int newNumberOfThrows)
        {
            int numberOfThrows = newNumberOfThrows;
        }

        public static void ShowAllStatistics()
        {
            Console.WriteLine($"You rolled a 1 - {NumberOfThrownNumberOne} times.");
            Console.WriteLine($"You rolled a 2 - {NumberOfThrownNumberTwo} times.");
        }
        public static void ThrowDiceAndIncStats()
        {
            for (int i = 0; i < numberOfThrows; i++)
            {
                var diceThrow = GetRandomDice();
                if (diceThrow == 1)
                {
                    NumberOfThrownNumberOne++;
                }
                else if (diceThrow == 2)
                {
                    NumberOfThrownNumberTwo++;
                }
                Console.WriteLine($"You rolled a {diceThrow}!");
            }
        }

        public static int GetRandomDice()
        {
            int diceResult = random.Next(1, 7);
            return diceResult;
        }
    }
}
