using System;
using System.Collections.Generic;

namespace _3
{
    public class Author : Person
    {
        public Author(string name, string surname, DateTime dateOfBirth, DateTime? dateOfDeath, List<Artwork> artworks)
            :base(name, surname, dateOfBirth, dateOfDeath)
        {
            Artworks = artworks;
        }

        public void AddNewArtwork(Artwork artwork)
        {
            Artworks.Add(artwork);
        }
        public List<Artwork> Artworks { get; set; }
    }
}