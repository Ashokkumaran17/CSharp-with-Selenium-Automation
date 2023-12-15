using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    internal class Tc_do_WhileLoop
    {
        static void Main(string[] args)
        {   
            int i = 0;
            Console.WriteLine("i values are:");
            do
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
                i++;
            }while (i < 10);
            Console.ReadKey();
        }
    }
}
