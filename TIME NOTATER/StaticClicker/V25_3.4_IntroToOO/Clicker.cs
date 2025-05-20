namespace V25_3._4_IntroToOO;

public class Clicker
{
    public int Points;
    public int Upgrades;
    public char ClickCharacter;
    public string PlayerName;

    public Clicker(char clickCharacter, string playerName = "")
    {
        ClickCharacter = clickCharacter;
        PlayerName = playerName;
        Upgrades = 1;
        Points = 0;
    }
    public void ShowText()
    {
        Console.WriteLine($"Klikker {char.ToUpper(ClickCharacter)}: Du har {Points} poeng. ({char.ToLower(ClickCharacter)} = klikk, {char.ToUpper(ClickCharacter)} = upgrade)");
    }
    
    public void HandleCommand(ConsoleKeyInfo command)
    {
        if (command.KeyChar == char.ToLower(ClickCharacter))
        {
            Points += Upgrades;
        }
        else if (command.KeyChar == char.ToUpper(ClickCharacter))
        {
            if (Points >= 10)
            {
                Upgrades++;
                Points -= 10;
            }
        }
    }
}