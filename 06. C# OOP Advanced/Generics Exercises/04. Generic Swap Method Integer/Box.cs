namespace _04.Generic_Swap_Method_Integer
{
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
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

        public override string ToString()
        {
            var sb = new StringBuilder();

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



