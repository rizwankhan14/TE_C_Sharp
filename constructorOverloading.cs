using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_C_Sharp
{
    class add
    {
        public add(int a, int b)
        {
            Console.WriteLine($"{a + b}");
        }
        public add(float a, float b)
        {
            Console.WriteLine($"{a + b}");
        }
        public add(string a, string b)
        {
            Console.WriteLine($"{a + b}");
        }
    }
    internal class constructorOverloading
    {
        public static void Main()
        {
            add a = new add(3, 5);
            add a1 = new add(3.5f, 5.7f);
            add a2 = new add("Rizwan", "Khan");
        }
    }
}