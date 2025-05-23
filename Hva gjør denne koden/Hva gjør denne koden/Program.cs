﻿// See https://aka.ms/new-console-template for more information

// Oppgave 1: Denn koden teller hvor mange ganger hvert tegn i teksten er brukt.
// oppgave 2: Vi bruker ToUpper() for å håndtere store og små bokstaver likt.
var range = 250;
var counts = new int[range];
int totalLetters = 0;
string text = "something";

while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine() ?? string.Empty;
    foreach (var character in text.ToUpper())
    {
        totalLetters++;
        counts[(int)character]++;
    }
    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            var character = (char)i;
            var percentage = 100 * (double)counts[i] / totalLetters;
            string output = character + " - " + percentage.ToString("F2") + "%";
            Console.CursorLeft = Console.BufferWidth - output.Length - 1;
            Console.WriteLine(output);
        }
    }
}
