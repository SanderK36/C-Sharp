using V25_3._4_IntroToOO;

public class StaticClickerV3
{
    public static SimpleClicker SimpleClicker = new SimpleClicker();
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
            SimpleClicker.Points += SimpleClicker.Upgrades;
        }
        else if (command.KeyChar == 'A')
        {
            if (SimpleClicker.Points >= 10)
            {
                SimpleClicker.Upgrades++;
                SimpleClicker.Points -= 10;
            }
        }
    }

    private static void ShowText()
    {
        Console.Clear();
        Console.WriteLine($"Klikker A: Du har {SimpleClicker.Points} poeng. (a = klikk, A = upgrade)");
    }
}