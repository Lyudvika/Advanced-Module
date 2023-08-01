int value = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Func<string, int, bool> checkIfEqual =                                      //checking if the names ascii value is >= than the given input value
    (name, value) => name.Sum(ch => ch) >= value;

Func<string[], int, Func<string, int, bool>, string> getFirstName =
    (names, sum, match) => names.FirstOrDefault(name => match(name, sum));  //getting the first (or default) name that matches the requirement from checkIfEqual

Console.WriteLine(getFirstName(names, value, checkIfEqual));