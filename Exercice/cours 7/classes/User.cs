using System.Collections.Generic;

namespace cours_7.classes
{
    public class User
    {
        public User(string id, string username, string password, List<CreditCard> creditCards, List<int> friendId)
        {
            Id = id;
            Username = username;
            Password = password;
            CreditCards = creditCards;
            FriendId = friendId;
        }

        public string Id { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public List<CreditCard> CreditCards { get; set; } = new();

        public List<int> FriendId { get; set; } = new();

      
    }
}
