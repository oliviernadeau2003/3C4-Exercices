using System;

namespace cours_7.classes
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string description { get; set; }
        public int rating { get; set; }
        public DateTime ReviewSubmission { get; set; }

    }
}
