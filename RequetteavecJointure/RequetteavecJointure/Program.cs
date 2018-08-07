using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequetteavecJointure
{
    class Program
    {
        static void Main(string[] args)
        {// requete
            var requete = from ville in villes
                          join departement in departements
                              on ville.Departement equals deparement.Numero
                                  into jointure
                          from ligne in jointure.DefaultIfEmpty()
                          select new
                          {
                              Ville = ville.nom,
                              NomDepartement = departement.Nom
                          };
            foreach (var resultat in requete)
            {
                Console.WriteLine($" - {resultat.ville} ({resultat.Nomdepartement})");
            }
        }
    }
}
