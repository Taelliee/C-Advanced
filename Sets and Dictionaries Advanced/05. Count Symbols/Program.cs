using System;
using System.Collections.Generic;
using System.Linq;

char[] text = Console.ReadLine().ToArray();

SortedDictionary<char, int> letters = new SortedDictionary<char, int>();

for (int i = 0; i < text.Length; i++)
{
	char currLetter = text[i];
	if (!letters.ContainsKey(currLetter))
	{
		letters.Add(currLetter, 0);
	}
	letters[currLetter]++;
}

foreach (var (letter, count) in letters)
{
    Console.WriteLine($"{letter}: {count} time/s");
}