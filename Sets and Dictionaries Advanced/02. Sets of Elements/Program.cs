using System.Collections.Generic;
using System;
using System.Linq;

int[] setsDimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
	.Select(int.Parse).ToArray();
int set1 = setsDimensions[0];
int set2 = setsDimensions[1];

HashSet<int> nums1 = new HashSet<int>();
HashSet<int> nums2 = new HashSet<int>();

for (int i = 1; i <= set1 + set2; i++)
{
	int currNum = int.Parse(Console.ReadLine());
	if (i <= set1)
	{
		nums1.Add(currNum);
	}
	else
	{
		nums2.Add(currNum);
	}
}

List<int> finalNums = new List<int>();
foreach (int num in nums1)
{
	if (nums2.Contains(num))
	{
		finalNums.Add(num);
	}
}
Console.WriteLine(string.Join(" ", finalNums));