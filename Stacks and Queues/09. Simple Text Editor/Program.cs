using System;
using System.Collections.Generic;

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
			for (int j = 0; j < int.Parse(tokens[1]); j++)
			{
				changes.Pop();
			}
			break;
		case 3:

			break;
		case 4:
			text = changes.Pop();
			break;
	}
}