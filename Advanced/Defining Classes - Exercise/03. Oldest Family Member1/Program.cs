using DefiningClasses;

internal class StartUp
{
    private static void Main(string[] args)
    {
        Family family = new Family();

        int countOfPeople = int.Parse(Console.ReadLine());
        for (int i = 0; i < countOfPeople; i++)
        {
            Person person = new Person();

            string[] cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = cmdArg[0];
            int age = int.Parse(cmdArg[1]);

            person.Name = name;
            person.Age = age;

            family.AddMember(person);
        }

        Person olderst = family.GetOldestMember();

        Console.WriteLine(olderst);
    }
}