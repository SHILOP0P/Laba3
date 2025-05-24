using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laba3.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string? Title { get; set; }
        public int? Year { get; set; }

        // FK режиссёра
        public int DirectorId { get; set; }
        [ForeignKey(nameof(DirectorId))] public Director? Director { get; set; }

        // many-to-many
        public List<MovieActor>? MovieActors { get; set; }
    }
}
