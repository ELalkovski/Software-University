namespace _07.Custom_List
{
    using System;
    using System.Linq;

    public static class Sorter
    {
        public static CustomList<T> Sort<T>(CustomList<T> list)
            where T : IComparable<T>
        {
            IOrderedEnumerable<T> temp = list.Elements.OrderBy(e => e);

            return new CustomList<T>(temp);
        }
    }
}
