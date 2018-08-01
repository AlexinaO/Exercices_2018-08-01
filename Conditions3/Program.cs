using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode; //pour permettre le traitement du symbole € !
            Console.WriteLine("Entrez le symbole d'une devise:");
            var symbole = Console.ReadLine();
            switch (symbole)
            {
                case "€":
                    Console.WriteLine("Le Symbole que vous avez entré correspond à l'euro");
                    break;
                case "$":
                    Console.WriteLine("Le Symbole que vous avez entré correspond au dollar");
                    break;
                case "£":
                    Console.WriteLine("Le symbole que vous avez entré correspond à la livre");
                    break;
                default:
                    Console.WriteLine("Cette devise est inconnue");
                    break;
            }
            Console.ReadKey();
        }
    }
}
