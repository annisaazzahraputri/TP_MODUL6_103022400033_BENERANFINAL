using System;

namespace TP_MOD6_103022400033_BENERANFINAL
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaMusicTrack track = new SayaMusicTrack("Taylor Swift – exile feat. Bon Iver");

            track.PrintTrackDetails();

            track.IncreasePlayCount(100);
            track.PrintTrackDetails();

            track.IncreasePlayCount(50);
            track.PrintTrackDetails();

            Console.ReadLine();
        }
    }
}