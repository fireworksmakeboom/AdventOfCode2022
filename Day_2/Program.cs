using System.Reflection;

const int ROCK = 1;
const int PAPER = 2;
const int SCISSORS = 3;
const int LOSS = 0;
const int DRAW = 3;
const int WIN = 6;

string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"input.txt");
int totalPointsPartOne = 0;
int totalPointsPartTwo = 0;

foreach(string line in File.ReadLines(path))
{
	switch (line[0], line[2])
	{
		case ('A', 'X'):
			totalPointsPartOne += DRAW + ROCK;
			totalPointsPartTwo += LOSS + SCISSORS;
			break;
		case ('A', 'Y'):
			totalPointsPartOne += WIN + PAPER;
			totalPointsPartTwo += DRAW + ROCK;
			break;
		case ('A', 'Z'):
			totalPointsPartOne += LOSS + SCISSORS;
			totalPointsPartTwo += WIN + PAPER;
			break;
		case ('B', 'X'):
			totalPointsPartOne += LOSS + ROCK;
			totalPointsPartTwo += LOSS + ROCK;
			break;
		case ('B', 'Y'):
			totalPointsPartOne += DRAW + PAPER;
			totalPointsPartTwo += DRAW + PAPER;
			break;
		case ('B', 'Z'):
			totalPointsPartOne += WIN + SCISSORS;
			totalPointsPartTwo += WIN + SCISSORS;
			break;
		case ('C', 'X'):
			totalPointsPartOne += WIN + ROCK;
			totalPointsPartTwo += LOSS + PAPER;
			break;
		case ('C', 'Y'):
			totalPointsPartOne += LOSS + PAPER;
			totalPointsPartTwo += DRAW + SCISSORS;
			break;
		case ('C', 'Z'):
			totalPointsPartOne += DRAW + SCISSORS;
			totalPointsPartTwo += WIN + ROCK;
			break;
	}
}

Console.WriteLine($"Total Points according to strategy guide part 1: {totalPointsPartOne}");
Console.WriteLine($"Total Points according to strategy guide part 2: {totalPointsPartTwo}");