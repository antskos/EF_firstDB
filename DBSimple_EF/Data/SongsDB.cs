using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSimple_EF.Data
{
    public class SongsDB : DbContext
    {
    }

    [Table("Tracks")]
    public class Track
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Duration { get; set; }
    }

    [Table("Artists")]
    public class Artist
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime Birthday { get; set; }
    }
}
