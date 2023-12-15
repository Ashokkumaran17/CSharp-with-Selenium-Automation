using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    internal class TC_Sort_Foreach
    {
        public void TC1_Sort()
        {
            int[] num = { 23,12,35,19,7};
            Array.Sort(num);
            Console.WriteLine("Acending order :"+num);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
        public void TC2_Sort()
        {
            string[] day = {"Mon" , "Fri", "Wed","One", "Two" };
            Array.Sort(day);
            Console.WriteLine("Acending order :" + day);
            foreach (string i in day)
            {
                Console.WriteLine(i);
            }
        }
        public static void Main(string[] args)
        {
            TC_Sort_Foreach obj= new TC_Sort_Foreach();
            obj.TC1_Sort();
            obj.TC2_Sort();
            Console.ReadKey();
        } 
    }
}
