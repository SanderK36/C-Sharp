// See https://aka.ms/new-console-template for more information

Random random = new Random();
ThrowDice();
void ThrowDice()
{
    Console.WriteLine("DICE THROWER!!! We're now gonna throw the dice!");
    int NumberOfThrownNumberOne = 0;
    int NumberOfThrownNumberTwo = 0;
    int NumberOfThrownNumberThree = 0;
    int NumberOfThrownNumberFour = 0;
    int NumberOfThrownNumberFive = 0;
    int NumberOfThrownNumberSix = 0;

    for (int i = 0; i < 10000; i++)
    {
        var diceThrow = GetRandomDice();
        if(diceThrow == 1)
        {
            NumberOfThrownNumberOne++;
        }
        else if (diceThrow == 2)
        {
            NumberOfThrownNumberTwo++;
        }
        else if (diceThrow == 3)
        {
            NumberOfThrownNumberThree++;
        }
        else if (diceThrow == 4)
        {
            NumberOfThrownNumberFour++;
        }
        else if (diceThrow == 5)
        {
            NumberOfThrownNumberFive++;
        }
        else if (diceThrow == 6)
        {
            NumberOfThrownNumberSix++;
        }
        Console.WriteLine($"You rolled a {diceThrow}!");
    }
    Console.WriteLine($"You rolled a 1 - {NumberOfThrownNumberOne} times.");
    Console.WriteLine($"You rolled a 2 - {NumberOfThrownNumberTwo} times.");
    Console.WriteLine($"You rolled a 3 - {NumberOfThrownNumberThree} times.");
    Console.WriteLine($"You rolled a 4 - {NumberOfThrownNumberFour} times.");
    Console.WriteLine($"You rolled a 5 - {NumberOfThrownNumberFive} times.");
    Console.WriteLine($"You rolled a 6 - {NumberOfThrownNumberSix} times.");
}

int GetRandomDice()
{
    int diceResult = random.Next(1, 7);
    return diceResult;
}
