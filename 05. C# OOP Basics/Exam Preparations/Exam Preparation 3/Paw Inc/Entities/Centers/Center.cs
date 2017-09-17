namespace Paw_Inc.Entities.Centers
{
    using System.Collections.Generic;
    using Paw_Inc.Entities.Animals;

    public abstract class Center
    {
        private string name;
        private List<Animal> storedAnimals;

        public Center(string name)
        {
            this.name = name;
            this.storedAnimals = new List<Animal>();
        }

        public string Name
        {
            get { return this.name; }
        }

        protected List<Animal> StoredAnimals
        {
            get { return this.storedAnimals; }
        }

        public void RegisterAnimal(Animal animal)
        {
            this.storedAnimals.Add(animal);
        }
    }
}
