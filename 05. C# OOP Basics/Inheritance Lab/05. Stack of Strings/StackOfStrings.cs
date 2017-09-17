using System.Collections.Generic;

public class StackOfStrings
{
    private List<string> data;

    public void Push(string item)
    {
        if (this.data.Count != 0)
        {
            this.data.Insert(this.data.Count - 1, item);
        }
        else
        {
            this.data.Add(item);
        }
    }

    public string Pop()
    {
        string poppedString = this.data[this.data.Count - 1];

        if (this.data.Count > 0)
        {
            this.data.RemoveAt(this.data.Count - 1);
        }

        return poppedString;
    }

    public string Peek()
    {
        return this.data[this.data.Count - 1];
    }

    public bool IsEmpty()
    {
        if (this.data.Count > 0)
        {
            return false;
        }

        return true;
    }
}
