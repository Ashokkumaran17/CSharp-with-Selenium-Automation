using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    internal class Tc_SwitchCase
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the char:");
            string ch= Console.ReadLine();
            char ch1 = Convert.ToChar(ch);
            char ch2 = Char.ToLower(ch1);
            switch (ch2)
            {
                case 'a':
                    Console.WriteLine("Char 'a' is Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Char 'e' is Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Char 'i' is Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Char 'o' is Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Char 'u' is Vowel");
                    break;
                default:
                    Console.WriteLine("Char is not a Vowel");
                    break;
            }
            Console.ReadKey();
        }
    }
}
