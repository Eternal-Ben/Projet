/*Réalisation d'une application qui permet de gérer nos contacts. 
Pour le moment un contact est une chaîne de caractères

L'application propose un menu avec 4 options :
1. Liste des contacts
2. Ajout d'un contact
3. Suppression d'un contact
4. Quitter

> Faire une méthode pour l'affichage du menue et chacune des 3 premières options.

Taf au dom, voir les listes/voir les switch cases/et les get - set... voir si plus necessaire
  
* Ecrire une classe statique OutilsConsole qui contient les methodes suivantes :
> SaisirEntierObligatoire
> SaisirEntier
> SaisireChaineObligatoire
> SaisirDate
> SaisirDateObligatoire

* Modif l'app pour utiliser ces nouvelles méthodes
(Astuce) Pensez à use les methodes TryParse...

------------------------
 Version du Prof :
 using System;

using System.Collections.Generic;



namespace ContactsManager

{

    class Program

    {

        static List<Contact> contacts = new List<Contact>();



        static void Main(string[] args)

        {

            bool continuer = true;

            while (continuer)

            {

                var choix = AfficherMenu();

                switch (choix)

                {

                    case "1":

                        ListerContacts();

                        break;

                    case "2":

                        AjouterContact();

                        break;

                    case "3":

                        SupprimerContact();

                        break;

                    case "4":

                        continuer = false;

                        break;

                    default:

                        Console.WriteLine("Choix invalide, l'application va fermer...");

                        continuer = false;

                        break;

                }

            }

        }



        /// <summary>

        /// Affiche le menu

        /// </summary>

        /// <returns>Retourne le choix de l'utilisateur.</returns>

        static string AfficherMenu()

        {

            Console.Clear();



            Console.WriteLine("MENU\n");

            Console.WriteLine("1. Liste des contacts");

            Console.WriteLine("2. Ajout d’un contact");

            Console.WriteLine("3. Suppression d’un contact");

            Console.WriteLine("4. Quitter");

            Console.Write("\nVotre choix: ");



            return Console.ReadLine();

        }



        static void ListerContacts()

        {

            Console.Clear();

            Console.WriteLine("LISTE DES CONTACTS\n");



            Console.Write("{0,-10} | ", "NOM");

            Console.Write("{0,-10} | ", "PRENOM");

            Console.Write("{0,-20} | ", "EMAIL");

            Console.Write("{0,-10} | ", "TELEPHONE");

            Console.Write("{0,-10} | ", "DATE NAIS.");

            Console.WriteLine();

            Console.WriteLine(new string('-', 75));



            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (var contact in contacts)

            {

                Console.Write("{0,-10} | ", contact.Nom);

                Console.Write("{0,-10} | ", contact.Prenom);

                Console.Write("{0,-20} | ", contact.Email);

                Console.Write("{0,-10} | ", contact.Telephone);

                Console.Write("{0,-10} | ", contact.DateNaissance.ToShortDateString());

                Console.WriteLine();

            }

            Console.ResetColor();



            Console.WriteLine();

            Console.WriteLine("\nAppuie sur une touche pour revenir au menu...");

            Console.ReadKey();

        }



        static void AjouterContact()

        {

            Console.Clear();

            Console.WriteLine("AJOUT D'UN CONTACT\n");



            var contact = new Contact();

            contact.Nom = SaisirChaineObligatoire("Nom:");

            contact.Prenom = SaisirChaineObligatoire("Prénom:");



            Console.WriteLine("Email:");

            contact.Email = Console.ReadLine();



            Console.WriteLine("Téléphone:");

            contact.Telephone = Console.ReadLine();



            Console.WriteLine("Date de naissance:");

            contact.DateNaissance = DateTime.Parse(Console.ReadLine());



            contacts.Add(contact);



            Console.WriteLine("Contact ajouté !");



            Console.WriteLine("\nAppuie sur une touche pour revenir au menu...");

            Console.ReadKey();

        }



        static string SaisirChaineObligatoire(string message)

        {

            Console.WriteLine(message);

            var saisie = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(saisie))

            {

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Champ requis. Recommence:");

                Console.ResetColor();

                saisie = Console.ReadLine();

            }



            return saisie;

        }



        static void SupprimerContact()

        {

            Console.Clear();

            Console.WriteLine("SUPPRESSION D'UN CONTACT\n");



            for (var i = 0; i < contacts.Count; i++)

            {

                Console.WriteLine($"- {contacts[i]} ({i})");

            }



            Console.Write("Entre le numéro du contact à supprimer: ");

            var index = int.Parse(Console.ReadLine());



            if (index < contacts.Count)

            {

                contacts.RemoveAt(index);

                Console.WriteLine("Contact supprimé !");

            }

            else

            {

                Console.WriteLine("Numéro invalide !");

            }



            Console.WriteLine("\nAppuie sur une touche pour revenir au menu...");

            Console.ReadKey();

        }

    }



    public class Contact

    {

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public DateTime DateNaissance { get; set; }



        public override string ToString()

        {

            return Nom + " " + Prenom;

        }

    }

}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContacManager
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
