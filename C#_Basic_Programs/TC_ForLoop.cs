using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    internal class TC_ForLoop
    {
        public void ForLoop()
        {
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2== 0)
                {
                    sumEven += i;
                }
                if (i % 2 != 0)
                {
                    sumOdd += i;
                }
            }
            Console.WriteLine("Sum of Even Value is:"+sumEven); 
            Console.WriteLine("Sum of Odd Value is:" + sumOdd);
            Console.ReadKey();
        }
        public static void Main(string[] args) 
        {
            TC_ForLoop obj= new TC_ForLoop();
            obj.ForLoop();
        }
    }
}
