using System;

namespace DefiningClasses;
public class Family
{
    List<Person> familyMembers = new();

    public void AddMember(Person member)
    {
        familyMembers.Add(member);
    }

    public List<Person> GetOldestMember()
    {
        return familyMembers.OrderBy(a => a.Name).Where(a => a.Age > 30).ToList();
    }
}