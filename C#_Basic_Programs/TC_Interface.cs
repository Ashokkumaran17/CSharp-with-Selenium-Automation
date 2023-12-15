using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    //interface 
    interface TeamCSK
    {
        //interface method
        void player(string name);
        void keyplayer(string name);
        

    }
    // Derived class (inherit from Animal)
    class TeamIND : TeamCSK
    {
        public void player(string name)
        {
            Console.WriteLine("Player Name is:" + name);
        }
        public void keyplayer(string name)
        {
            Console.WriteLine("Player Name is:" + name);
        }
    }
    internal class TC_Interface
    {
        public static void Main(string[] args) {
            TeamIND obj = new TeamIND();
            obj.keyplayer("Devon");
            obj.player("Dhoni");
            Console.ReadKey();

        }
    }
}
