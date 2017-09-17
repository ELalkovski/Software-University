namespace _03BarracksFactory.Core.Commands
{
    using Attributes;
    using Contracts;

    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data) 
            : base(data)
        {
        }

        public IRepository Repository
        {
            get { return this.repository; }
            private set { this.repository = value; }
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            this.repository.RemoveUnit(unitType);

            return $"{unitType} retired!";
        }
    }
}
