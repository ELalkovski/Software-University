namespace _14.Cat_Lady
{
    public class CymricCat : Cat
    {
        private double furLength;

        public CymricCat(string name, string type, double furLength)
            : base(name, type)
        {
            this.furLength = furLength;
        }

        public double FurLength
        {
            get { return this.furLength; }
            set { this.furLength = value; }
        }

        public override string ToString()
        {
            return $"{this.Type} {this.Name} {this.FurLength:f2}";
        }
    }
}
