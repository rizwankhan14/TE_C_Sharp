using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TE_C_Sharp
{
    internal class employee
    {
        public static void Main()
        {
            employee e = new employee();
            e.emp_details();
        }
        public void emp_details()
        {
            int sal, id;
            string name, desg, country;
            Console.WriteLine("Enter Your details");
            Console.Write("Enter Your Id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Your Designation: ");
            desg = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Your Country: ");
            country = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Your Salary: ");
            sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("You Employee details: ");
            Console.WriteLine($"ID : {id}");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Designation : {desg}");
            Console.WriteLine($"Country : {country}");
            Console.WriteLine($"Salary : {sal}");



        }
    }
}