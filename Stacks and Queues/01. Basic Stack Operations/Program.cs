using System;
using System.Collections.Generic;
using System.Linq;

int[] tokens = Console.ReadLine()
	.Split(' ', StringSplitOptions.RemoveEmptyEntries)
	.Select(int.Parse)
	.ToArray(); //5 2 13

int[] numbers = Console.ReadLine()
	.Split(' ', StringSplitOptions.RemoveEmptyEntries)
	.Select(int.Parse)
	.ToArray(); //1 13 45 32 4

Stack<int> stack = new Stack<int>();

for (int i = 0; i < tokens[0]; i++)
{
	stack.Push(numbers[i]);
}

for (int i = 0; i < tokens[1]; i++)
{
	stack.Pop();
}

if (stack.Contains(tokens[2]))
{
	Console.WriteLine("true");
}
else if (stack.Any())
{
	Console.WriteLine(stack.Min());
}
else
{
	Console.WriteLine(0);
}

