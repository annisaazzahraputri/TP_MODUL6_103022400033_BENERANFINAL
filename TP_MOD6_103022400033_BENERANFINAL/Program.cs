using System;

namespace TP_MOD6_103022400033_BENERANFINAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Pengujian Normal ===");
            SayaMusicTrack track1 = new SayaMusicTrack("Lagu Normal");
            track1.IncreasePlayCount(5000);
            track1.PrintTrackDetails();

            Console.WriteLine("=== Pengujian Precondition (title > 100 karakter) ===");
            SayaMusicTrack track2 = new SayaMusicTrack(new string('X', 150));

            Console.WriteLine("=== Pengujian Overflow dengan loop ===");
            SayaMusicTrack track3 = new SayaMusicTrack("Overflow Test");
            for (int i = 0; i < 1000; i++)
            {
                track3.IncreasePlayCount(int.MaxValue / 500);
            }
            track3.PrintTrackDetails();

            Console.ReadLine();
        }
    }
}