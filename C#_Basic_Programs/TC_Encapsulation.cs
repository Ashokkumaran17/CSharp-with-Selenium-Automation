using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{

    class Player
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    internal class TC_Encapsulation
    {
        public static void Main(string[] args)
        {
            Player obj = new Player();
            obj.Name = "Virat";
            Console.WriteLine(obj.Name);
            Console.ReadKey();
         }
        

    }
}
