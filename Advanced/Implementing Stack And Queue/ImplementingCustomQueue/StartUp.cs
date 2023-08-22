using ImplementingCustomQueue;

CustomQueue customQueue = new CustomQueue();

customQueue.Enqueue(1);
customQueue.Enqueue(2);
customQueue.Enqueue(3);
//1 2 3

customQueue.Dequeue();
//2 3

Console.WriteLine(customQueue.Peek());
//2

customQueue.ForEach(x => Console.WriteLine(x));
//2
//3

customQueue.Clear();
//empty

Console.WriteLine(customQueue);