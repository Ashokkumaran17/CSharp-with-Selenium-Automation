using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    internal class TC_WhileLoop
    {
        static void Main(string[] args)
        {
      
            int i = 1;
            while (i < 10)
            {
                Console.WriteLine(i);
                if (i == 5) {
                    break;
                }
                i++;

            }
            Console.ReadKey();

        }
    }
}
