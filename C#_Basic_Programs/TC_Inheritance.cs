using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    class Test
    {
        public string player_name = "Virat";//field
        public void TestPlayer(string player_name)
        {
            Console.WriteLine("Test Player Name is:"+ player_name);
        }


    }
    //derived class 
    class ODI : Test 
    {
        public string ODI_player_name = "Hitman";
        public void ODIPlayer(string player_name)
        {
            Console.WriteLine("ODI Player Name is:" + player_name);
        }

    }
    //deriver class
    class T20I : ODI
    {
        public string T20I_player_name = "Gill";
        public void T20IPlayer(string player_name)
        {
            Console.WriteLine("T20I Player Name is:" + player_name);
        }

    }
    class TC_Inheritance
    {
        public static void Main(string[] args)
        {
            T20I obj = new T20I();
            obj.TestPlayer("Ashwin");
            obj.ODIPlayer("Gill");
            obj.T20IPlayer("SKY");
            Console.WriteLine("All Format Player Name is:" + obj.player_name);
            Console.ReadKey();


        } 
    }
}
