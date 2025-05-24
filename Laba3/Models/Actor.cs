using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laba3.Models
{
    public class Actor
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        // many-to-many
        public List<MovieActor>? MovieActors { get; set; }
    }
}
