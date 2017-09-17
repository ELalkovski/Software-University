using System.Collections.Generic;
using System.Linq;

public class Box<T>
{
    private List<T> myList;

    public Box()
    {
        this.myList = new List<T>();
    }

    public int Count
    {
        get { return this.myList.Count; }
    }

    public void Add(T element)
    {
        this.myList.Add(element);
    }

    public T Remove()
    {
        T element = this.myList.LastOrDefault();
        this.myList.RemoveAt(this.myList.Count - 1);

        return element;
    }
}
