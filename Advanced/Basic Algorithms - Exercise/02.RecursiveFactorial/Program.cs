public class Program
{
    private static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(Factorial(num));

        static long Factorial(int n)
        {
            if (n == 1)
                return 1;

            long nFactorial = Factorial(n - 1);

            return n * nFactorial;
        }
    }
}