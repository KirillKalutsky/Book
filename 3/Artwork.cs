using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class Artwork
    {
        public string Name { get; set; }
        public IEnumerable<Author> Authors { get; set; }
        public DateTime DateOfCreation { get; set; }
        public Genre Genre { get; set; }
    }
}
