namespace Shapes;

public class StartUp
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(3.1);

        Console.WriteLine(circle.Draw());
    }
}