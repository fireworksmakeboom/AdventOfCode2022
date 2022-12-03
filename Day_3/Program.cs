using System.Reflection;

string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"input.txt");

Console.WriteLine($"Total priority part one is: {PartOne(path)}");
Console.WriteLine($"Total priority part two is: {PartTwo(path)}");

int PartOne(string path)
{
	int priority = 0;

	foreach (string line in File.ReadAllLines(path))
	{
		string firstCompartment = line.Substring(0, line.Length / 2);
		string secondCompartment = line.Substring(line.Length / 2);
		foreach (char itemType in firstCompartment)
		{
			if (secondCompartment.Contains(itemType))
			{
				if (char.IsLower(itemType))
				{
					priority += (int)itemType - 96;
				}
				else
				{
					priority += (int)itemType - 38;
				}
				break;
			}
		}
	}
	return priority;
}

int PartTwo(string path)
{
	int priority = 0;
	string[] lines = File.ReadAllLines(path);

	for(int i = 0; i < lines.Length; i += 3)
	{
		foreach(char itemType in lines[i])
		{
			if (lines[i + 1].Contains(itemType) && lines[i + 2].Contains(itemType))
			{
				if (char.IsLower(itemType))
				{
					priority += (int)itemType - 96;
				}
				else
				{
					priority += (int)itemType - 38;
				}
				break;
			}
		}
	}

	return priority;
}