using System;

namespace cours_7.classes
{
    public class CreditCard
    {
        public string Id { get; set; }

        public int CardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int SecretNumber { get; set; }
    }
}
