﻿using System;
using System.IO;
using System.Text;

class filexercise11
{
    public static void Main()
    {
        string fileName = @"mytest.txt";

        try
        {
            // Delete the file if it exists.
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            Console.Write("\n\n Read the first line from a file  :\n");
            Console.Write("---------------------------------------\n");
            // Create the file.
            using (StreamWriter fileStr = File.CreateText(fileName))
            {
                fileStr.WriteLine(" test line 1");
                fileStr.WriteLine(" test line 2");
                fileStr.WriteLine(" Test line 3");
            }
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                Console.WriteLine(" Here is the content of the file mytest.txt : ");
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
            }

            Console.Write("\n The content of the first line of the file is :\n");
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                Console.Write(lines[0]);
            }
            Console.WriteLine();
        }
        catch (Exception MyExcep)
        {
            Console.WriteLine(MyExcep.ToString());
        }
    }
}