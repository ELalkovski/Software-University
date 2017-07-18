using System;
using System.Runtime.CompilerServices;

namespace _04.Online_Radio_Database
{
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
