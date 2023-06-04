using System;
using System.Linq;

int[] parameters = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
	.Select(int.Parse).ToArray();
int rows = parameters[0];
int cols = parameters[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
	int[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).
		Select(int.Parse).ToArray();
	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = line[col];
	}
}

int maxSum = int.MinValue;
int maxRowIndex = 0;
int maxColIndex = 0;

for (int row = 0; row < rows - 2; row++) //последните 2 редa/колони не образуват 3x3
{
	for (int col = 0; col < cols - 2; col++)
	{
		int currSum = 
			matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
			matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
			matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

		if (currSum > maxSum)
		{
			maxSum = currSum;
			maxRowIndex = row;
			maxColIndex = col;
		}
	}
}

Console.WriteLine($"Sum = {maxSum}");

for (int row = maxRowIndex; row < maxRowIndex + 3; row++)
{
	for (int col = maxColIndex; col < maxColIndex + 3; col++)
	{
		Console.Write(matrix[row, col] + " ");
	}
	Console.WriteLine();
}