using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    internal class TC_ExceptionHandling
    {
        public static void Main(string[] args)
        {
            try 
            {
                int[] num = {11,23,45};
                Console.WriteLine(num[4]);
            }
            catch (Exception e)//Index error 
            {
                Console.WriteLine(e+"Something went wrong!!!");
            }
            Console.ReadKey();

        }
    }
}
