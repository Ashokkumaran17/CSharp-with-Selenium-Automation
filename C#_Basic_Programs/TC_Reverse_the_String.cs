using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    internal class TC_Reverse_the_String
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the String:");
            string name = Console.ReadLine();
            //Converting string to char Arry
            char[] ch_name= name.ToCharArray();
            //Take empty string
            string Reversedstr=string.Empty;
            for(int i =ch_name.Length-1;i>-1;i--)
            {
                Reversedstr += ch_name[i];               
            }
            Console.Write("Reversed String is :"+Reversedstr);
            Console.ReadKey();
        }
    }
}
