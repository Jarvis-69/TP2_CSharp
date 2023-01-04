using static System.Console;

namespace Puissance4
{
    class Etudiant
    {
        public string nom = "Dupont";
        public string prenom = "Jean";
        public int age = 20;
        public string Saluer()
        {
        return $"Bonjour, je m'appelle {nom} {prenom} et j'ai {age} ans.";
        }

        static void Main(string[] args)
        {
            Etudiant etudiant = new Etudiant();
            string salutation = etudiant.Saluer();
            WriteLine(salutation);
        }
    }
}