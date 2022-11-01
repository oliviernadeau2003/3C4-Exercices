using System;

namespace WpfApp1.Classes
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
