using static System.Console;
using System;

namespace Puissance4
{
    class Calculatrice
    {
        // une fonction qui prend deux entiers en paramètres
        // et qui retourne le produit de ces deux entiers
       public int Multiplier (int a, int b) {
            return a * b;
        }
       public int Additionner (int a, int b) {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // creer une instance de calculatrice
            Calculatrice casio = new Calculatrice();
            // stocker le resultat d'une multiplication dans une variable
            int produit = casio.Multiplier(5, 7);
            // afficher ce resultat en console 
            WriteLine(produit);
            
            int somme = casio.Additionner(5, 7);
            WriteLine(somme);
        }
    }

}