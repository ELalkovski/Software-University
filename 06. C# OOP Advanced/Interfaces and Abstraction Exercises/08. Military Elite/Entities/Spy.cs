namespace _08.Military_Elite.Entities
{
    using _08.Military_Elite.Interfaces;
    using System.Text;

    public class Spy : Soldier, ISpy
    {
        private int codeNumber;

        public Spy(string id, string firstName, string lastName, int codeNumber) 
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber
        {
            get { return this.codeNumber; }
            private set { this.codeNumber = value; }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");
            sb.Append($"Code Number: {this.CodeNumber}");

            return sb.ToString();
        }
    }
}
