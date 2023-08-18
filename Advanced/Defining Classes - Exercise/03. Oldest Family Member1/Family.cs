namespace DefiningClasses;
public class Family
{
    List<Person> familyMembers = new();

    public void AddMember(Person member)
    {
        familyMembers.Add(member);
    }

    public Person GetOldestMember()
    {
        return familyMembers.OrderByDescending(a => a.Age).First();
    }
}