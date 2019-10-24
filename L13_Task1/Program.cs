using System;

namespace L13_Task1
{
    class Program
    {
                
        static void Main(string[] args)
        {
            var song = new
            {
                name = "david bowie",
                length = 200,
                autor = "david bowie",
                date = 1960
            };
            void GetSongData()
            {
                Console.WriteLine($"song: {song.name} length {song.length} date {song.date}");
                
            }
            GetSongData();
        }
    }
}
