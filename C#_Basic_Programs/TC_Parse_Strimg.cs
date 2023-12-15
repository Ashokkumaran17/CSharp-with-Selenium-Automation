using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    internal class Parse_Strimg_from_other_types
    {
        static void Main(string[] args)
        {
            //Parse Tognerate the value to String
            Console.WriteLine("Enter the  value:");//45
            string val = Console.ReadLine();
            double val2 = double.Parse(val);
            Console.WriteLine("Result of val1 is:"+val2);

            //TryParse
            string val3 ="true";
            if (bool.TryParse(val3,out bool b))
            {
                Console.WriteLine($"The b val is {b}");
            }
            Console.ReadKey();


        }
    }
}
