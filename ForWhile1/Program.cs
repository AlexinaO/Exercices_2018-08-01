using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entrez l'entier n°1:");
            var entier1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez l'entier n°2:");
            var entier2 = int.Parse(Console.ReadLine());
            MethodeAvecFor(entier1,entier2);
            MethodeAvecWhile(entier1, entier2);
            MethodeAvecDoWhile(entier1, entier2);
            Console.ReadKey();

        }
        /// <summary>
        /// Méthode de calcul avec la boucle for
        /// </summary>
        /// <param name="entier1"></param>
        /// <param name="entier2"></param>
        static void MethodeAvecFor(int entier1, int entier2)
        {
            Console.WriteLine("Avec For");
            for (var i = entier1 + 1; i < entier2; i++)
            {
                Console.WriteLine(+i);
            }


        }
        /// <summary>
        /// Méthode de calcul avec while
        /// </summary>
        /// <param name="entier1"></param>
        /// <param name="entier2"></param>
        static void MethodeAvecWhile(int entier1, int entier2)
        {
            Console.WriteLine("Avec while");
            entier1 = entier1 + 1;
            while (entier1<entier2)
            {
                Console.WriteLine(entier1);
                entier1 = entier1 + 1;
            }
        }
        /// <summary>
        /// Méthode de calcul avec do while
        /// </summary>
        /// <param name="entier1"></param>
        /// <param name="entier2"></param>
        static void MethodeAvecDoWhile(int entier1, int entier2)
        {
            Console.WriteLine("Avec le Do while");
            do
            {
                entier1++;
                Console.WriteLine(entier1);
            } while (entier1 < entier2 - 1);
        }
        
    }

}
