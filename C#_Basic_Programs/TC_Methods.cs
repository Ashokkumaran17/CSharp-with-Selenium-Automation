using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Csharp_2023
{
    internal class TC_Methods
    {
        public void add1()
        {
            int i = 10;
            int j = 20;
            int k = i+j;
            Console.WriteLine("k value is:"+k);
        }
        public int add_with_arg(int i, int j) 
        {
            int k = i+j;
            return k;
        }
        public string string_concat(string a,string b)
        {
            string c = a + b;
            return c;
        }
        public static void Main(string[] args)
        {
            TC_Methods obj = new TC_Methods();
            obj.add1();
            Console.WriteLine("Result is :"+obj.add_with_arg(15,45));
            Console.WriteLine("Name is :"+obj.string_concat("Ashok", "Kumar"));
            Console.ReadKey();

        }
    }
}
