using DBSimple_EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSimple_EF
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new SongsDB())
            {
                for (int i = 0; i < 7; i++)
                {
                    var artist = new Artist
                    {
                        Name = $"Artist name {i}",
                        Birthday = DateTime.Now.Subtract(TimeSpan.FromDays(36 * i))

                    };
                    artist.Tracks = new List<Track>();

                    for (int j = 0; j < 5; j++)
                    {
                        var track = new Track
                        {
                            Name = $"Track {i + 2 * j}",
                            Duration = j * 32
                        };

                        artist.Tracks.Add(track);
                    }
                    db.Artists.Add(artist);
                }

                db.SaveChanges();
            }

            using (var db = new SongsDB())
            {
                db.Database.Log = msg => Console.WriteLine("EF : {0}\r\n---------------", msg);

                var tracks_count = db.Tracks.Count();
                Console.WriteLine($"В БД {tracks_count} песен");
            }

            Console.ReadLine();
        }
    }
}
