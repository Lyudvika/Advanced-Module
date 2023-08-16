using CustomLinkedList;

CoustomDoublyLinkedList list = new();

list.AddFirst(3);
list.AddFirst(2);
list.AddFirst(1);
list.AddLast(4);

Console.WriteLine(list.RemoveFirst());
Console.WriteLine(list.RemoveLast());

int[] arr = list.ToArray();

list.ForEach(x => Console.Write($"{x} "));

Console.WriteLine();
Console.WriteLine(list.Count);