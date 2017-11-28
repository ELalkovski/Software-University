namespace _07.Custom_List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class CustomList<T> : ICustomList<T>, IEnumerable<T>
        where T : IComparable<T>
    {
        private static int count;
        private List<T> elements;

        public CustomList() : this(Enumerable.Empty<T>())
        {
        }

        public CustomList(IEnumerable<T> collection)
        {
            this.elements = new List<T>(collection);
        }

        public IList<T> Elements
        {
            get { return this.elements.AsReadOnly(); }
        }

        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public T Remove(int index)
        {
            T element = this.elements[index];
            this.elements.RemoveAt(index);

            return element;
        }

        public bool Contains(T element)
        {
            if (this.elements.Count == 0)
            {
                return false;
            }

            foreach (var currElement in this.elements)
            {
                if (currElement.CompareTo(element) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T temp = this.elements[firstIndex];
            this.elements[firstIndex] = this.elements[secondIndex];
            this.elements[secondIndex] = temp;
        }

        public int CountGreaterThan(T border)
        {
            count = 0;

            foreach (var element in this.elements)
            {
                if (element.CompareTo(border) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public T Max()
        {
            return this.elements.Max();
        }

        public T Min()
        {
            return this.elements.Min();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var element in this.elements)
            {
                sb.AppendLine($"{element}");
            }

            return sb.ToString().Trim();
        }
    }
}



