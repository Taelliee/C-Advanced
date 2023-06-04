using System;
using System.Linq;

int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
	.Select(int.Parse).ToArray();
int rows = dimensions[0];
int cols = dimensions[1];

char[,] matrix = new char[rows, cols];
string snake = Console.ReadLine();

int currIndex = 0;

for (int row = 0; row < rows; row++)
{
	if (row % 2 == 0)
	{
		for (int col = 0; col < cols; col++)
		{
			if (currIndex == snake.Length)
			{
				currIndex = 0;
			}

			matrix[row, col] = snake[currIndex];
			currIndex++;
		}
	}
	else
	{
		for (int col = cols - 1; col >= 0; col--)
		{
			if (currIndex == snake.Length)
			{
				currIndex = 0;
			}

			matrix[row, col] = snake[currIndex];
			currIndex++;
		}
	}
}

for (int row = 0; row < rows; row++)
{
	for (int col = 0; col < cols; col++)
	{
		Console.Write(matrix[row, col]);
	}
	Console.WriteLine();
}
