using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Exeption
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var entier1 = SaisirEntier("Entre un nbr :");
                var entier2 = SaisirEntier("Entre un autre nbr :");

                var division = entier1 / entier2;

 //               Console.WriteLine("bravo");

 //               Console.ReadKey();

                //Code pouvant provoc une erreure, dit une exeception
            }
           catch(DivideByZeroException exception)
            {
                Console.WriteLine("Euh...ton opé n'est pas possible" + exception.Message);
                //Code à exec en cas d'anomalie
            }
            catch(Exception exception)
            {
                Console.WriteLine("Euh..."+ exception.Message);
                throw exception;
                //code qui sera toujousr appel (a la fin du bloc try si pas d'ano relevé, ou apres catch
            }
            Console.ReadKey();
        }
    }
}
