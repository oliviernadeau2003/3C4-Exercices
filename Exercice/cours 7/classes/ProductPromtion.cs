using System;

namespace cours_7.classes
{
    public class ProductPromtion
    {
        public int id { get; set; }
        public int productId { get; set; }
        public int discount { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
