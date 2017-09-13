using System.Collections.Generic;
using System.Linq;
using Paw_Inc.Entities.Animals;

namespace Paw_Inc.Entities.Centers
{
    public class AdoptionCenter : Center
    {
        private List<Animal> cleansedAnimals;
        private List<Animal> adoptedAnimals;
        private List<string> adoptionStatistic;

        public AdoptionCenter(string name) 
            : base(name)
        {
            this.cleansedAnimals = new List<Animal>();
            this.adoptedAnimals = new List<Animal>();
            this.adoptionStatistic = new List<string>();
        }

        public IList<string> AdoptionStatistic
        {
            get { return this.adoptionStatistic.AsReadOnly(); }
        }

        public IList<Animal> StoredAnimals
        {
            get { return base.StoredAnimals.AsReadOnly(); }
        }

        public void SendAnimalsForCleansing()
        {
            base.StoredAnimals.Clear();
        }

        public void RecieveCleansedAnimals(List<Animal> animals)
        {
            this.cleansedAnimals.AddRange(animals);
        }

        public void Adopt()
        {
            if (this.cleansedAnimals.Count > 0)
            {
                this.adoptedAnimals.AddRange(this.cleansedAnimals);
                this.adoptionStatistic.AddRange(this.cleansedAnimals.Select(a => a.Name));
                this.cleansedAnimals.Clear();
            }
        }

        public int GetCleansedAnimalsCount()
        {
            return this.cleansedAnimals.Count;
        }
    }
}
