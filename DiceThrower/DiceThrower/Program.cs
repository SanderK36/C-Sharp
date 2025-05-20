// See https://aka.ms/new-console-template for more information
using DiceThrower;
DiceMaster diceMaster = new DiceMaster();

MainMenu();
void MainMenu()
{
    Console.WriteLine("DICE THROWER!!! We're now gonna throw the dice!");
    Console.WriteLine("1. Choose number of dice throws (10 if nothing is specified)");
    Console.WriteLine("2. Show All statistics");
    Console.WriteLine("3. Show Specific statistics");

    var menuChoice = Console.ReadLine();

    switch (menuChoice)
    {
        case "1":
            ChooseNumberOfDiceThrows();
            DiceMaster.CompleteDiceThrows();
            break;
        case "2":
            DiceMaster.CompleteDiceThrows();
            DiceMaster.ShowAllStatistics();
            break;
    }
}



void ChooseNumberOfDiceThrows()
{
    Console.WriteLine("What number of throws?");
    var numberOfThrows = int.Parse(Console.ReadLine());
    diceMaster.SetNumberOfthrows(numberOfThrows);
}
