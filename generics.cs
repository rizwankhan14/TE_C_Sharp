using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_C_Sharp
{
    internal class Generics
    {
        public delegate T Area<T>(T a);
        class calculateArea
        {
            public int Sqaure(int a)
            {
                return a * a;
            }
            public int Cube(int b)
            {
                return b * b * b;
            }
            public double AreaofCircle(double r)
            {
                return 3.142 * r * r;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("****Area Calculator for Square, Cube and Circle****");
                calculateArea c = new calculateArea();
                // Instantiate delegate with add method using int
                int t = 1;
                while (t != 0)
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Enter your option");
                    Console.WriteLine("1. FIND AREA OF SQUARE \n2. FIND AREA OF CUBE \n3. FIND AREA OF CIRCLE\n4. EXIT");
                    int opt;
                    opt = Convert.ToInt32(Console.ReadLine());
                    switch (opt)
                    {
                        case 1:
                            Area<int> dlgt = new Area<int>(c.Sqaure);
                            int s;
                            Console.Write("Enter the square length: ");
                            s = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Area of a Square : " + dlgt(s));
                            break;

                        case 2:
                            dlgt = c.Cube;
                            int cu;
                            Console.Write("Enter the cube length: ");
                            cu = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Area of a Cube : " + dlgt(cu));
                            break;

                        case 3:
                            Area<double> dlgt1 = new Area<double>(c.AreaofCircle);
                            double a;
                            Console.Write("Enter the radius of a circle: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Area of a Circle: " + dlgt1(a));
                            break;

                        case 4:
                            t = 0;
                            break;

                        default:
                            Console.WriteLine("Invalid option!!");
                            break;
                    }
                }
            }
        }
    }
}