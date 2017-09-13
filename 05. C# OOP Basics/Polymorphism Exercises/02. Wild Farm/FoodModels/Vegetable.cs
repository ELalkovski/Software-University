namespace _02.Wild_Farm
{
    public class Vegetable : Food
    {
        public Vegetable(int quantity)
            : base(quantity)
        {
        }

        public override string GetType()
        {
            return typeof(Vegetable).Name;
        }
    }
}
