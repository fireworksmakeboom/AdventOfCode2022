using System.Reflection;

string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Input.txt");
string[] input = File.ReadAllLines(path);

List<int> elfList = new List<int>();
int elfCalories = 0;

foreach (string line in input)
{
	if(!string.IsNullOrEmpty(line))
	{
		elfCalories += Convert.ToInt32(line);
	}
	else
	{
		elfList.Add(elfCalories);
		elfCalories = 0;
	}
}
elfList.Sort((a,b) => b.CompareTo(a));

int combinedTop3 = 0;
Console.WriteLine("Top 3 Elves are:");
for(int i = 0; i < 3; i++)
{
	Console.WriteLine($"{i + 1}. Place: {elfList[i]} calories");
	combinedTop3 += elfList[i];
}
Console.WriteLine($"Combined they have: {combinedTop3} calories");