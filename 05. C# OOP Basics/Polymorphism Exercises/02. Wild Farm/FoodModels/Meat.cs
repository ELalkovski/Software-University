namespace _02.Wild_Farm
{
    public class Meat : Food
    {
        public Meat(int quantity)
            : base(quantity)
        {          
        }

        public override string GetType()
        {
            return typeof(Meat).Name;
        }
    }
}
