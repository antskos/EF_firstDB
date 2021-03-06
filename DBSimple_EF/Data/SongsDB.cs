using System.Data.Entity;

namespace DBSimple_EF.Data
{
    public class SongsDB : DbContext
    {

        public SongsDB(string connectionString): base(connectionString) { }

        public SongsDB() : this("name=SongsDB") { }
        public DbSet<Track> Tracks { get; set; }

        public DbSet<Artist> Artists { get; set; }
    }
}
