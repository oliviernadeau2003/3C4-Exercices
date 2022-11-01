using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Cours06_Dictionary
{
    public class Client
    {
        public int Id { get; init; }
        public string FirstName = string.Empty;
        public string LastName = string.Empty;

        // TODO: afficher dans le format
        // Client #1234 (Bros, Mario)
        public override string ToString()
        {
            return base.ToString();
        }
    }
    public class Transaction
    {
        public int Id { get; init; }
        public int ClientId { get; init; }
        public Dictionary<int, int> ProductIds { get; init; } = new Dictionary<int, int>(); // <Product Id, Count>

        // TODO: afficher dans le format
        // Transaction #1234
        // Client: Bros, Mario
        // Apples x10 300.00$
        // Rice x10 100.00$
        // Total: 400.00$
        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class Product
    {
        public int Id { get; init; }
        public string Name = string.Empty;
        public double Cost = 0;

        // TODO: afficher dans le format
        // Product #1234 (Rice) 7.99$
        public override string ToString()
        {
            return base.ToString();
        }
    }


    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Dictionary<int, Product> Products = new Dictionary<int, Product>()
        {
            { 17, new Product() { Id = 17, Name = "Rice", Cost = 7.99 } },
            { 24, new Product() { Id = 24, Name = "Apples", Cost = 5.99 } },
            { 26, new Product() { Id = 26, Name = "Oatmeal", Cost = 2.99 } },
            { 52, new Product() { Id = 52, Name = "Milk", Cost = 3.99 } },
            { 174, new Product() { Id = 174, Name = "Pogos", Cost = 9.99 } },
        };

        public static Dictionary<int, Client> Clients = new Dictionary<int, Client>()
        {
            { 1980, new Client() { Id = 1983, FirstName = "Pac", LastName = "Man" } },
            { 1983, new Client() { Id = 1983, FirstName = "Mario", LastName = "Bros" } },
            { 1991, new Client() { Id = 1991, FirstName = "Sonic", LastName = "Hedgehog" } },
            { 1993, new Client() { Id = 1993, FirstName = "Doom", LastName = "Guy" } },
            { 1996, new Client() { Id = 1996, FirstName = "Ash", LastName = "Ketchum" } },
            { 2001, new Client() { Id = 2001, FirstName = "Master", LastName = "Chief" } },
            { 2013, new Client() { Id = 2013, FirstName = "Trevor", LastName = "Philips" } },
        };

        public static Dictionary<int, Transaction> Transactions = new Dictionary<int, Transaction>()
        {
            { 37264, new Transaction() { Id = 37264, ClientId = 1993, ProductIds = new Dictionary<int, int>() { { 17, 3 }, { 24, 2 } } } },
            { 38744, new Transaction() { Id = 38744, ClientId = 1996, ProductIds = new Dictionary<int, int>() { { 52, 1 }, { 24, 1 } } } },
            { 21541, new Transaction() { Id = 21541, ClientId = 1996, ProductIds = new Dictionary<int, int>() { { 24, 10 } } } },
            { 84451, new Transaction() { Id = 84451, ClientId = 1993, ProductIds = new Dictionary<int, int>() { { 17, 1 }, { 24, 1 }, { 26, 1 }, { 52, 1 } } } },
            { 98794, new Transaction() { Id = 98794, ClientId = 1996, ProductIds = new Dictionary<int, int>() { { 17, 8 }, { 24, 4 } } } },
            { 87812, new Transaction() { Id = 87812, ClientId = 2013, ProductIds = new Dictionary<int, int>() { { 26, 1 } } } },
            { 87845, new Transaction() { Id = 87845, ClientId = 1993, ProductIds = new Dictionary<int, int>() { { 52, 10 } } } },
            { 89894, new Transaction() { Id = 89894, ClientId = 1996, ProductIds = new Dictionary<int, int>() { { 24, 3 } } } },
            { 15145, new Transaction() { Id = 15145, ClientId = 2013, ProductIds = new Dictionary<int, int>() { { 17, 1 }, { 24, 1 } } } },
        };
    }
}
