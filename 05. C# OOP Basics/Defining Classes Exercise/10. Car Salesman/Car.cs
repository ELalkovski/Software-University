namespace _10.Car_Salesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private string weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
        }

        public string Model
        {
            get { return this.model; }
        }

        public Engine Engine
        {
            get { return this.engine; }
        }

        public string Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
    }
}
