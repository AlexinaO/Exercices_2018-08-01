using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While2
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodeAvecDoWhile();
            Console.ReadKey();
        }

        static void MethodeAvecDoWhile()
        {
            string saisie; 
            do
            {
                Console.WriteLine("Donnez un nombre entier");
                saisie = Console.ReadLine();
            }
            while (saisie != "2018");
            Console.WriteLine("Bravo!");
        }
    
    }
}
