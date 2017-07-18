namespace _14.Cat_Lady
{
    public class SiameseCat : Cat
    {
        private int earSize;

        public SiameseCat(string name, string type, int earSize)
            : base(name, type)
        {
            this.earSize = earSize;
        }

        public int EarSize
        {
            get { return this.earSize; }
            set { this.earSize = value; }
        }

        public override string ToString()
        {
            return $"{this.Type} {this.Name} {this.EarSize}";
        }
    }
}
