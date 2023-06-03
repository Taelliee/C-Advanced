//3					
//1 2 3				
//4 5 6 7			
//8 9 10
//Add 0 0 5			
//Subtract 1 2 2	
//Subtract 1 4 7	
//END				

using System;
using System.Linq;

int rows = int.Parse(Console.ReadLine());

int[][] matrix = new int[rows][];

for (int i = 0; i < rows; i++)
{
	matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
}

string input;

while ((input = Console.ReadLine()) != "END")
{
	string[] tokens = input.Split().ToArray();
	string command = tokens[0];
	int row = int.Parse(tokens[1]);
	int col = int.Parse(tokens[2]);
	int value = int.Parse(tokens[3]);

	if ( row < 0 || col < 0 || rows - 1 < row || matrix[row].Length - 1 < col )
	{
        Console.WriteLine("Invalid coordinates");
    }
	else if (command == "Add")
	{
		matrix[row][col] += value;
	}
	else if (command == "Subtract")
	{
		matrix[row][col] -= value;
	}
}

foreach (int[] row in matrix)
{
	Console.WriteLine(string.Join(" ", row));
}