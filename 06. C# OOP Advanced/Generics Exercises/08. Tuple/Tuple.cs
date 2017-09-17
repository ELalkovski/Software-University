namespace _08.Tuple
{
    public class Tuple<T1, T2>
    {
        private T1 firstItem;
        private T2 secondItem;

        public Tuple(T1 firstItem, T2 secondItem)
        {
            this.firstItem = firstItem;
            this.secondItem = secondItem;
        }

        public T1 FirstItem
        {
            get { return this.firstItem; }
        }

        public T2 SecondItem
        {
            get { return this.secondItem; }
        }

        public override string ToString()
        {
            return $"{this.firstItem} -> {this.secondItem}";
        }
    }
}
