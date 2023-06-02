using System;
using System.Collections.Generic;
using System.Linq;

int n = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>();

for (int i = 0; i < n; i++)
{
	int[] nums = Console.ReadLine()
		.Split()
		.Select(int.Parse)
		.ToArray();

	int command = nums[0];

	//switch is good, too
	if (command == 1)
	{
		int element = nums[1];
		stack.Push(element);
	}
	else if (command == 2)
	{
		stack.Pop();
	}
	else if (command == 3 && stack.Any())
	{
		Console.WriteLine(stack.Max());
	}
	else if (command == 4 && stack.Any())
	{
		Console.WriteLine(stack.Min());
	}
}
//"{n}, {n1}, {n2} …, {nn}"
Console.WriteLine(String.Join(", ", stack));