using System;
using System.Linq;

int rows = int.Parse(Console.ReadLine());

int[][] jaggedMatrix = new int[rows][];

for (int row = 0; row < rows; row++)
{
	jaggedMatrix[row] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse).ToArray();
}

string input;
while ((input = Console.ReadLine()) != "End")
{
	string[] line = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
	string command = line[0];
}