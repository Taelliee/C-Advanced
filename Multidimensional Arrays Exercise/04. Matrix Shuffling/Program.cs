using System;
using System.Linq;

int[] parameters = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
	.Select(int.Parse).ToArray();
int rows = parameters[0];
int cols = parameters[1];

string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
	string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
		.ToArray();
	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = line[col];
	}
}

string input;

while ((input = Console.ReadLine()) != "END")
{
	string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
	string command = tokens[0];

	if (command != "swap" || tokens.Length != 5)
	{
        Console.WriteLine("Invalid input!");
    }
	else
	{
		int row1 = int.Parse(tokens[1]);
		int col1 = int.Parse(tokens[2]);
		int row2 = int.Parse(tokens[3]);
		int col2 = int.Parse(tokens[4]);

		if (rows <= row1 || rows <= row1 || cols <= col1 || cols <= col2)
		{
			Console.WriteLine("Invalid input!");
		}
		else
		{
			string temp = matrix[row1, col1];
			matrix[row1, col1] = matrix[row2, col2];
			matrix[row2, col2] = temp;
			PrintMatrix(matrix);
		}
	}
}

static void PrintMatrix(string[,] matrix)
{
	for (int row = 0; row < matrix.GetLength(0); row++)
	{
		for (int col = 0; col < matrix.GetLength(1); col++)
		{
			Console.Write(matrix[row, col] + " ");
		}
		Console.WriteLine();
	}
}