namespace _04.Online_Radio_Database
{
    using System;

    public class InvalidSongException : Exception
    {
        private string exceptionMessage = "Invalid song.";

        protected virtual string ExceptionMessage
        {
            set
            {
                this.exceptionMessage = value;
            }
        }

        public override string Message => this.exceptionMessage;
    }
}
