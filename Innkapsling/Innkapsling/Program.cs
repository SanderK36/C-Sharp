﻿namespace Innkapsling;

class Program
{
    static void Main(string[] args)
    {
        var stats = new Stats();
        while (true)
        {
            Console.WriteLine("Skriv et tall (eller blankt for å avslutte)");
            var numberStr = Console.ReadLine();
            if (string.IsNullOrEmpty(numberStr)) break;
            var number = Convert.ToInt32(numberStr);
            stats.AddNumber(number);
            stats.Show();

        }
    }
}