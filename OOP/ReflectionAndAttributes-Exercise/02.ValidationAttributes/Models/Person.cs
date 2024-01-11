using ValidationAttributes.Attributes;

namespace ValidationAttributes.Models;

public class Person
{
    private const int MinRange = 12;
    private const int MaxRange = 90;
    public Person(string fullName, int age)
    {
        FullName = fullName;
        Age = age;
    }

    [MyRequired]
    public string FullName { get; private set; }

    [MyRange(MinRange, MaxRange)]
    public int Age { get; private set;}
}
