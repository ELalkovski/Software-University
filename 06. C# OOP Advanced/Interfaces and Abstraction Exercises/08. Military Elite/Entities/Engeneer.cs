namespace _08.Military_Elite.Entities
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;

    public class Engeneer : Private, IEngeneer
    {
        private string corps;
        private List<IRepair> reapirs;

        public Engeneer(string id, string firstName, string lastName, double salary, string corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
            this.reapirs = new List<IRepair>();
        }

        public string Corps
        {
            get { return corps; }
            private set
            {
                this.corps = value;
            }
        }

        public IList<IRepair> Reapirs
        {
            get { return reapirs.AsReadOnly(); }
        }

        public void AddRepair(Repair repair)
        {
            this.reapirs.Add(repair);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
            sb.AppendLine($"Corps: {this.corps}");
            sb.AppendLine("Repairs:");
            foreach (var repair in this.reapirs)
            {
                sb.AppendLine(repair.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
