﻿using System;
namespace Fall2024_Assignment3_knlim.Models
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
