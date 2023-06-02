using System;
using System.Collections.Generic;
using System.Linq;

Queue<string> playlist = new (Console.ReadLine()
	.Split(", "));

while (playlist.Count > 0)
{
	string[] tokens = Console.ReadLine().Split();
	string command = tokens[0];

	switch (command)
	{
		case "Play":
			playlist.Dequeue();
			break;
		case "Add":
			string currSong = string.Join(" ", tokens.Skip(1)); //tokens[1..]
			if (playlist.Contains(currSong))
			{
				Console.WriteLine($"{currSong} is already contained!");
			}
			else
			{
				playlist.Enqueue(currSong);
			}
			break;
		case "Show":
			Console.WriteLine(string.Join(", ", playlist));
			break;
	}
}
Console.WriteLine("No more songs!");