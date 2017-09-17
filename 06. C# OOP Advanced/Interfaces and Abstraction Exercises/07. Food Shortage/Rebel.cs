namespace _07.Food_Shortage
{
    public class Rebel : IBuyer
    {
        private string group;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.group = group;
            this.Food = 0;
        }

        public int Age { get; }

        public string Name { get; }

        public string BirthDate { get; }

        public int Food { get; set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
