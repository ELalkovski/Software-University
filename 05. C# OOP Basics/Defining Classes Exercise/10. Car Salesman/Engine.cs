namespace _10.Car_Salesman
{
    public class Engine
    {
        private string model;
        private string power;
        private string displacement;
        private string efficiency;

        public Engine(string model, string power)
        {
            this.model = model;
            this.power = power;
        }

        public string Model
        {
            get { return this.model; }
        }

        public string Power
        {
            get { return this.power; }
        }

        public string Displacement
        {
            get { return this.displacement; }
            set { this.displacement = value; }
        }

        public string Efficiency
        {
            get { return this.efficiency; }
            set { this.efficiency = value; }
        }
    }
}
