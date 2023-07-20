string name = Console.ReadLine();
char[] nameToCharArray = name.ToCharArray();        //string to array
Array.Reverse(nameToCharArray);                     //reversing chars in array
string password = new string(nameToCharArray);      //array to string

string entry;
int tries = 0;

while ((entry = Console.ReadLine()) != password)
{
    tries++;
    if (tries == 4)
    {
        Console.WriteLine($"User {name} blocked!");
        break;
    }
    Console.WriteLine("Incorrect password. Try again.");
}
if (entry == password)
{
    Console.WriteLine($"User {name} logged in.");
}