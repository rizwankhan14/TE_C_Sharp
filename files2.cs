using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_C_Sharp
{
    internal class files2
    {
        public static void Main()
        {

            //To read only first line of a text file.
            string path = @"C:\Users\rizwa\OneDrive\Desktop\13126.txt";

            Console.WriteLine("-----------------------------------------");
            string[] content;
            content = File.ReadAllLines(path);
            Console.WriteLine(content[0]);
            Console.WriteLine("-----------------------------------------");


            //To Count number of lines in a text file:
            var lineCount = File.ReadAllLines(@"C:\Users\rizwa\OneDrive\Desktop\13126.txt").Length;
            Console.WriteLine($"Total number of lines in TE.txt file are: {lineCount}");

        }

    }
}