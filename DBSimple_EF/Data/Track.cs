using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBSimple_EF.Data
{
    [Table("Tracks")]
    public class Track
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Duration { get; set; }
    }
}
