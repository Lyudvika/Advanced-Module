using EqualityLogic;
public class StartUp
{
    private static void Main(string[] args)
    {
        HashSet<Person> hashSetPeople = new();
        SortedSet<Person> sortedSetPeople = new();

        int inputLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < inputLines; i++)
        {
            string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = personInfo[0];
            int age = int.Parse(personInfo[1]);
            Person person = new(name, age);

            hashSetPeople.Add(person);
            sortedSetPeople.Add(person);
        }

        Console.WriteLine(sortedSetPeople.Count);
        Console.WriteLine(hashSetPeople.Count);
    }
}