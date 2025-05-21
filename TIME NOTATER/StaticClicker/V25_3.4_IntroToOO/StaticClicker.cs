namespace V25_3._4_IntroToOO;

public class StaticClicker
{
    public static void Run()
    {
        var points = 0;
        var upgrades = 1;

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Klikker A: Du har {points} poeng. (a = klikk, A = upgrade)");

            var command = Console.ReadKey(false);
            if (command.KeyChar == 'a')
            {
                points += upgrades;
            } 
            else if (command.KeyChar == 'A')
            {
                if (points >= 10)
                {
                    upgrades++;
                    points -= 10;
                }
            }
            Console.WriteLine();
        }
    }   
}