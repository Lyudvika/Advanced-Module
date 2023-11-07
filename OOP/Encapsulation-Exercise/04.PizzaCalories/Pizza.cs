namespace PizzaCalories;

public class Pizza
{
    private readonly List<Topping> toppings;
    private string name;
    private Dough dough;

    public Pizza(string name, Dough dough)
    {
        Name = name;
        Dough = dough;
        toppings = new List<Topping>();
    }
    public string Name
    {
        get => name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            name = value;
        }
    }

    public Dough Dough
    {
        get => dough;
        set => dough = value;
    }

    public void AddTopping(Topping topping)
    {

        if (toppings.Count == 10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
        toppings.Add(topping);
    }
    private double TotalCalories
    {
        get
        {
            double totalCalories = Dough.Calories();

            if (toppings.Any())
            {
                foreach (Topping currTopping in toppings)
                {
                    totalCalories += currTopping.Calories();
                }
            }

            return totalCalories;
        }
    }

    public override string ToString() 
        => $"{name} - {TotalCalories:f2} Calories.";


}