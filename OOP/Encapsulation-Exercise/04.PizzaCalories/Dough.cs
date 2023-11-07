namespace PizzaCalories;

public class Dough
{
    private const double WhiteCaloriesPerGram = 1.5;
    private const double WholegrainCaloriesPerGram = 1.0;
    private const double CrispyCaloriesPerGram = 0.9;
    private const double ChewyCaloriesPerGram = 1.1;
    private const double HomemadeCaloriesPerGram = 1.0;

    public string flourType;
    public string bakingTechnique;
    public double doughWeigh;

    public Dough(string flourType, string bakingTechnique, double grams)
    {
        FlourType = flourType;
        BakingTechnique =  bakingTechnique;
        DoughWeigh = grams;
    }

    public string FlourType
    {
        set
        {
            if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            flourType = value;
        }
    }
    public string BakingTechnique
    {
        set
        {
            if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            bakingTechnique = value;
        }
    }
    public double DoughWeigh
    {
        set
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }

            doughWeigh = value;
        }
    }

    public double GetCalories
    {
        get
        {
            double calories = 2.0;

            if (flourType.ToLower() == "white")
                calories *= WhiteCaloriesPerGram;
            else if (flourType.ToLower() == "wholegrain")
                calories *= WholegrainCaloriesPerGram;

            if (bakingTechnique.ToLower() == "crispy")
                calories *= CrispyCaloriesPerGram;
            else if (bakingTechnique.ToLower() == "chewy")
                calories *= ChewyCaloriesPerGram;
            else if (bakingTechnique.ToLower() == "homemade")
                calories *= HomemadeCaloriesPerGram;

            return calories;
        }
    }

    public double Calories() => doughWeigh * GetCalories;
}