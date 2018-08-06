using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXo_Linq
{
    class Program //Ville
    {
        static void Main(string[] args)
        {
        }
        public class Ville
        {
            public string NomVille { get; set; }
            public string CodePostal { get; set; }
            public string Departement
            {
                get { return this.CodePostal.Substring(0, 2); }

        public class Departement
            {
                public string NomDept { get; set; }
                public string Numero { get; set; }
            }
            public class RequesteAvecGroupement ()
            { AfficherEntete();
            // Syntaxe de requete
            var requete = from prenom in prenoms
                          group prenom by prenom[0] into groupe
                          select new
                          {
                              Lettre = groupe.Key,
                              Prenoms = groupe.TolList()
                          };
                foreach (var resultat in requete)
                {
                Console.WriteLine(resultat.Lettre);
                foreach(var prenom in resultat.Prenoms)
                }

        //Syntaxe de methode
        public class RequesteAvecGroupement ()
            var requete2 = prenoms
                .OrderBy(prenom=> prenom)
                .GroupBy(prenom=> prenom[0];
                    .Select(groupe=> new
                        {
                            Lettre = groupe.Key,
                            Prenoms = groupe.ToList
                        }
    }
}
}
