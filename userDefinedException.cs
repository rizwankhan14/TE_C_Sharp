using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_C_Sharp
{
    public class AgeException : ApplicationException
    {
        public AgeException(string message) : base(message)
        {

        }
    }
    internal class userDefinedException
    {
        public static void Main()
        {
            int age;
            try
            {
                Console.WriteLine("Enter your age");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 22)
                {
                    throw (new AgeException(" Age below 22 are not allowed"));
                }
                else
                {
                    Console.WriteLine("your age is above 22 and you are eligible");
                }
            }
            catch (AgeException e)
            {
                Console.WriteLine("Age below 22 are not allowed");
            }
        }

    }
}