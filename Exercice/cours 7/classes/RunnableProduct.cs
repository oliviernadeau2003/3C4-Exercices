using System.Collections.Generic;

namespace cours_7.classes
{
    public class RunnableProduct : Products
    {
        public List<int> SuportedPlatforms { get; set; } = new();
        public List<int> langues { get; set; } = new();
        public Spec RecommendedSpecs { get; set; }
        public Spec MinimumSpecs { get; set; }

    }
}
