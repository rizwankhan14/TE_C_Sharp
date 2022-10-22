using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_C_Sharp
{
    public class Tables
    {
        /// <summary>
        /// Write contents into the file using StreamWriter class
        /// </summary>
        public void Write()
        {
            //Specify the filename and the path of the file to be created 
            //Fileinfo - class
            FileInfo fileInfo = new FileInfo(@"E:\Tables.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fileStream);
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    writer.WriteLine($"{i}'s Table");
                    writer.WriteLine("---------------------------------");
                    for (int j = 1; j <= 10; j++)
                    {
                        writer.WriteLine($"{i} * {j} = {i * j}");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("---------------------------------");
                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
                fileStream.Close();
            }

        }

        public void read()
        {

            //Specify the filename and the path of the file to be created 
            //Fileinfo - class
            FileInfo fileInfo = new FileInfo(@"E:\Tables.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(fileStream);
            try
            {
                string contents = reader.ReadToEnd();
                Console.WriteLine(contents);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                reader.Close();
                fileStream.Close();
            }

        }
    }
    internal class files1
    {
        public static void Main()
        {
            Tables demo = new Tables();
            // demo.Write();
            demo.read();
        }
    }
}