using System;
namespace swap
{
    class program
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("before swaping a =" + a + " and b = " + b);

            b = b - a;
            a = a + b;

            Console.WriteLine("after swapping a =" + a + " and b = " + b);
        }
    }
}