using System;

namespace _02.Wild_Farm
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public Mammal(string type, string name, double weight, string livingRegion)
            : base(type, name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion
        {
            get { return this.livingRegion; }
            set { this.livingRegion = value; }
        }

        
    }
}
