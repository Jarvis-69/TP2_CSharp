using static System.Console;
using System;

namespace Puissance4
{
    class Rectangle {
        float largeur;
        float Hauteur;
        public float Aire(float largeur, float Hauteur){
            return largeur * Hauteur;
        }
        public float Perimetre(float largeur, float Hauteur){
            return largeur * 2 + Hauteur * 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            float aire = rectangle.Aire(7,5);
            WriteLine(aire);

            float perimetre = rectangle.Perimetre(7,5);
            WriteLine(perimetre);
        }
    }

}