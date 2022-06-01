using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_Year
{
    public  class Class1
    {
        public void FindingLeap()
        {
            Console.WriteLine("Enter the year");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num%4==0 && num%100!=0 || num%400==0)
            {
                Console.WriteLine("the given year {num} is a leap year");
            }
            else
            {
                Console.WriteLine("NOT A LEAP YEAR");
            }
            Console.ReadLine();
        }
    }
}
