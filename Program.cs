using System;
using static System.Console;

namespace Puissance4
{
    class JeuPuissance4
    {
        static void Main(string[] args)
        {
            string marque = "Tesla";
            string modele = "Model 3";
            int nbPortes = 5;
            string couleur = "Noir";
            WriteLine($"La voiture est une {marque} modèle {modele} avec {nbPortes} portes de couleur {couleur}.");
        }
    }
}