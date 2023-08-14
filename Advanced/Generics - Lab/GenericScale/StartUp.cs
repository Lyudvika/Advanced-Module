namespace GenericScale;
public class StartUp
{
    static void Main(string[] args)
    {
        EqualityScale<int> scale = new EqualityScale<int>(56, 5);
        Console.WriteLine(scale.AreEqual());

        EqualityScale<long> longScale = new EqualityScale<long>(5, 5);
        Console.WriteLine(longScale.AreEqual());
    }
}