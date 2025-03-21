using System.Net.Sockets;

namespace CA2;

public class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        next = null;
    }

}


public class CircularSinlglyLinkedList
{
    private Node tail;
    private int size;

    public CircularSinlglyLinkedList()
    {
        tail = null;
        size = 0;
    }

    public void clear()
    {
        tail = null;
        size = 0;
    }

    public bool isEmpty()
    {
        if (size == 0){
            return true;
        }
        else{
            return false;
        }
    }

    public int getTailValue()
    {
        return tail.data;
    }

    public int getSize()
    {
        return size;
    }

    public bool contains(int data)
    {
        if (tail == null)
        {
            return false;
        }
        
        Node current = tail.next; //Es decir, el primer elemento de la lista.
        while (current != tail)
        {
            if (current.data == data)
            {
                return true;
            }
            current = current.next;
        }

        if (current.data == data)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool add(int data)
    {
        Node newNode = new Node(data);
        if (tail == null)
        {
            newNode.next = newNode;
            tail = newNode;
        }
        else
        {
            newNode.next = tail.next;
            tail.next = newNode;
            tail = newNode;
        }
        size++;
        return true;
    }

    public bool remove(int data)
    {
        if (tail == null)
        {
            return false;
        }
        
        Node current = tail.next;
        Node previous = tail;

        while (current != tail)
        {
            if (current.data == data)
            {
                previous.next = current.next;
                size--;
                return true;
            }
            previous = current;
            current = current.next;
        }

        if (current.data == data)
        {
            if (size == 1)
            {
                tail = null;
            }
            else
            {
                previous.next = current.next;
                if (current == tail)
                {
                    tail = previous;
                }
            }
            size--;
            return true;
        }
        
        return false;

    }

    public string elementsList()
    {
        if (size == 0)
        {
            return "This list is empty";
        }

        if (tail == tail.next)
        {
            return tail.data.ToString();
        }
        
        Node current = tail.next;
        string result = "";

        while (current != tail)
        {
            result += current.data.ToString() + ", ";
            current= current.next;
        }
        result += tail.data.ToString();
        return result;
    }
    



}