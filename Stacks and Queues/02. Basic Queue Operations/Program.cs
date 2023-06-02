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

Queue<int> queue = new(numbers);

for (int i = 0; i < tokens[1]; i++)
{
	queue.Dequeue();
}

if (queue.Contains(tokens[2]))
{
	Console.WriteLine("true");
}
else if (queue.Any())
{
	Console.WriteLine(queue.Min());
}
else
{
	Console.WriteLine(0);
}