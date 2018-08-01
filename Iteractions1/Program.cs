using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteractions1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 20; i++)
            {
                if (i % 2!=0) //signifie que le reste est différent de 0
                {
                    continue;
                }
                Console.WriteLine(i);

            }
            Console.ReadKey();
        }
    }
}
