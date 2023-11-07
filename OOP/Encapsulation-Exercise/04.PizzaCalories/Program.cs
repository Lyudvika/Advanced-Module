namespace PizzaCalories;

public class Program
{
    private const string Splitter = " ";

    static void Main(string[] args)
    {
        try
        {
            string pizzaName = Console.ReadLine().Split(Splitter)[1];

            string[] doughArg = Console.ReadLine().Split(Splitter);
            Dough dough = new(doughArg[1], doughArg[2], double.Parse(doughArg[3]));
            Pizza pizza = new(pizzaName, dough);


            string topping;
            while ((topping = Console.ReadLine()) != "END")
            {
                string[] toppingArg = topping.Split(Splitter);
                Topping toppingIn = new(toppingArg[1], double.Parse(toppingArg[2]));
                pizza.AddTopping(toppingIn);
            }
            Console.WriteLine(pizza);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}