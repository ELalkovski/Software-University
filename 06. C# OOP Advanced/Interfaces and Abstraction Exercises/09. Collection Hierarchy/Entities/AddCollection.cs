namespace _09.Collection_Hierarchy.Entities
{
    using Interfaces;
    using System.Collections.Generic;

    public class AddCollection : IAddable
    {
        private static int index;

        private List<string> collection;

        public AddCollection()
        {
            this.collection = new List<string>();
            index = 0;
        }

        public IList<string> Collection
        {
            get { return collection.AsReadOnly(); }
        }

        public string AddItem(string item)
        {
            this.collection.Add(item);
            var displayIndex = index.ToString();
            index++;
            return displayIndex;
        }
    }
}
