namespace _08.Raw_Data
{
    using System.Collections.Generic;

    public class Car
    {
        private string model;
        private List<double> tires = new List<double>();
        private Engine engine;
        private Cargo cargo;

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType
            , double firstTirePressure, int firstTireAge, double secondTirePressure, int secondTireAge,
            double thirdTirePressure, int thirdTireAge, double fourthTirePressure, int fourthTireAge)
        {
            this.model = model;
            this.engine = new Engine(engineSpeed, enginePower);
            this.cargo = new Cargo(cargoWeight, cargoType);
            this.tires.Add(firstTirePressure);
            this.tires.Add(secondTirePressure);
            this.tires.Add(thirdTirePressure);
            this.tires.Add(fourthTirePressure);
        }

        public string CargoType
        {
            get { return this.cargo.CargoType; }
            set { this.cargo.CargoType = value; }
        }

        public List<double> Pressure
        {
            get { return this.tires; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public bool IsCarFragile
        {

            get
            {
                if (this.cargo.CargoType == "fragile")
                {
                    foreach (var tier in this.tires)
                    {
                        if (tier < 1.0)
                        {
                            return true;
                        }
                    }
                }  
                
                return false;
            }
        }

        public bool IsFlamable
        {
            get
            {
                if (this.cargo.CargoType == "flamable" && this.engine.EnginePower > 250)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
