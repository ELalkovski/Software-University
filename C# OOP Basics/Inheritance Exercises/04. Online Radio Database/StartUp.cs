using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Online_Radio_Database
{
    public class StartUp
    {
        public static void Main()
        {
            var inputLinesCount = int.Parse(Console.ReadLine());
            var songs = new List<Song>();

            for (int i = 0; i < inputLinesCount; i++)
            {
                try
                {
                    var input = Console.ReadLine();
                    var songInfo = input.Split(new []{';', ':'}, StringSplitOptions.RemoveEmptyEntries);
                    var artist = songInfo[0];
                    var name = songInfo[1];
                    int minutes;
                    int seconds;

                    if (int.TryParse(songInfo[2], out minutes) || int.TryParse(songInfo[3], out seconds))
                    {
                        minutes = int.Parse(songInfo[2]);
                        seconds = int.Parse(songInfo[3]);
                        var currSong = new Song(artist, name, minutes, seconds);
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

            var totalTimeInSecs = songs.Sum(s => s.Minutes) * 60 + songs.Sum(s => s.Seconds);

            var time = TimeSpan.FromSeconds(totalTimeInSecs);

            Console.WriteLine($"Songs added: {songs.Count}");
            Console.WriteLine($"Playlist length: {time.Hours}h {time.Minutes}m {time.Seconds}s");
        }
    }
}
