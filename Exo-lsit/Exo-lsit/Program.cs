/*Ex 1 :
 * Soit la lsite suivante:
 * >int[] scores = new int [] {97,92,81,60}
 * 
 * Ecrivez une requete Linq qui renvoie les scores > 80
 * ecrivez une requete Linq qui renvoie les scores dans l'ordre croissant
 *
 *Ex 2 :
 * Soit la variable suivante :
 * > string valeur ="mammouth";
 * 
 * Ecrivez une requete Linq qui renvoie la frequence de chaque lettre du mot
 * > (Astuce1 une chaine de caracteres est en fait un tableau de caracteres (string <->char[})
 * > (Astuce2 l'operaton de regroupement renvoie un objet de typ IGrouping<> qui contient la methode Count permettant pour chasue entree le nbr d'element.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_lsit
{
    class Program
    {
        static void Main(string[] args)
        {
        // point d'entree generique ; passe les var general à reuse dans les differentes methode
            int[] scores = new int[4] { 97, 92, 81, 60 };
            ListesScores(scores);
            OrdreScores(scores);
        }
        // synt de requete
        public static void ListesScores(int [] scores)
        {
            var numQuery = from score in scores
                           where score > 80
                           select score;
            foreach (int score in numQuery)
            {
                Console.WriteLine(":"+ score);
            }


        }
        // exo 1/2
        public static void OrdreScores(int[] scores)
        {
            var numQuery = from score in scores
                           orderby score ascending
                           select score;

            foreach (int score in numQuery)
            {
                Console.WriteLine(":" + score);
            }


        }

        // synt de methode
        //      public static void ListeDesScore2 ()
        //      {
        //         var requete2 = score
        //              .Order
        //      }

    }
}
