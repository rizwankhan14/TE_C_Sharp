using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///<summary>
///</summary>
///


///

namespace TE_C_Sharp
{

    public class emp
    {
        public int id;
        public string name;

        public emp()
        {
            id = 1;
            name = "Riz";
        }

        public emp(int age)
        {
            Console.WriteLine($"{id}:{name}");
        }
    }
    internal class Constructor
    {
        public static void Main()
        {
            emp e = new emp();
            emp e1 = new emp(32);
        }
    }
}