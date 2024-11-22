using System.Collections;

namespace MyCollections;

internal class Node<T>
{
  public T Value;
  public Node<T>? Next;
  public Node(T value)
  {
    Value = value;
    Next = null;
  }
}

public class MyList<T> : IEnumerable<T>
{
  private Node<T>? head;
  // private set restricts changes to Count to only this class
  public int Count { get; private set; }
  // array-indexer property => myList[1]
  public T this[int index]
  {
    get
    {
      return this.Get(index);
    }
    set
    {
      this.Set(index, value);
    }
  }
  public MyList()
  {
    Count = 0;
  }
  public void Add(T value)
  {
    if (head is null)
    {
      head = new Node<T>(value);
      Count = 1;
    }
    else
    {
      Node<T> current = head;
      while (current.Next != null)
      {
        current = current.Next;
      }

      current.Next = new Node<T>(value);
      Count++;
    }
  }
  public T Get(int index)
  {
    int count = 0;
    Node<T>? current = head;

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

  public void Set(int index, T value)
  {
    int count = 0;
    Node<T>? current = head;

    while (current != null)
    {
      if (index == count)
      {
        current.Value = value;
        return;
      }
      count++;
      current = current.Next;
    }

    throw new IndexOutOfRangeException();
  }

  public IEnumerator<T> GetEnumerator()
  {
    Node<T>? current = head;

    while (current != null)
    {
      yield return current.Value; // Return current value; remember the current loop iteration
      current = current.Next;
    }
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }
}
