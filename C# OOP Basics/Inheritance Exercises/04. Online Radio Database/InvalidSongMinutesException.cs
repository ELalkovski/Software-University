﻿namespace _04.Online_Radio_Database
{
    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        public override string Message => "Song minutes should be between 0 and 14.";
    }
}
