using System;
namespace Easy
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number whose sum you want");
            int num=Convert.ToInt32(Console.ReadLine());
            int count = 2;
            for (int i=2;i<=num;i++)
            {
              
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("It's a prime number");
            }
            else
            {
                Console.WriteLine("Not a prime number");
            }           
        }
    }
}