namespace DefiningClasses;
public class Person
{
    //fields
    private string name;
    private int age;

    //constructor
    public Person()
    {
        Name = default;
        Age = default;
    }

    //properties
    public string Name { get { return name; } set { name = value; } }
    public int Age { get { return age; } set { age = value; } }
}