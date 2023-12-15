using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    //abstarct class
    abstract class CSKTeam
    {   
        //abstract method
        public abstract void Player(string name);
        public void keyplayer(string name)
        {
            Console.WriteLine("Player Name is:"+name);
        }
        
    }
    // Derived class (inherit from Animal)
    class INDTeam : CSKTeam
    {
        public override void Player(string name)
        {
            Console.WriteLine("Player Name is:" + name);
        }
    }
    internal class TC_Abstract
    {
        public static void Main(string[] args)
        {
            INDTeam obj = new INDTeam();
            obj.keyplayer("Dhoni");
            obj.Player("Jadeja");
            Console.ReadKey();  
        }
    }
}
