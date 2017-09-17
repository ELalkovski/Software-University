using System.Collections.Generic;
using System.Linq;
using _09.Collection_Hierarchy.Interfaces;

namespace _09.Collection_Hierarchy.Entities
{
    public class AddRemoveCollection : IAddable, IRemoveable
    {
        private List<string> collection;

        public AddRemoveCollection()
        {
            this.collection = new List<string>();
        }

        public IList<string> Collection
        {
            get { return collection.AsReadOnly(); }
        }

        public string DispalyIndex
        {
            get { return "0"; }
        }

        public string AddItem(string item)
        {
           this.collection.Insert(0, item);
            return DispalyIndex;
        }

        public string RemoveItem()
        {
            var lastItem = this.collection.LastOrDefault();
            this.collection.RemoveAt(this.collection.Count - 1);
            return lastItem;
        }
    }
}
