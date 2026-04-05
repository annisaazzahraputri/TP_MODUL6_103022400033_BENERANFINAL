using System;
using System.Diagnostics;

namespace TP_MOD6_103022400033_BENERANFINAL
{
    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            Debug.Assert(title != null, "Judul track tidak boleh null!");

            Debug.Assert(title.Length <= 100, "Judul track maksimal 100 karakter!");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.playCount = 0;
            this.title = title;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Penambahan play count maksimal 10.000.000 per panggilan!");

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"ERROR Overflow: {ex.Message}");
            }
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