namespace _07.Food_Shortage
{
    public class Citizen : IIdentificationable, IBuyer
    {
        public Citizen(string name, int age, string id, string birthDate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthDate;
            this.Food = 0;
        }
        public string Name { get; }

        public int Age { get; }

        public string Id { get; }

        public string BirthDate { get; }

        public int Food { get; set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    
        public bool IsIdFake(string lastDigits)
        {
            return false;
        }      
    }
}
