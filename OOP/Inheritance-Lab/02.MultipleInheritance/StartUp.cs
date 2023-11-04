using Farm;
public class StartUp
{
    private static void Main(string[] args)
    {
        Puppy puppy = new();
        puppy.Eat();
        puppy.Bark();
        puppy.Weep();
    }
}