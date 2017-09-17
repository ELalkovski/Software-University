namespace _03.Detail_Printer
{
    using System.Collections.Generic;
    using System.Text;

    public class Manager : Employee
    {
        public Manager(string name, ICollection<string> documents) 
            : base(name)
        {
            this.Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Documents:");

            foreach (var document in this.Documents)
            {
                sb.AppendLine(document);
            }

            return sb.ToString().Trim();
        }
    }
}
