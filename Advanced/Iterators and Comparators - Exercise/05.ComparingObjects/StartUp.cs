namespace ComparingObjects;

public class StartUp
{
    static void Main(string[] args)
    {
        List<Person> people = new();

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] personInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = personInfo[0];
            int age = int.Parse(personInfo[1]);
            string town = personInfo[2];

            Person person = new(name, age, town);
            people.Add(person);
        }

        int compareIndex = int.Parse(Console.ReadLine()) - 1;

        Person personToCompare = people[compareIndex];

        int equalCount = 0;
        int diffCount = 0;

        foreach (var person in people)
        {
            if (person.CompareTo(personToCompare) == 0)
                equalCount++;
            else
                diffCount++;
        }

        if (equalCount == 1)
            Console.WriteLine("No matches");
        else
            Console.WriteLine($"{equalCount} {diffCount} {people.Count}");
    }
}