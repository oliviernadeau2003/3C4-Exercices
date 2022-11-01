using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Cours06_Dictionary
{
    // Structures de donnees
    //
    // Tableau (Array [])
    // var myArray = new Pogo[100];
    //
    // Avantages : Initialisation Rapide, Memoire contigue, Pas de Garbage Collection
    // Desavantages : Recherche lente, Taille fixe
    // Cas d'utilisation : Pour la performance seulement (ex: engin de jeu, systeme en temps reel), donc presque jamais
    //
    // Liste (List<>)
    // var myList = new List<Pogo>();
    //
    // Avantages : Initialisation Rapide, Memoire contigue, Taille dynamique
    // Desavantages : Recherche lente, Performance et Garbage Collection lors aggrandissement de la liste
    // Cas d'utilisation : 99% du temps commencer avec une liste
    //
    // Dictionaire (Dictionary<>)
    // var myDictionary = new Dictionary<int, Pogo>();
    //
    // Avantages : Recherche rapide, Taille dynamique
    // Desavantages : Initialisation lente, Memoire non contigue, Performance et Garbage Collection lors aggrandissement de la liste
    // Cas d'utilisation : 1) pouvoir rechercher un element en particulier avec un identifiant (int/string) rapidement (ex: 10000000 elements)
    //                     2) pouvoir plus rapidement faire des recherche, mais si la performance n'est pas importante (ex: 100 elements)

    // Utilisation d'un Dictionary<>
    //
    // *** Create ***
    // Se declare similairement a une List<>, mais il faut precises deux Types de donnes entre les <>
    // Le premier type est la cle (Key) qui servira a retrouver l'element plus tard (souvent int ou string)
    // Le deuxieme type est la valeur (Valeur) qui est souvent une classe contenant les donnees
    // var dictInt = new Dictionary<int, Pogo>();
    // var dictString = new Dictionary<string, Pogo>();
    // 
    // *** Read ***
    // Pour obtenir la valeur (Value), il s'agit simplement de referencer la cle (Key) entre crochets []
    // var pogo1 = dictInt[100];
    // var pogo2 = dictInt["yummy"];
    //
    // Attention : vous aurez un crash si la cle (Key) n'existe pas vous aller avoir un crash
    // Verifier avec la fonction .ContainsKey() sur le Dictionary<> avant de referencer un index
    // if (dictInt.ContainsKey(100))
    //     var pogo1 = dictInt[100];
    // if (dictString.ContainsKey("yummy"))
    //     var pogo2 = dictString["yummy"];
    //
    // *** Update ***
    // Pour ajouter ou modifier un element, il s'agit simplement de referencer la cle entre crochets [] et d'affecter la nouvelle valeur
    // dictInt[100] = new Pogo();
    // dictInt["yummy"] = new Pogo();
    //
    // Attention : chaque cle est unique et ecraser la cle supprime l'element
    // Ici, l'ancien Pogo 100 du Dictionary<> est perdu
    // dictInt[100] = new Pogo();
    //
    // *** Delete ***
    // Pour supprimer, utiliser la fonction .Remove() et passer la cle (Key) en parametre
    // dictInt.Remove(100);
    // dictInt.Remove("yummy");
    //
    // *** Iteration ***
    // Vous pouvez iterer de 3 facons : sur le Dictionary<>, sur les cles (Keys) et sur les valeurs (Values)
    //
    // Sur le Dictionary<>
    // Lors que vous iterez sur le Dictionary<>, une classe intermediaire KeyValuePair<> sera utilisee
    // Vous pouvez ensuite faire .Key ou .Value pour acceder a la cle ou la valeur
    // for each(var keyValuePair in dictInt)
    // {
    //      int key = keyValuePair.Key;
    //      Pogo value = keyValuePair.Value;
    // }
    //
    // Sur les cles (Keys)
    // Il faut simplement iterer sur le .Keys du Dictionary<> au lieu du Dictionary<> lui-meme, pas souvent utile
    // for each(int key in dictInt.Keys)
    // {
    // }
    //
    // Sur les valeurs (Values)
    // Il faut simplement iterer sur le .Keys du Dictionary<> au lieu du Dictionary<> lui-meme, souvent utile
    // for each(var pogo in dictInt.Values)
    // {
    // }
    //
    // Attention : vous risquez souvent de faire des erreurs au debut et oublier de faire dictInt.Values

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Exercice01();
            Exercice02();
            Exercice03();
            Exercice04();
            Exercice05();
            Exercice06();
            Exercice07();
            Exercice08();
            Exercice09();
            Exercice10();
            Exercice11();
            Exercice12();
        }

        private void AddExerciceTextBlock(int id, string answer)
        {
            var textBlock = new TextBlock();
            textBlock.Text = $"Exercice {id:00}";

            //TODO: rendre plus beau

            ExercicePanel.Children.Add(textBlock);

            // TODO: ajouter un TextBlock pour la reponse
            // TODO: rendre plus beau
        }

        private void Exercice01()
        {
            // Afficher les informations de tous les Clients
            string answer = "";

            AddExerciceTextBlock(1, answer);
        }

        private void Exercice02()
        {
            // Afficher les informations de tous les Products
            string answer = "";

            AddExerciceTextBlock(2, answer);
        }

        private void Exercice03()
        {
            // Afficher dans un TextBlock les informations des Transctions de la liste suivante
            var transactionIds = new List<int>() { 38744, 38744, };

            string answer = "";

            AddExerciceTextBlock(3, answer);
        }

        private void Exercice04()
        {
            // Ajouter un Client avec votre nom avec le Id 2022 et afficher la liste des Clients

            string answer = "";

            AddExerciceTextBlock(4, answer);
        }


        private void Exercice05()
        {
            // Ajouter une Transaction avec Id de votre matricule pour votre compte Client avec 3x Rice et 1x Milk et afficher la Transaction

            string answer = "";

            AddExerciceTextBlock(5, answer);
        }

        private void Exercice06()
        {
            // Supprimer le Product Pogo et afficher la liste des Products

            string answer = "";

            AddExerciceTextBlock(6, answer);
        }

        private void Exercice07()
        {
            // Afficher les Transactions qui ont uniquement un seul Produit vendu

            string answer = "";

            AddExerciceTextBlock(7, answer);
        }

        private void Exercice08()
        {
            // Afficher les Clients qui ont au moins une Transaction

            string answer = "";

            AddExerciceTextBlock(8, answer);
        }

        private void Exercice09()
        {
            // Pour chaque Transaction ajouter 1 au compte vendu pour les Products de la liste suivante
            var productIds = new List<int> { 52, 17, 24 };

            string answer = "";

            AddExerciceTextBlock(9, answer);
        }

        private void Exercice10()
        {
            // Afficher les Transaction qui sont plus de 100$

            string answer = "";

            AddExerciceTextBlock(10, answer);
        }

        private void Exercice11()
        {
            // Afficher les Clients qui ont achete au moins un Milk

            string answer = "";

            AddExerciceTextBlock(11, answer);
        }

        private void Exercice12()
        {
            // Supprimer les Clients qui n'ont pas de Transactions et afficher les Clients

            string answer = "";

            AddExerciceTextBlock(12, answer);
        }
    }
}
