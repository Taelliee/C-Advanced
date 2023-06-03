using System;

int rows = int.Parse(Console.ReadLine());

long[][] pascalTriangle = new long[rows][];

pascalTriangle[0] = new long[1] { 1 };

for (int row = 1; row < rows; row++)
{
	pascalTriangle[row] = new long[row + 1];

	for (int col = 0; col <= row; col++)
	{
		if (pascalTriangle[row - 1].Length > col)
		{
			pascalTriangle[row][col] += pascalTriangle[row - 1][col];
		}

		if (col > 0)
		{
			pascalTriangle[row][col] += pascalTriangle[row - 1][col - 1];
		}
	}
}

foreach (long[] row in pascalTriangle)
{
	Console.WriteLine(string.Join(" ", row));
}