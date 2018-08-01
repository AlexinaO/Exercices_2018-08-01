using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While1
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodeAvecWhile();
            Console.ReadKey();
        }

        static void MethodeAvecWhile()
        {
            Console.WriteLine("Donnez un nombre entier");
            var saisie = Console.ReadLine();
            while (saisie != "2018")
            {
                Console.WriteLine("Mauvais nombre ! Recommencez !");
                saisie = Console.ReadLine();
            }
            Console.WriteLine("Bravo!");
            //pour remplacer les lignes while
            //while (Console.ReadLine()!="2018")
            // Console.WriteLine("Mauvais nombre ! Recommence");

        }
    }
}

