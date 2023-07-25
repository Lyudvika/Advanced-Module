Dictionary<string,List<decimal>> studentsInfo = new Dictionary<string,List<decimal>>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string studentsName = inputLine[0];
    decimal gradeName = decimal.Parse(inputLine[1]);

    if (!studentsInfo.ContainsKey(studentsName))
    {
        studentsInfo.Add(studentsName, new List<decimal>());
    }
    studentsInfo[studentsName].Add(gradeName);
}

foreach (var student in studentsInfo)
{
    Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(x => $"{x:f2}").ToList())} (avg: {student.Value.Average():f2})");
}