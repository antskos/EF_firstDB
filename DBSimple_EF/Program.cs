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
                var tracks_count = db.Tracks.Count();
                Console.WriteLine($"В БД {tracks_count} песен");
            }

            Console.ReadLine();
        }
    }
}
