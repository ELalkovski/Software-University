using System;
using System.Linq;

namespace _07.Custom_List
{
    public static class Sorter
    {
        public static CustomList<T> Sort<T>(CustomList<T> list)
            where T : IComparable<T>
        {
            var temp = list.Elements.OrderBy(e => e);

            return new CustomList<T>(temp);
        }
    }
}
