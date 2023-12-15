using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2023
{
    enum Team
    {
        AUS,
        NZ,
        Eng,
        IND
    }
    internal class TC_Enum
    {
        public static void Main(string[] args)
        {
            Team obj = Team.AUS;
            Console.WriteLine("Worldcup and TestChampion in 2023 :"+obj.ToString());
            Team obj1 = Team.NZ;
            Console.WriteLine("TestChampion in 2022 :" + obj1.ToString());
            Team obj2 = Team.Eng;
            Console.WriteLine("T20I Champion in 2022 :" + obj2.ToString());
            Team obj3 = Team.IND;
            Console.WriteLine("Domestic Winner in 2023 :" + obj3.ToString());
            Console.ReadKey();
        }
    }
}
