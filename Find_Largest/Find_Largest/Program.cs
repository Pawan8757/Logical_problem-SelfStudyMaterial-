using System;
namespace Easy
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter three number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if(a > b && a>c)
            {
                Console.WriteLine("A is the greatest number");
            }
            else if(b>a && b>c)
            {
                Console.WriteLine("B is the greatest number");
            }
            else
            {
                Console.WriteLine("C is the greatest one");
            }
            Console.ReadLine();
        }
    }
}