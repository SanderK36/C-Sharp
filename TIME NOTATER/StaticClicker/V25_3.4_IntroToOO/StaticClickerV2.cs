namespace V25_3._4_IntroToOO;

public class StaticClickerV2
{
    public static int Points = 0;
    public static int Upgrades = 1;

    public static void Run()
    {
        while (true)
        {
            ShowText();
            var command = Console.ReadKey(false);
            HandleCommand(command);
            Console.WriteLine();
        }
    }

    private static void HandleCommand(ConsoleKeyInfo command)
    {
        if (command.KeyChar == 'a')
        {
            Points += Upgrades;
        }
        else if (command.KeyChar == 'A')
        {
            if (Points >= 10)
            {
                Upgrades++;
                Points -= 10;
            }
        }
    }

    private static void ShowText()
    {
        Console.Clear();
        Console.WriteLine($"Klikker A: Du har {Points} poeng. (a = klikk, A = upgrade)");
    }
}