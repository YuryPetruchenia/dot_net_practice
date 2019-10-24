using System;

namespace L13_Task1
{
    class Program
    {
                
        static void Main(string[] args)
        {
            Song song1 = new Song();
            song1.Name = "David Bowei - Heroes";
            song1.Length = 210;
            song1.Autor = "David Bowie";
            song1.Date = 1960;

            var song = new
            {
                name = song1.Name,
                length = song1.Length,
                autor = song1.Autor,
                date = song1.Date
            };
            void GetSongData()
            {
                Console.WriteLine($"song: {song.name} length {song.length} date {song.date}");
                
            }
            GetSongData();
        }
    }
}
