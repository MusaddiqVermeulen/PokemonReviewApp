﻿namespace PokemonReviewApp.Models
{
    public class PokemonOwner
    {
        public int PokemonId { get; set; }
        public int OwnerId { get; set;}
        public Pokemon Pokemon { get; set; }  // one-to-many relationship
        public Owner Owner { get; set; }


    }
}
