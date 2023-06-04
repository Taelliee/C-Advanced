using System.Collections.Generic;
using System;
using System.Linq;

SortedSet<string> elements =  new SortedSet<string>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
	string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
		.ToArray();

	foreach (string element in line)
	{
		elements.Add(element);
	}
}
Console.WriteLine(string.Join(" ", elements));