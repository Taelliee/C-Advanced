using System;
using System.Collections.Generic;
using System.Linq;

int foodForTheDay = int.Parse(Console.ReadLine());

Queue<int> orders = new(Console.ReadLine()
	.Split()
	.Select(int.Parse));

Console.WriteLine(orders.Max());
int currOrder = 0;

while(orders.Count > 0)
{
	currOrder = orders.Peek();
	foodForTheDay -= currOrder;

	if (foodForTheDay < 0)
	{
		break;
	}

	orders.Dequeue();
}

if (foodForTheDay >= 0)
{
	Console.WriteLine("Orders complete");
}
else
{
	Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
}