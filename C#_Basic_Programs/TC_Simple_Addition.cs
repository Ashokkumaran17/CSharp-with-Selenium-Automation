using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    internal class TC_Simple_Addition
    {
        public int add(int a,int b){
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        public int div(int a, int b)
        {
            return a / b;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter num1:");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            TC_Simple_Addition obj= new TC_Simple_Addition();
            Console.WriteLine("Add Result is:"+obj.add(num1, num2));
            Console.WriteLine("Sub Result is:"+obj.sub(num1, num2));
            Console.WriteLine("Mul Result is:"+obj.mul(num1, num2));
            Console.WriteLine("Div Result is:"+obj.div(num1, num2));
            Console.ReadKey();

        }
           
    }
}
