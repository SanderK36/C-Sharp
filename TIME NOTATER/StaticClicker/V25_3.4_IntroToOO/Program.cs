using System.Text.Json;
using V25_3._4_IntroToOO;

// StaticClicker.Run();
// StaticClickerV2.Run();
// StaticClickerV3.Run();

var scoreFileContent = File.ReadAllText("scores.json");
var scores = JsonSerializer.Deserialize<ClickerScore[]>(scoreFileContent, new JsonSerializerOptions
{
    IncludeFields = true
});

var clickers = new Clicker[]
{
    new Clicker('a', "Dag"),
    new Clicker('b', "Dagmar"),
    new Clicker('c', "Dagros"),
    new Clicker('d', "Dagobert"),
    new Clicker('x'),
};

while (true)
{
    Console.Clear();
    foreach (var clicker in clickers)
    {
        clicker.ShowText();
    }

    var command = Console.ReadKey(true);
    if (command.Key == ConsoleKey.Backspace)
    {
        break;
    }
    foreach (var clicker in clickers)
    {
        clicker.HandleCommand(command);
    }
}

var newScores = new List<ClickerScore>();
foreach (var clicker in clickers)
{
    newScores.Add(new ClickerScore
    {
        Name = clicker.PlayerName,
        Score = clicker.Points
    });
}

File.WriteAllText("scores.json", JsonSerializer.Serialize(newScores, new JsonSerializerOptions
{
    IncludeFields = true
}));
// Skriv resultat at clickere til json (scores.json)
