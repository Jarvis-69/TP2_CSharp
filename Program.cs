using static System.Console;
using System;

namespace Puissance4
{
    // Créez une interface IVolant avec une méthode Voler() qui retourne une chaîne de caractères "Je suis en train de voler!".

    // Créez une classe Oiseau qui implémente l'interface IVolant. La classe Oiseau doit avoir un champ nom (string) et une méthode Description() qui retourne une chaîne de caractères "Je suis un oiseau de nom nom."

    // Créez une classe Avion qui hérite de la classe Oiseau et qui implémente également l'interface IVolant. La classe Avion doit avoir un champ nbMoteurs (int) et une méthode Description() qui retourne une chaîne de caractères "Je suis un avion avec nbMoteurs moteurs de nom nom."

    interface IVolant
    {
        string voler();
    }
    class Oiseau : IVolant
    {       
        public string nom = "Faucon";
        public string voler() 
        {
            return "Je suis en train de voler!";
        }
        public string Description()
        {
            return $"Je suis un oiseau de nom {this.nom}.";
        }
    }

    class Avion : Oiseau
    {
        int nbMoteurs = 5;
        public string voler() 
        {
            return "Je suis en train de voler!";
        }
        public string Description()
        {
            return $"Je suis un avion avec {this.nbMoteurs} moteurs de nom nom.";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Oiseau oiseau = new Oiseau();
            Avion avion = new Avion ();
        }
    }

}