using System;
using System.Collections.Generic;
using System.Linq;

string text = string.Empty;

Stack<string> changes = new();

int operations = int.Parse(Console.ReadLine());

for (int i = 0; i < operations; i++)
{
	string[] tokens = Console.ReadLine().Split(' ');
	int command = int.Parse(tokens[0]);

	switch (command)
	{
		case 1:
			changes.Push(text);
			text += tokens[1];
			break;
		case 2:
			changes.Push(text);
			int countChange = int.Parse(tokens[1]);
			text = text.Remove(text.Length - countChange);
			break;
		case 3:
			int indexChange = int.Parse(tokens[1]) - 1;
			Console.WriteLine(text[indexChange]);
			break;
		case 4:
			text = changes.Pop();
			break;
	}
}