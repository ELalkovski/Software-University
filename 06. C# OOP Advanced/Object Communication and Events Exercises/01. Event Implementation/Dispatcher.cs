namespace _01.Event_Implementation
{
    public delegate void NameChangeEventHandler(object source, NameChangeEventArgs args);

    public class Dispatcher
    {
        private string name;
        public event NameChangeEventHandler NameChange;

        public string Name
        {
            get { return this.name; }

            set { this.OnNameChange(new NameChangeEventArgs(value));}
        }

        protected void OnNameChange(NameChangeEventArgs args)
        {
            if (NameChange != null)
            {
                NameChange(this, args);
            }
        }
    }
}
