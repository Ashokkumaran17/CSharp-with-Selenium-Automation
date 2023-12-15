using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    internal class TC_Input_Output_integer
    {
        public void Writekeyword()
        {
            Console.Write("Enter the First name:");
            string fName=Console.ReadLine();
            Console.WriteLine("First name is:"+fName);
            Console.Write("Enter the Last name:");
            string lName = Console.ReadLine();
            Console.WriteLine("First name is:" + lName);
            //concate the string
            string res=fName+lName;
            Console.WriteLine("The name is:" + res);
        }
        
        public void input_output_string()
        {
            Console.WriteLine("Enter the First name:");
            string fName = Console.ReadLine();
            Console.WriteLine("First name is:" + fName);
            Console.WriteLine("Enter the Last name:");
            string lName = Console.ReadLine();
            Console.WriteLine("First name is:" + lName);
            //concate the string
            string res = fName + lName;
            Console.WriteLine("The name is:" + res);
        }
        public void input_output_integer()
        {
            Console.Write("Enter the num1:");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the num2:");
            int num2 = int.Parse(Console.ReadLine());
            //concate the string
            int res = num1 + num2;
            Console.WriteLine("The Result is:" + res);
            Console.ReadKey();

        }
        public static void Main(string[] args)
        {
            TC_Input_Output_integer obj = new TC_Input_Output_integer();
            obj.Writekeyword();
            obj.input_output_string();
            obj.input_output_integer();

        }
    }
}
