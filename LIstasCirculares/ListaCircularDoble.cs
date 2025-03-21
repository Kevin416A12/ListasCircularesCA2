namespace LIstasCirculares;

public class DoublyCircularLinkedList<T>
{
    private class Node
    {
        public T Data;
        public Node Next;
        public Node Prev;
        public Node(T data) { Data = data; }
    }

    private Node head;
    private int count;

    public void InsertAtStart(T data)
    {
        Node node = new Node(data);
        if (head == null)
        {
            node.Next = node;
            node.Prev = node;
            head = node;
        }
        else
        {
            Node tail = head.Prev;
            node.Next = head;
            node.Prev = tail;
            head.Prev = node;
            tail.Next = node;
            head = node;
        }
        count++;
    }

    public void InsertAtEnd(T data)
    {
        if (head == null) InsertAtStart(data);
        else
        {
            Node node = new Node(data);
            Node tail = head.Prev;
            node.Next = head;
            node.Prev = tail;
            tail.Next = node;
            head.Prev = node;
            count++;
        }
    }

    public void InsertAt(T data, int index)
    {
        if (index < 0 || index > count) throw new ArgumentOutOfRangeException();
        if (index == 0) InsertAtStart(data);
        else if (index == count) InsertAtEnd(data);
        else
        {
            Node current = head;
            for (int i = 0; i < index; i++) current = current.Next;
            Node node = new Node(data)
            {
                Next = current,
                Prev = current.Prev
            };
            current.Prev.Next = node;
            current.Prev = node;
            count++;
        }
    }

    public void RemoveAtStart()
    {
        if (head == null) throw new InvalidOperationException();
        if (count == 1) head = null;
        else
        {
            Node tail = head.Prev;
            head = head.Next;
            head.Prev = tail;
            tail.Next = head;
        }
        count--;
    }

    public void RemoveAtEnd()
    {
        if (head == null) throw new InvalidOperationException();
        if (count == 1) head = null;
        else
        {
            Node tail = head.Prev;
            tail.Prev.Next = head;
            head.Prev = tail.Prev;
        }
        count--;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= count) throw new ArgumentOutOfRangeException();
        if (index == 0) RemoveAtStart();
        else if (index == count - 1) RemoveAtEnd();
        else
        {
            Node current = head;
            for (int i = 0; i < index; i++) current = current.Next;
            current.Prev.Next = current.Next;
            current.Next.Prev = current.Prev;
            count--;
        }
    }

    public int Size() => count;

    public override string ToString()
    {
        if (head == null) return string.Empty;
        var result = new List<string>();
        Node current = head;
        do
        {
            result.Add(current.Data.ToString());
            current = current.Next;
        } while (current != head);
        return string.Join(", ", result);
    }
}

class program
{
    
    static void Main()
    {
        
    }
}
