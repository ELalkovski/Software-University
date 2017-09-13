namespace _14.Cat_Lady
{
    public class Cat
    {
        protected string name;
        protected string type;

        public Cat(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
    }
}
