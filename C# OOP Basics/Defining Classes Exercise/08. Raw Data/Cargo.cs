namespace _08.Raw_Data
{
    public class Cargo
    {
        private int cargoWeight;
        private string cargoType;


        public int CargoWeight
        {
            get { return this.cargoWeight; }
            set { this.cargoWeight = value; }
        }
        public string CargoType
        {
            get { return this.cargoType; }
            set { this.cargoType = value; }
        }

        public Cargo(int cargoWeight, string cargoType)
        {
            this.cargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }
    }
}
