using CustomLinkedList;

CoustomDoublyLinkedList<int> list = new();

list.AddFirst(3);
list.AddFirst(2);
list.AddFirst(1);
list.AddLast(4);

Console.WriteLine(list.RemoveFirst());
Console.WriteLine(list.RemoveLast());

int[] arr = list.ToArray();

list.ForEach(x => Console.WriteLine($"{x} "));

Console.WriteLine(list.Count);

CoustomDoublyLinkedList<string> list2 = new();

list2.AddFirst("some");
list2.AddFirst("random");
list2.AddFirst("stings");
list2.AddLast("in");

Console.WriteLine(list.RemoveFirst());
Console.WriteLine(list.RemoveLast());

string[] arr2 = list2.ToArray();

list2.ForEach(x => Console.WriteLine($"{x} "));

Console.WriteLine(list2.Count);