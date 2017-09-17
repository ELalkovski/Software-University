namespace _08.Military_Elite.Entities
{
    using System.Collections.Generic;
    using Interfaces;
    using System.Text;

    public class Commando : Private, ICommando
    {
        private string corps;
        private List<IMission> missions;

        public Commando(string id, string firstName, string lastName, double salary, string corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
            this.missions = new List<IMission>();
        }

        public string Corps
        {
            get { return corps; }
            private set { this.corps = value; }
        }

        public IList<IMission> Missions
        {
            get { return missions.AsReadOnly(); }
        }

        public void AddMission(Mission mission)
        {
            this.missions.Add(mission);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
            sb.AppendLine($"Corps: {this.corps}");
            sb.AppendLine("Missions:");
            foreach (var mission in this.missions)
            {
                sb.AppendLine(mission.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
