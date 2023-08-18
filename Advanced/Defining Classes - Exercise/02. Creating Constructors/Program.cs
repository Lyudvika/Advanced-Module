using DefiningClasses;

public class StartUp
{
    private static void Main(string[] args)
    {
        Person peter = new Person
        {
            Name = "Peter",
            Age = 20
        };

        Console.WriteLine($"{peter.Name} is {peter.Age} years old.");

        Person george = new Person();
        george.Name = "George";
        george.Age = 18;

        Console.WriteLine($"{george.Name} is {george.Age} years old.");

        Person jose = new Person();
        jose.Name = "Jose";
        jose.Age = 43;

        Console.WriteLine($"{jose.Name} is {jose.Age} years old.");
    }
}