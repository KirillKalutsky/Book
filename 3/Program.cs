using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var author = new Author("Лев", "Толстой", new DateTime(), new DateTime(), new List<Artwork>());
            var artwork = new Artwork() { Name = "Война и мир", Authors = new Author[] {author }, Genre = Genre.Novel };
            author.AddNewArtwork(artwork);
            var b = new Book("Война и мир", new Artwork[] { artwork }, new Release(),  new List<Page>());
            Console.WriteLine(b);
        }
    }
}
