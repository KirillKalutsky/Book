using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    public class Book
    {
        public string Name { get; set; }
        public IEnumerable<Artwork> Artworks { get; set; }
        public Release Release { get; set; }

        private IEnumerable<Page> content;

        private JsonSerializerSettings jsonsettings = new JsonSerializerSettings
        {
            PreserveReferencesHandling = PreserveReferencesHandling.Objects
        };

        public Book(string name, IEnumerable<Artwork> artworks, Release release, IEnumerable<Page> pages)
        {
            Name = name;
            Artworks = artworks;
            Release = release;
            content = pages;
        }

        public Page FindPageByNumber(int number)
        {
            return content
                .Where(page => page.Number == number)
                .FirstOrDefault();
        }

        public IEnumerable<Page> Read()
        {
            var sortedContent = content.OrderBy(page => page.Number);
            foreach (var page in sortedContent)
                yield return page;
        }

        public int GetPageCount()
        {
            return content == null ? 0 : content.Count();
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, jsonsettings);
        }
    }
}
