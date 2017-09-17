namespace _05.Border_Control
{
    public class Robot : IIdentificationable
    {
        private string model;

        public Robot(string model, string id)
        {
            this.model = model;
            this.Id = id;
        }

        public string Id { get; }

        public bool IsIdFake(string lastDigits)
        {
            if (this.Id.EndsWith(lastDigits))
            {
                return true;
            }

            return false;
        }
    }
}
