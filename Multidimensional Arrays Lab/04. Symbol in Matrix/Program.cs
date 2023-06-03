//3
//ABC
//DEF
//X!@

using System;

int squareSide = int.Parse(Console.ReadLine());

char[,] matrix = new char[squareSide, squareSide];

for (int row = 0; row < squareSide; row++)
{
	char[] array = Console.ReadLine().ToCharArray();

	for (int col = 0; col < squareSide; col++)
	{
		matrix[row, col] = array[col];
	}
}

char symbol = char.Parse(Console.ReadLine());

for (int row = 0; row < squareSide; row++)
{
	for (int col = 0; col < squareSide; col++)
	{
		if (matrix[row, col] == symbol)
		{
            Console.WriteLine($"({row}, {col})");
			return;
        }
	}
}
Console.WriteLine($"{symbol} does not occur in the matrix");