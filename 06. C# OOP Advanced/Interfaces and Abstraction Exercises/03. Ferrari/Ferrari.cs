namespace _03.Ferrari
{
    public class Ferrari : ICar
    {
        private string model;
        private string driver;

        public Ferrari(string driver)
        {
            this.model = "488-Spider";
            this.driver = driver;
        }

        public string UseBreaks()
        {
            return "Brakes!";
        }

        public string PushGasPedal()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{this.model}/{this.UseBreaks()}/{this.PushGasPedal()}/{this.driver}";
        }
    }
}
