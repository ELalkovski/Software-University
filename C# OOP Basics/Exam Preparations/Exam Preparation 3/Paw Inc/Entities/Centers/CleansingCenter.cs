using System.Collections.Generic;
using System.Linq;
using Paw_Inc.Entities.Animals;

namespace Paw_Inc.Entities.Centers
{
    public class CleansingCenter : Center
    {
        private Dictionary<string, List<Animal>> recievedAnimals;
        private List<string> cleansedAnimalsStatistic;

        public CleansingCenter(string name) : 
            base(name)
        {
            this.recievedAnimals = new Dictionary<string, List<Animal>>();
            this.cleansedAnimalsStatistic = new List<string>();
        }

        public IList<string> CleansedAnimalStatistic
        {
            get { return this.cleansedAnimalsStatistic.AsReadOnly(); }
        }

        public IReadOnlyDictionary<string, List<Animal>> RecievedAnimals
        {
            get { return this.recievedAnimals; }
        }

        public void AddAnimal(string name, Animal animal)
        {
            if (!this.recievedAnimals.ContainsKey(name))
            {
                this.recievedAnimals.Add(name, new List<Animal>());
            }
            this.recievedAnimals[name].Add(animal);
        }

        public void CleanseAllAnimals()
        {
            foreach (var centerGroup in this.recievedAnimals)
            {
                foreach (var animal in centerGroup.Value)
                {
                    animal.CleanAnimal();
                    this.cleansedAnimalsStatistic.Add(animal.Name);
                }
            }
        }

        public void UnRegisterCleansedanimals()
        {
            this.recievedAnimals.Clear();
        }

        public int GetUncleansedAnimals()
        {
            return this.recievedAnimals.Sum(a => a.Value.Count);
        }
    }
}
