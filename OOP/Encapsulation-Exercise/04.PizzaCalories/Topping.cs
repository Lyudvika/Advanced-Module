using System.Xml.Linq;

namespace PizzaCalories;

public class Topping
{
    private const double MeatCalories = 1.2;
    private const double VeggiesCalories = 0.8;
    private const double CheeseCalories = 1.1;
    private const double SauceCalories = 0.9;

    private string toppingType;
    private double weightOfToppings;

    public Topping(string toppingType, double weight)
    {
        ToppingType = toppingType;
        WeightOfToppings = weight;
    }

    public string ToppingType
    {
        set
        {
            if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }

            toppingType = value;
        }
    }
    private double WeightOfToppings
    {
        set
        {
            if (value < 1 || value > 50)
            {
                throw new ArgumentException($"{toppingType} weight should be in the range [1..50].");
            }
            weightOfToppings = value;
        }
    }
    public double GetCalories
    {
        get
        {
            double calories = 2;
            if (toppingType.ToLower() == "meat")
                calories *= MeatCalories;
            else if (toppingType.ToLower() == "veggies")
                calories *= VeggiesCalories;
            else if (toppingType.ToLower() == "cheese") 
                calories *= CheeseCalories;
            else if (toppingType.ToLower() == "sauce") 
                calories *= SauceCalories;

            return calories;
        }
    }
    public double Calories()
        => GetCalories * weightOfToppings;
}

/*public class Topping
{
    private const double Meat = 1.2;
    private const double Veggies = 0.8;
    private const double Cheese = 1.1;
    private const double Sauce = 0.9;

    private string name;
    private double weight;

    public Topping(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }

    private double Weight
    {
        set
        {
            if (value < 1 || value > 50)
            {
                throw new ArgumentException($"{name} weight should be in the range [1..50].");
            }
            weight = value;
        }
    }
    private string Name
    {
        set
        {
            if (value.ToLower() != "meat" &&
               value.ToLower() != "veggies" &&
               value.ToLower() != "cheese" &&
               value.ToLower() != "sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }

            name = value;
        }
    }

    public double GetCalories
    {
        get
        {
            double calories = 2;
            if (name.ToLower() == "meat") { calories *= Meat; }
            else if (name.ToLower() == "veggies") { calories *= Veggies; }
            else if (name.ToLower() == "cheese") { calories *= Cheese; }
            else if (name.ToLower() == "sauce") { calories *= Sauce; }

            return calories;
        }
    }
    public double Calories() => GetCalories * weight;
}*/