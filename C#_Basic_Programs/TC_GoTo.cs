using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    internal class TC_GoTo
    {
        public static void Main(string[] args)
        {
          // label
          repeat:
            Console.WriteLine("Enter a number less than 10");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 10)
            {
                // transfers control to repeat
                goto repeat;
            }

            Console.WriteLine(num + " is less than 10");          
            Console.ReadKey();
            
        }
        
    }
}
