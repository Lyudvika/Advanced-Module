using GenericCountMethodDouble;

Box<double> box = new Box<double>();

int elementsCount = int.Parse(Console.ReadLine());

for (int i = 0; i < elementsCount; i++)
{
    double item = double.Parse(Console.ReadLine());

    box.Add(item);
}

double itemToCompare = double.Parse(Console.ReadLine());

Console.WriteLine(box.Count(itemToCompare));