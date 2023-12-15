using System;
using System.IO;  // include the System.IO namespace
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    internal class TC_Files
    {
        public static void Main(string[] args)
        {
            //create a Text string
            string wrText = "Hello, welcome to the C# program";
            //create the File and write the content of WriteAllText to it.
            File.WriteAllText("simplefile.txt", wrText);
            //Read the File
            string rdText=File.ReadAllText("simplefile.txt");
            Console.WriteLine(rdText);
            Console.ReadKey();

        }
    }
}
