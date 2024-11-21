namespace MyCollections;

internal class Node
{
  public int Value;
  public Node? Next;
  public Node(int value)
  {
    Value = value;
    Next = null;
  }
}

public class MyList
{
  private Node? head;

  public void Add(int value)
  {
    if (head is null)
    {
      head = new Node(value);
    }
    else
    {
      Node current = head;
      while (current.Next != null)
      {
        current = current.Next;
      }

      current.Next = new Node(value);
    }
  }

  public int Get(int index)
  {
    int count = 0;
    Node current = head;

    while (current != null)
    {
      if (index == count)
      {
        return current.Value;
      }
      count++;
      current = current.Next;
    }

    throw new IndexOutOfRangeException();
  }
}
