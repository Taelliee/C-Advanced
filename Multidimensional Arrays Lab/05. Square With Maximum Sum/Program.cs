using System;
using System.Linq;

int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = input[0];
int cols = input[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
	int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = array[col];
	}
}

int maxSum = 0;
int maxRowIndex = 0;
int maxColIndex = 0;

for (int row = 0; row < rows - 1; row++) //последните редове/колони не образуват квадрати
{
	for (int col = 0; col < cols - 1; col++)
	{
		int currSum = 0;
		currSum += matrix[row, col];
		currSum += matrix[row, col + 1];
		currSum += matrix[row + 1, col];
		currSum += matrix[row + 1, col + 1];
		if (currSum > maxSum)
		{
			maxSum = currSum;
			maxRowIndex = row;
			maxColIndex = col;
		}
	}
}
Console.WriteLine($"{matrix[maxRowIndex, maxColIndex]} {matrix[maxRowIndex, maxColIndex + 1]}");
Console.WriteLine($"{matrix[maxRowIndex + 1, maxColIndex]} {matrix[maxRowIndex + 1, maxColIndex + 1]}");
Console.WriteLine(maxSum);