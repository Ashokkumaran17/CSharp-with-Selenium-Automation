using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    internal class TC_Array
    {
        public void IntArray()
        {
            int[] arr = { 31, 42, 53, 74, 95 };
            Console.WriteLine("arr length is:"+arr.Length);
            Console.WriteLine(arr.IsFixedSize);
            Console.WriteLine("arr[1]: "+arr[1]);
            Console.WriteLine("Array are is");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i);
            } 
        }
        public void StringArray()
        {
            string[] arr = { "Mon", "Tue", "Wed", "Thu", "Fri","Sat" };
            Console.WriteLine("arr length is:" + arr.Length);
            Console.WriteLine(arr.IsFixedSize);
            Console.WriteLine("arr[1]: " + arr[0]);
            Console.WriteLine("Array are is");
        }
        public void FindLargestNumber()
        {
            int[] arr = { 23, 12, 53, 14, 35 };
            Console.WriteLine("arr length is:" + arr.Length);
            int max_element = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] > max_element)
                {
                    max_element = arr[i];
                }
            }
            Console.WriteLine("Max element is:" + max_element);
        }
        public void FindtheLargestString()
        {
            string[] day = { "Monday","Wednesday","Tuesday", "Friday"};
            Console.WriteLine("arr length is:" + day.Length);
            string max_str = day[0];
            for (int i = 0; i < day.Length; i++)
            {
                if (day[i].Length > max_str.Length)
                {
                    max_str = day[i];
                }
            }
            Console.WriteLine("Max element is:" + max_str);
        }
        public static void Main(string[] args)
        {
            TC_Array obj = new TC_Array();
            obj.IntArray();
            obj.StringArray();
            obj.FindLargestNumber();
            obj.FindtheLargestString();
            Console.ReadKey();
        }
    }
}
