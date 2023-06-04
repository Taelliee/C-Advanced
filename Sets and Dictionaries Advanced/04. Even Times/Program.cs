using System;
using System.Collections.Generic;

Dictionary<int, int> nums =  new Dictionary<int, int>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
	int currNum = int.Parse(Console.ReadLine());

	if (!nums.ContainsKey(currNum))
	{
		nums.Add(currNum, 0);
	}
	nums[currNum]++;
}

foreach (var num in nums)
{
	if (num.Value % 2 == 0)
	{
        Console.WriteLine(num.Key);
        break;
	}
}