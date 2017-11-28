namespace _05.Generic_Count_Method_String
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box<T> where T : IComparable<T>
    {
        private static int count;
        private List<T> elements;

        public Box()
        {
            this.elements = new List<T>();
        }

        public IList<T> Elements
        {
            get { return this.elements.AsReadOnly(); }
        }

        public void AddElement(T element)
        {
            this.elements.Add(element);
        }

        public int GetBiggerValuesCount(T border)
        {
            foreach (var element in this.elements)
            {
                if (element.CompareTo(border) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var element in this.elements)
            {
                sb.AppendLine($"{element.GetType().FullName}: {element}");
            }

            return sb.ToString().Trim();
        }

        public void SwapElements(int firstIndex, int secondIndex)
        {
            T temp = this.elements[firstIndex];
            this.elements[firstIndex] = this.elements[secondIndex];
            this.elements[secondIndex] = temp;
        }
    }
}



