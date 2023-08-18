namespace DefiningClasses;
public class Person
{
    //fields
    private string name;
    private int age;

    //constructor
    public Person()
    {
        Name = "No name";
        Age = 1;
    }

    public Person(int age)
        : this()
    {
        Age = age;
    }

    public Person(string name, int age)
        : this(age)
    {
        Name = name;
    }

    //properties
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public int Age { get { return age; } set { age = value; } }

    //methods
    public override string ToString()       //по-добра практика
    {
        return name + " - " + age;
    }
}