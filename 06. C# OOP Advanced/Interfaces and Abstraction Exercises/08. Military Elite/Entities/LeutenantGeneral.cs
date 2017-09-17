namespace _08.Military_Elite.Entities
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;

    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        private List<IPrivate> privates;

        public LeutenantGeneral(string id, string firstName, string lastName, double salary) 
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<IPrivate>();
        }

        public IList<IPrivate> Privates
        {
            get { return privates.AsReadOnly(); }
        }

        public void AddPrivate(Private _private)
        {
            this.privates.Add(_private);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
            sb.AppendLine("Privates:");
            foreach (var soldier in this.privates)
            {
                sb.AppendLine(soldier.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
