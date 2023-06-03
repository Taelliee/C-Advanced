using System;
using System.Linq;

//3
//11 2 4
//4 5 6
//10 8 - 12

int squareSide = int.Parse(Console.ReadLine());

int[,] matrix = new int[squareSide, squareSide];

for (int row = 0; row < squareSide; row++)
{
	int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

	for (int col = 0; col < squareSide; col++)
	{
		matrix[row, col] = array[col];
    }
}

int sumDiagonal = 0;

for (int i = 0; i < squareSide; i++)
{
	sumDiagonal += matrix[i, i];
}
Console.WriteLine(sumDiagonal);