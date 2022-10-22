using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_C_Sharp
{
    internal class Array
    {
        public static void Main()
        {
            Matrix_addition();
        }

        public static void Matrix_addition()
        {
            int[,] array1 = new int[3, 3]
            {
                {3,4,5 },
                {4,5,6 },
                {8,9,6 },
            };
            int[,] array2 = new int[3, 3]
           {
                {9,2,7 },
                {3,1,6 },
                {4,6,4 },
           };
            int[,] sum = new int[3, 3];

            Console.WriteLine("Array 1");
            for (int i = 0; i < array1.GetLength(0); i++) // 0<2 1<2 2<2
            {
                for (int j = 0; j < array1.GetLength(1); j++) //0<4 1<4 2<4 3<4 4<4 
                {
                    Console.Write(array1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Array 2");
            for (int i = 0; i < array1.GetLength(0); i++) // 0<2 1<2 2<2
            {
                for (int j = 0; j < array1.GetLength(1); j++) //0<4 1<4 2<4 3<4 4<4 
                {
                    Console.Write(array2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Sum of Array 1 and Array 2");
            for (int i = 0; i < array1.GetLength(0); i++) // 0<2 1<2 2<2
            {
                for (int j = 0; j < array1.GetLength(1); j++) //0<4 1<4 2<4 3<4 4<4 
                {
                    sum[i, j] = array1[i, j] + array2[i, j];
                }
            }

            for (int i = 0; i < array1.GetLength(0); i++) // 0<2 1<2 2<2
            {
                //columns
                for (int j = 0; j < array1.GetLength(1); j++) //0<4 1<4 2<4 3<4 4<4 
                {
                    Console.Write(sum[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
