using System;
using System.Collections.Generic;

// {[()]}
// {[(])}

string sequence = Console.ReadLine();

Stack<char> stack = new();

foreach (char item in sequence)
{
	switch (item)
	{
		case '{':
		case '[':
		case '(':
			stack.Push(item);
			break;
		case '}':
			if (stack.Count == 0 || stack.Pop() != '{')
			{
				Console.WriteLine("NO");
				return;
			}
			break;
		case ']':
			if (stack.Count == 0 || stack.Pop() != '[')
			{
				Console.WriteLine("NO");
				return;
			}
			break;
		case ')':
			if (stack.Count == 0 || stack.Pop() != '(')
			{
				Console.WriteLine("NO");
				return;
			}
			break;
	}
}
if (stack.Count > 0)
{
	Console.WriteLine("NO");
}
else
{
	Console.WriteLine("YES");
}
