using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    internal class TC_MethodOverloading
    {
        //method overloading
        public int add(int a,int b)
        {
            return a + b;
        }
        public double add(double a, double b)
        {
            return (double)a + b;
        }
        public float add(float a, float b)
        {
            return (float)a + b;
        }
        public int add(int a, int b, int c)
        {
            return a + b + c;
        }
        public static void Main(string[] args)
        {
            TC_MethodOverloading obj=new TC_MethodOverloading();
            Console.WriteLine("Result is:"+obj.add(12,13));
            Console.WriteLine("Result is:" + obj.add((int)25,105));
            Console.WriteLine("Result is:" + obj.add((double)12.534,13.234));
            Console.WriteLine("Result is:" + obj.add((float)12.431,13.361));
            //obj.add((int)12,13);
            Console.WriteLine("Result is:" + obj.add((int)12,13,25));
            Console.ReadKey();
        }
    }
}
