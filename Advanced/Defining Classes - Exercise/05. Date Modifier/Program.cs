using DefiningClasses;
public class StartUp
{
    static void Main(string[] args)
    {
        DateModifier dateModifier = new DateModifier();
        string startDate = Console.ReadLine();
        string endDate = Console.ReadLine();


        Console.WriteLine(dateModifier.GetDifferenceInDays(startDate, endDate));
    }
}