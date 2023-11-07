namespace ShoppingSpree;

public class Program
{
    private static char[] Splitter = new char[] { '=', ';' };
    private static string EndCommand = "END";
    static void Main(string[] args)
    {
        string[] inputPeople = Console.ReadLine()
            .Split(Splitter, StringSplitOptions.RemoveEmptyEntries);
        string[] inputProduct = Console.ReadLine()
            .Split(Splitter, StringSplitOptions.RemoveEmptyEntries);


        List<Person> people = new List<Person>();
        List<Product> products = new List<Product>();

        try
        {
            for (int i = 0; i < inputPeople.Length; i += 2)
            {
                Person person = new Person(inputPeople[i], decimal.Parse(inputPeople[i + 1]));
                people.Add(person);
            }

            for (int i = 0; i < inputProduct.Length; i += 2)
            {
                Product product = new Product(inputProduct[i], decimal.Parse(inputProduct[i + 1]));
                products.Add(product);
            }

            List<Person> productBough = new List<Person>();

            string command;
            while ((command = Console.ReadLine()) != EndCommand)
            {
                string[] personProduct = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string personName = personProduct[0];
                string productName = personProduct[1];

                Person person = people.FirstOrDefault(p => p.Name == personName);
                Product product = products.FirstOrDefault(p => p.Name == productName);

                if (product != null && person != null)
                {
                    Console.WriteLine(person.Add(product));
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
    }
}