using System;
namespace factorial
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number whose factorial you want");
            int num = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("the factorial of {0}! is {1}", num, fact);
        }
    }
}