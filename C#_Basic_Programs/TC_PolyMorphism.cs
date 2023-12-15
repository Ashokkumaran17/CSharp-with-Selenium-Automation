using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    //Example Method Overriding
    class TestTeam
    {
        public void Player(string player_name)
        {
            Console.WriteLine("Test Player Name is:" + player_name);
        }


    }
    //derived class 
    class ODITeam : TestTeam
    {
        public void Player(string player_name)
        {
            Console.WriteLine("ODI Player Name is:" + player_name);
        }

    }
    //deriver class
    class T20ITeam : ODITeam
    {
        public void Player(string player_name)
        {
            Console.WriteLine("T20I Player Name is:" + player_name);
        }

    }
    internal class TC_PolyMorphism
    {
        public static void Main(string[] args)
        {
            TestTeam t1 = new TestTeam();
            ODITeam t2 = new ODITeam();
            T20ITeam t3 =new T20ITeam();
            t1.Player("Virat");
            t2.Player("Virat");
            t3.Player("Virat");
            Console.ReadKey();

        }
    }
}
