using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    internal class TC_If_pgm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Age:");
            int age = Console.Read();
            if (age > 18)
            {
                Console.WriteLine("Access Granted");             
            }
            else
            {
                Console.WriteLine("Access Denied");
            } 
            Console.ReadKey();

        }

    }
}
