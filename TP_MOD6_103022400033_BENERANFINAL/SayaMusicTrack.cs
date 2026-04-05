using System;
using System.Diagnostics; // untuk Debug.Assert

namespace TP_MOD6_103022400033_BENERANFINAL
{
    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.playCount = 0;
            this.title = title;
        }

        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("=== SayaMusicTrack Details ===");
            Console.WriteLine($"ID         : {id}");
            Console.WriteLine($"Title      : {title}");
            Console.WriteLine($"Play Count : {playCount}");
            Console.WriteLine("===============================\n");
        }
    }
}