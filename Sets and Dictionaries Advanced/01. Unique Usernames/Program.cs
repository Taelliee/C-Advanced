using System.Collections.Generic;
using System;

HashSet<string> names =  new HashSet<string>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
	names.Add(Console.ReadLine());
}

Console.WriteLine(string.Join("\n", names));