namespace Paw_Inc.Entities.Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private bool cleansingStatus;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.cleansingStatus = false;
        }

        public string Name
        {
            get { return this.name; }
        }

        public void CleanAnimal()
        {
            this.cleansingStatus = true;
        }
    }
}
