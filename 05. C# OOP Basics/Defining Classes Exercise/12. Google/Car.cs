namespace _12.Google
{
    public class Car
    {
        private string model;
        private double speed;

        public Car(string model, double speed)
        {
            this.model = model;
            this.speed = speed;
        }

        public Car()
        {
            
        }

        public string Model
        {
            get { return this.model; }
        }

        public double Speed
        {
            get { return this.speed; }
        }
    }
}
