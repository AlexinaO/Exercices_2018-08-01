using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_2018_08_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var saisie = SaisirEntier("Entrez un entier");
            Console.WriteLine(saisie);
            if (saisie > 0)
            {
                Console.WriteLine("C'est un nombre positif");
            }
            else if (saisie < 0)
            {
                Console.WriteLine("C'est un nombre négatif");
            }
            else
            {
                Console.WriteLine("Je n'ai rien à dire !");
            }
            Console.ReadKey();

        }
        static int SaisirEntier(string texteAAfficher)
        {
            Console.WriteLine(texteAAfficher);
            return int.Parse(Console.ReadLine());
        }
    }
}
