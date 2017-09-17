namespace _04.Online_Radio_Database
{
    public class Song
    {
        private string artist;
        private string name;
        private int minutes;
        private int seconds;

        public Song(string artist, string name, int minutes, int seconds)
        {
            this.Artist = artist;
            this.Name = name;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public int Seconds
        {
            get
            {
                return this.seconds;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }
                this.seconds = value;
            }
        }

        public int Minutes
        {
            get
            {
                return this.minutes;
            }
            set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }
                this.minutes = value;
            }
        }

        public string Name
        {
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }
                this.name = value;
            }
        }

        public string Artist
        {
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }
                this.artist = value;
            }
        }
    }
}
