using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quelle est votre civilité?");
            var civilite = Console.ReadLine();
            string message "Tu es";
            string saisie = Console.ReadLine();
            switch(saisie)
            {
                case "Madame":
                    message += " la bienvenue!";
                    break;
                case "Mademoiselle":
                    message += " la bienvenue!";
                    break;
                default:
                    message += " le bienvenu!";
                    break;
            }
            ////if (saisie=="Mademoiselle"|| saisie=="Madame")
            //{
            //    message += " la bienvenue!"; //=message = message + " la bienvenue!";
            // }
            //else
            //{
            //    message += " le bienvenu!";
            }
            Console.ReadKey();
        }

    }
}
