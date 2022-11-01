using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using cours_7.classes;

// Écrire une commande Linq (ex: dataList.Max() et faire Ctrl+. Enter sur le .Max pour importer
using System.Linq;

namespace Cours07
{
    public class Data
    {
        public int Id;
        public List<int> Numbers = new List<int>();
    }

    public class Screenshot
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public Media Image { get; set; }
    }

    public class Guide
    {
        public int Id { get; set; }
        public string titre { get; set; }

        public Media ImagePrincipale { get; set; }

        List<Section> Sections { get; set; } = new();
    }

    public class section : Guide
    {
        public int SectionId { get; set; }
        public string Titre { get; set; }
        public List<Media> Images { get; set; } = new();
    }

    public class Community
    {
        public int Id { get; set; }
        public List<int> ForumList { get; set; } = new();

    }

    public class Forum
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public List<Thread> ThreadList { get; set; } = new();
        public List<int> ModList { get; set; } = new();

        private int GetAdmin(int id)
        {
            var resultFirstOrDefault = ModList.FirstOrDefault(x => x == id);
           if (resultFirstOrDefault != null)
            {
                return Id;
            }
            return 0;
        }

        private List GetMostRecent()
        {
            var result = ThreadList.Min(x => x.FirstUploadTime);
            return ;
        }

    }

        public class Thread
        {
            public int Id { get; set; }
            public DateTime LastUploadTime { get; set; }
            public DateTime FirstUploadTime { get; set; }
            public List<ThreadPost> threadPosts { get; set; } = new();
        }

        public class ThreadPost
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public Media UserPicture { get; set; }
            public DateTime UploadTime { get; set; }
            public string Titre { get; set; }
            public string Content { get; set; }
            public List<Media> JointDocument { get; set; }
        }

        public partial class MainWindow : Window
        {
            public List<Data> dataList = new List<Data>()
            {
            new Data() { Id = 1, Numbers = new List<int>() { 41, 34 } },
            new Data() { Id = 200, Numbers = new List<int>() { 1 } },
            new Data() { Id = 1100, Numbers = new List<int>() { 34, 31, 37 } },
            new Data() { Id = 2000, Numbers = new List<int>() { 10 } },
            new Data() { Id = 300, Numbers = new List<int>() { 75 } },
            new Data() { Id = 10, Numbers = new List<int>() { } },
            new Data() { Id = 450, Numbers = new List<int>() { 57, 35, 47, 100 } },
            new Data() { Id = 2100, Numbers = new List<int>() { 100, 34 } },
            new Data() { Id = 500, Numbers = new List<int>() { } },
          };

            public Dictionary<int, Data> dataDictionary = new Dictionary<int, Data>();

            public MainWindow()
            {
                //InitializeComponent();

                foreach (var item in dataList)
                {
                    dataDictionary[item.Id] = item;
                }

                // Linq est une librairie C# permettant d'effectuer des recherches à l'aide
                // d'une expression lambda sur des conteneurs (List, Dictionary, IEnumerable, etc.) 

                // Par convention, on nomme la variable lambda x, mais on peut aussi lui donner un nom plus descriptif
                var resultList1 = dataList.Where(x => x.Id > 0);
                var resultList2 = dataList.Where(data => data.Id > 0);

                // Une recherche sur un Dictionary, retourne des KeyValuePair<>
                var resultDictionary1 = dataDictionary.Where(x => x.Value.Id > 0);
                // Une recherche sur les Values d'un Dictionary, retourne des classes (recommandé)
                var resultDictionary2 = dataDictionary.Values.Where(x => x.Id > 0);

                // Linq retourne une réponse sous forme de IEnumerable qui est similaire à une List
                // Cependant les IEnumerable ne sont pas encore calculés, ils représente le code
                // du for loop en attente. Lorsqu'on itère sur le IEnumerable la code du for loop
                // est exécuté jusqu'au prochain élément trouvé.
                // Afin de forcer l'exécution, on peut les transformer en List ou Array
                var resultToList = dataList.Where(x => x.Id > 100).ToList();
                var resultToArray = dataList.Where(x => x.Id > 100).ToArray();

                // Grace au IEnumerable, on peut imbriquer des requêtes Linq grâce ou itérer sur le résultat
                var resultMultipleLinq = dataList
                    .Where(x => x.Id > 100)
                    .FirstOrDefault(x => x.Numbers.Contains(123));

                var resultLoop = dataList.Where(x => x.Id > 100);
                foreach (var item in resultLoop)
                {
                    // Chaque loop effectue la recherche du IEnumerable jusqu'au prochain élément trouvé
                    Console.WriteLine(item);
                }


                // Requêtes Linq Importantes 
                // 1)   FirstOrDefault trouve le premier élément qui rempli une condition ou retourne null
                //      On débute avec une List<Data>, on termine avec un Data ou null
                var resultFirstOrDefault = dataList.FirstOrDefault(x => x.Id == 1000);

                // 2)   Where retourne tous les éléments qui remplissent une condition
                //      On débute avec une List<Data>, on termine avec un IEnumerable<Data>
                var resultWhere = dataList.Where(x => x.Id > 100);

                // 3)   Select retourne un nouvel élément pour chaque élément, la classe initiale est perdue
                //      Select est une transformation de chaque élément en une nouvelle classe
                //      On débute avec une List<Data>, on termine avec un IEnumerable<int>
                var resultSelect = dataList.Select(x => x.Id);
                //      On débute avec une List<Data>, on termine avec un IEnumerable<List<int>>
                var resultSelect2 = dataList.Select(x => x.Numbers);

                // 4)   SelectMany est comme un Select, mais on fait un flatten des multiples List en une seule
                //      Cela permet d'itérer plus facilement sur tous les éléments trouvés
                //      On débute avec une List<Data>, on termine avec un IEnumerable<int> au lieu de IEnumerable<List<int>>
                var resultSelectMany = dataList.SelectMany(x => x.Numbers);
                //      Utile pour imbriquer des requêtes, car on ne peut pas itérer facilement sur un IEnumerable<List<int>>
                var resultSelectError = dataList
                    .Select(x => x.Numbers);
                    //.Where(x => x > 10);    // x est une List<int>
                var resultSelectManyFix = dataList
                    .SelectMany(x => x.Numbers)
                    .Where(x => x > 10);    // x est un int

                // 5)   OrderBy / OrderByDescending permettent de trier les éléments
                //      OrderBy trie du plus petit au plus grand
                //      OrderByDescending trie du plus grand au plus petit
                var resultOrderBy = dataList.OrderBy(x => x.Id);
                var resultOrderByDesc = dataList.OrderByDescending(x => x.Id);

                //      ThenBy / ThenByDescending permetter de trier de facon supplémentaire un OrderBy
                var resultThenBy1 = dataList
                    .OrderBy(x => x.Id)
                    .ThenBy(x => x.Numbers.Count);
                var resultThenByDescending = dataList
                    .OrderBy(x => x.Id)
                    .ThenByDescending(x => x.Numbers.Count);

                //      Il est possible d'imbriquer autant de ThenBy que l'on veut
                var resultThenByMultiple = dataList
                    .OrderBy(x => x.Id)
                    .ThenByDescending(x => x.Numbers.Count)
                    .ThenBy(x => x.Numbers.Max());
                // etc.

                // 6)   All retourne un bool qui vérifie si tous les éléments répondent à la requête
                bool resultAllHaveNumbers = dataList.All(x => x.Numbers.Count > 0);

                // 7)   Any retourne un bool qui vérifie si au moins un élément répond à la requête
                bool resultAtLeastOneHasNumbers = dataList.Any(x => x.Numbers.Count > 0);
                //      Note : il est souvent plus utile de faire FirstOrDefault pour pouvoir avoir l'objet
                var resultFirstOrDefaultWithNumber = dataList.FirstOrDefault(x => x.Numbers.Count > 0);
                if (resultFirstOrDefaultWithNumber != null)
                {
                    Console.WriteLine(resultFirstOrDefaultWithNumber);
                }

                // 8)   Cast transforme chaque élément avec un cast () vers une autre classe
                //      Attention que les éléments seront null s'il ne peuvent être castés
                var resultCastObject = dataList.Cast<object>();
                var resultCastBackToUser = resultCastObject.Cast<Data>();
                var resultCastSelect = resultCastObject.Select(x => (Data)x);

                // Il existe plusieurs autres requêtes Linq utiles
                var resultSum = dataList.Sum(x => x.Id);
                var resultAverage = dataList.Average(x => x.Id);
                var resultMin = dataList.Min(x => x.Id);
                var resultMax = dataList.Max(x => x.Id);
                var resultDistincnt = dataList.SelectMany(x => x.Numbers).Distinct();
                var resultLastOrDefault = dataList.LastOrDefault(x => x.Id > 1000);
                var resultOfType = dataList.OfType<Data>();
            }
        }
    }

