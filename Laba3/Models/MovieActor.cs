﻿using System.ComponentModel.DataAnnotations;

namespace Laba3.Models
{
    public class MovieActor
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }

        public int ActorId { get; set; }
        public Actor? Actor { get; set; }

    }
}
