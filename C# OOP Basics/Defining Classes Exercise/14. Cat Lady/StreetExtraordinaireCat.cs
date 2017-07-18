namespace _14.Cat_Lady
{
    public class StreetExtraordinaireCat : Cat
    {
        private int decibelsOfMeows;

        public StreetExtraordinaireCat(string name, string type, int decibels)
            : base(name, type)
        {
            this.decibelsOfMeows = decibels;
        }

        public int Decibels
        {
            get { return this.decibelsOfMeows; }
            set { this.decibelsOfMeows = value; }
        }

        public override string ToString()
        {
            return $"{this.Type} {this.Name} {this.Decibels}";
        }
    }
}
