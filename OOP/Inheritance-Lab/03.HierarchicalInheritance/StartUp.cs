using Farm;
public class StartUp
{
    private static void Main(string[] args)
    {
        Dog dog = new();
        dog.Eat();
        dog.Bark();

        Cat cat = new();
        cat.Eat();
        cat.Meow();
    }
}