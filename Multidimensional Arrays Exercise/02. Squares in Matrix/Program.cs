using System;
using System.Linq;

int[] parameters = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
	.Select(int.Parse).ToArray();
int rows = parameters[0];
int cols = parameters[1];

char[,] matrix = new char[rows, cols];

for (int row = 0; row < rows; row++)
{
	char[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).
		Select(char.Parse).ToArray();
	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = line[col];
	}
}

int countSquares = 0;

for (int row = 0; row < rows - 1; row++)
{
	for (int col = 0; col < cols - 1; col++)
	{
		if (matrix[row, col] == matrix[row, col + 1]
			&& matrix[row, col] == matrix[row + 1, col + 1]
			&& matrix[row, col] == matrix[row + 1, col])
		{
			countSquares++;
		}
	}
}
Console.WriteLine(countSquares);