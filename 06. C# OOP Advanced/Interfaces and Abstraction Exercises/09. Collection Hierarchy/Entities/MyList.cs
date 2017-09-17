using System;
using System.Collections.Generic;
using System.Linq;
using _09.Collection_Hierarchy.Interfaces;

namespace _09.Collection_Hierarchy.Entities
{
    public class MyList : IAddable, IRemoveable, IUseable
    {
        private List<string> collection;

        public MyList()
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
            var removedItem = this.collection.FirstOrDefault();
            this.collection.RemoveAt(0);
            return removedItem;
        }

        public int Used()
        {
            return this.collection.Count;
        }
    }
}
