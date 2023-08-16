namespace CustomLinkedList;

public class CoustomDoublyLinkedList
{
    public class ListNode
    {
        //constructors
        public ListNode(int value, ListNode next = null, ListNode previous = null)
        {
            Value = value;
            NextNode = next;
            PreviousNode = previous;
        }

        //properties
        public int Value { get; set; }
        public ListNode NextNode { get; set; }
        public ListNode PreviousNode { get; set; }
    }

    //fields
    private ListNode head;
    private ListNode tail;

    //properties
    public int Count { get; private set; }


    //methods
    public void AddFirst(int value)
    {
        Count++;

        ListNode node = new ListNode(value);
        if (head == null)
        {
            head = node;
            tail = node;
            return;
        }

        node.NextNode = head;
        node.PreviousNode = node;
        head = node;
    }

    public void AddLast(int value)
    {
        Count++;

        ListNode node = new ListNode(value);
        if (tail == null)
        {
            head = node;
            tail = node;
            return;
        }

        node.PreviousNode = tail;
        node.NextNode = node;
        tail = node;
    }

    public int RemoveFirst()
    {
        if (head == null)
        {
            throw new InvalidOperationException("The list is empty");
        }

        int removedElement = head.Value;
        if (head.NextNode == null)
        {
            head = tail = null;
        }
        else
        {
            ListNode oldHead = head;

            head = head.NextNode;
            oldHead.NextNode = null;
            head.PreviousNode = null;
        }

        Count--;
        return removedElement;
    }

    public int RemoveLast()
    {
        if (tail == null)
        {
            throw new InvalidOperationException("The list is empty");
        }

        int removedElement = tail.Value;    
        if (head.NextNode == null)
        {
            head = tail = null;
        }
        else
        {
            ListNode oldTail = tail;

            tail = tail.NextNode;
            oldTail.PreviousNode = null;
            tail.NextNode = null;
        }

        Count--;
        return removedElement;
    }

    public void ForEach(Action<int> action)
    {
        var currNode = head;
        while (currNode != null) 
        {
            action(currNode.Value);
            currNode = currNode.NextNode;
        }
    }

    public int[] ToArray()
    {
        int[] array = new int[Count];
        int count = 0;
        var currNode = head;
        while (currNode != null)
        {
            array[count++] = currNode.Value;
            currNode = currNode.NextNode;
        }
        // or with ForEach(c => arra[count++] = c);

        return array;
    }
}