using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_C_Sharp
{
    internal class Exception
    {
        public static void Main()
        {
            int n1, n2, r;
            try
            {
                Console.WriteLine("Enter First Number");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                n2 = int.Parse(Console.ReadLine());
                r = n1 / n2;
                Console.WriteLine($"Result: {r}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input string was not in a correct format, Enter only numbers");
            }
        }
    }
}