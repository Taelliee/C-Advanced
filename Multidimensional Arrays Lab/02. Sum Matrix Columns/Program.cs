//3, 6
//7 1 3 3 2 1
//1 3 9 8 5 6
//4 6 7 9 1 0

using System;
using System.Linq;

int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = input[0];
int cols = input[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
	int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = array[col];
	}
}

for (int col = 0; col < cols; col++)
{
	int sumCol = 0;

	for (int row = 0; row < rows; row++)
	{
		sumCol += matrix[row, col];
	}
	Console.WriteLine(sumCol);
}