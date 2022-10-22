using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TE_C_Sharp
{
    public class bonus
    {
        protected int bonus_amt = 1000;

        protected void BonusDetails()
        {
            Console.WriteLine($" Accessing bonus  from bonus class with amount {bonus_amt}");
        }
    }
    public class staff : bonus
    {
        public void staffBonusDetails()
        {
            bonus_amt = bonus_amt * 3;
            BonusDetails();
            Console.WriteLine($" Staff class bouns amount: {bonus_amt}");
        }
    }
    public class nonStaff : bonus
    {
        public void nonstaffBonusDetails()
        {
            bonus_amt = bonus_amt * 2;
            BonusDetails();
            Console.WriteLine($" Non Staff class bouns amount: {bonus_amt}");
        }
    }
    internal class protectedExample
    {
        public static void Main()
        {
            staff s = new staff();
            nonStaff ns = new nonStaff();
            s.staffBonusDetails();
            ns.nonstaffBonusDetails();
        }
    }
}