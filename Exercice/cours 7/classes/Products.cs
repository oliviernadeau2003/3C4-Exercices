using System.Collections.Generic;

namespace cours_7.classes
{
    public class Products
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public int PrixInitial { get; set; }

        public string description { get; set; }

        public List<Media> Medias { get; set; } = new();

        public List<int> Categories { get; set; } = new();

        public List<int> Tags { get; set; } = new();

    }
}
