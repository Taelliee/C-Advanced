using System;
using System.Collections.Generic;
using System.Linq;

//5 4 8 6 3 8 7 7 9 clothes
//16 capacity --> 5 racks

Stack<int> clothes = new (Console.ReadLine()
	.Split(' ', StringSplitOptions.RemoveEmptyEntries)
	.Select(int.Parse));

int capacity = int.Parse(Console.ReadLine());
int currCapacity = capacity;
int racks = 1;

while (clothes.Any())
{
	currCapacity -= clothes.Peek();
	if (currCapacity < 0)
	{
		racks++;
		currCapacity = capacity;
		continue;
	}
	clothes.Pop();
}

Console.WriteLine(racks);
