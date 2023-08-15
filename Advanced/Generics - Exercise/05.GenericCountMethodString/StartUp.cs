using GenericCountMethodString;

Box<string> box = new Box<string>();

int elementsCount = int.Parse(Console.ReadLine());

for (int i = 0; i < elementsCount; i++)
{
    string item = Console.ReadLine();

    box.Add(item);
}

string itemToCompare = Console.ReadLine();

Console.WriteLine(box.Count(itemToCompare));