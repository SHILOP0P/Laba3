namespace Laba3.Models
{
    public class Director
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        // один режиссёр — много фильмов
        public List<Movie>? Movies { get; set; }
    }
}
