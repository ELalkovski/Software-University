namespace _04.Online_Radio_Database
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int inputLinesCount = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < inputLinesCount; i++)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] songInfo = input.Split(new []{';', ':'}, StringSplitOptions.RemoveEmptyEntries);
                    string artist = songInfo[0];
                    string name = songInfo[1];
                    int minutes;
                    int seconds;

                    if (int.TryParse(songInfo[2], out minutes) || int.TryParse(songInfo[3], out seconds))
                    {
                        minutes = int.Parse(songInfo[2]);
                        seconds = int.Parse(songInfo[3]);
                        Song currSong = new Song(artist, name, minutes, seconds);
                        songs.Add(currSong);

                        Console.WriteLine("Song added.");
                    }
                    else
                    {
                        throw new InvalidSongLengthException();
                    }
                }
                catch (Exception ise)
                {
                    Console.WriteLine(ise.Message);
                }
            }

            int totalTimeInSecs = songs.Sum(s => s.Minutes) * 60 + songs.Sum(s => s.Seconds);
            TimeSpan time = TimeSpan.FromSeconds(totalTimeInSecs);

            Console.WriteLine($"Songs added: {songs.Count}");
            Console.WriteLine($"Playlist length: {time.Hours}h {time.Minutes}m {time.Seconds}s");
        }
    }
}
