using static System.Console;
using System;

namespace Puissance4
{
    class CompteBancaire
    {
        public string nomTitulaire = "SALVADOR";
        public float solde = 0;
        public void Deposer(float montant)
        {
            solde += montant;
        }
        public void Retirer(float montant)
        {
            if (montant > solde)
            {
                WriteLine ("Le solde est insuffisant");
            }
            else
            {
                solde -= montant;
            }
        }
        static void Main(string[] args)
        {
            CompteBancaire monCompte = new CompteBancaire();
            WriteLine("Nom du titulaire du compte : " + monCompte.nomTitulaire);
            WriteLine("Solde du compte : " + monCompte.solde);
            WriteLine("Combien voulez-vous déposer ?");
            monCompte.Deposer(Convert.ToInt32(ReadLine()));
            WriteLine("Nouveau solde après dépôt : " + monCompte.solde);
            WriteLine("Combien voulez-vous retirer ?");
            monCompte.Retirer(Convert.ToInt32(ReadLine()));
            WriteLine("Nouveau solde après retrait : " + monCompte.solde);
        }
    }
}