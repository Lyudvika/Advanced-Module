using ImplementingCustomStack;

CustomStack customStack = new CustomStack();

customStack.Push(1);
customStack.Push(2);
customStack.Push(3);
//1 2 3

Console.WriteLine(customStack.Peek());
//3

Console.WriteLine(customStack.Pop());
//3 -> now stack is 1 2

customStack.ForEach(x => Console.WriteLine(x));
//1
//2

Console.WriteLine(customStack);
//1 2