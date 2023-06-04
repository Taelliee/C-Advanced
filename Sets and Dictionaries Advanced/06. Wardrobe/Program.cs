using System;
using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < n; i++)
{
	string[] tokens = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
	//string[] tokens = Console.ReadLine().Split(new string[] {" -> ", ","}, StringSplitOptions.RemoveEmptyEntries);
	string color = tokens[0];

	if (!wardrobe.ContainsKey(color))
	{
		wardrobe.Add(color, new Dictionary<string, int>());
	}

	string[] clothes = tokens[1].Split(",");

	for (int j = 0; j < clothes.Length; j++)
	{
		string currPiece = clothes[j];
		if (!wardrobe[color].ContainsKey(currPiece))
		{
			wardrobe[color].Add(currPiece, 0);
		}
		wardrobe[color][currPiece]++;
	}
}

string[] search = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
string searchColor = search[0];
string searchPiece = search[1];
bool isValid = false;

if (wardrobe.ContainsKey(searchColor) && wardrobe[searchColor].ContainsKey(searchPiece))
{
	isValid = true;
}

foreach (var (color, clothes) in wardrobe)
{
    Console.WriteLine($"{color} clothes:");
	if (isValid)
	{
		foreach (var (piece, count) in clothes)
		{
			if (color == searchColor && piece == searchPiece)
			{
                Console.WriteLine($"* {piece} - {count} (found!)");
				isValid = false;
            }
			else
			{
                Console.WriteLine($"* {piece} - {count}");
            }
		}
	}
	else
	{
		foreach (var (piece, count) in clothes)
		{
			Console.WriteLine($"* {piece} - {count}");
		}
	}
}