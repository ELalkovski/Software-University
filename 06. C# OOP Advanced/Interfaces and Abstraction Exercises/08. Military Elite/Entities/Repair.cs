namespace _08.Military_Elite.Entities
{
    using _08.Military_Elite.Interfaces;

    public class Repair : IRepair
    {
        private string partName;
        private int workedHours;

        public Repair(string partName, int workedHours)
        {
            this.partName = partName;
            this.workedHours = workedHours;
        }

        public string PartName
        {
            get { return partName; }
        }

        public int WorkedHours
        {
            get { return workedHours; }
        }

        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.WorkedHours}";
        }
    }
}
