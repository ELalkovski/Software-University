namespace Paw_Inc.Core
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Paw_Inc.Entities.Animals;
    using Paw_Inc.Entities.Centers;

    public class CenterManager
    {
        private Dictionary<string, AdoptionCenter> adoptionCenters;
        private Dictionary<string, CleansingCenter> cleansingCenters;

        public CenterManager()
        {
            this.adoptionCenters = new Dictionary<string, AdoptionCenter>();
            this.cleansingCenters = new Dictionary<string, CleansingCenter>();
        }

        public void RegisterCleansingCenter(string name)
        {
            this.cleansingCenters.Add(name, new CleansingCenter(name));
        }

        public void RegisterAdoptionCenter(string name)
        {
            this.adoptionCenters.Add(name, new AdoptionCenter(name));
        }

        public void RegisterDog(string name, int age, int learnedCommands, string adoptionCenterName)
        {
            Animal dog = new Dog(name, age, learnedCommands);
            this.adoptionCenters[adoptionCenterName].RegisterAnimal(dog);
        }

        public void RegisterCat(string name, int age, int intelligenceCoefficient, string adoptionCenterName)
        {
            Animal cat = new Cat(name, age, intelligenceCoefficient);
            this.adoptionCenters[adoptionCenterName].RegisterAnimal(cat);
        }

        public void SendForCleansing(string adoptionCenterName, string cleansingCenterName)
        {
            AdoptionCenter adoptionCenter = this.adoptionCenters[adoptionCenterName];
            string name = adoptionCenter.Name;

            foreach (var animal in adoptionCenter.StoredAnimals)
            {
                this.cleansingCenters[cleansingCenterName].AddAnimal(name, animal);
            }

            this.adoptionCenters[adoptionCenterName].SendAnimalsForCleansing();
        }

        public void Cleanse(string cleansingCenterName)
        {
            this.cleansingCenters[cleansingCenterName].CleanseAllAnimals();

            foreach (var group in this.cleansingCenters[cleansingCenterName].RecievedAnimals)
            {
                this.adoptionCenters[group.Key].RecieveCleansedAnimals(group.Value);
            }

            this.cleansingCenters[cleansingCenterName].UnRegisterCleansedanimals();
        }

        public void Adopt(string adoptionCenterName)
        {
            this.adoptionCenters[adoptionCenterName].Adopt();
        }

        public string GetAdoptionAndCleansingResults()
        {
            List<string> adoptedNames = new List<string>();
            List<string> cleansedNames = new List<string>();
            StringBuilder sb = new StringBuilder();

            foreach (var center in this.adoptionCenters.Values)
            {
                adoptedNames.AddRange(center.AdoptionStatistic);
            }

            if (adoptedNames.Count > 0)
            {
                sb.AppendLine($"Adopted Animals: {string.Join(", ", adoptedNames.OrderBy(n => n))}");
            }
            else
            {
                sb.AppendLine("Adopted Animals: None");
            }

            foreach (var center in this.cleansingCenters.Values)
            {
                cleansedNames.AddRange(center.CleansedAnimalStatistic);
            }

            if (cleansedNames.Count > 0)
            {
                sb.AppendLine($"Cleansed Animals: {string.Join(", ", cleansedNames.OrderBy(n => n))}");
            }
            else
            {
                sb.AppendLine("Cleansed Animals: None");
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Paw Incorporative Regular Statistics");
            sb.AppendLine($"Adoption Centers: {this.adoptionCenters.Count}");
            sb.AppendLine($"Cleansing Centers: {this.cleansingCenters.Count}");
            sb.Append(this.GetAdoptionAndCleansingResults());

            int animalsAwaitingAdoption = this.adoptionCenters.Sum(a => a.Value.GetCleansedAnimalsCount());
            int animalsAwaitingCleansing = this.cleansingCenters.Sum(c => c.Value.GetUncleansedAnimals());

            sb.AppendLine($"Animals Awaiting Adoption: {animalsAwaitingAdoption}");
            sb.AppendLine($"Animals Awaiting Cleansing: {animalsAwaitingCleansing}");

            return sb.ToString().Trim();
        }
    }
}
