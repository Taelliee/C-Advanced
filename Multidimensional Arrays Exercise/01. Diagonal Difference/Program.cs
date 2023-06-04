using System;
using System.Linq;

int parameter = int.Parse(Console.ReadLine());

int[,] matrix = new int[parameter, parameter];

for (int row = 0; row < parameter; row++)
{
	int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

	for (int col = 0; col < parameter; col++)
	{
		matrix[row, col] = line[col];
    }
}

int sumPrimary = 0;
int sumSecondary = 0;


for (int i = 0; i < parameter; i++)
{
	sumPrimary += matrix[i, i];
	sumSecondary += matrix[i, parameter - i - 1];
}

Console.WriteLine(Math.Abs(sumPrimary - sumSecondary));