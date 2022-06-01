using System;
namespace prime
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the valid prime number");
            int num = Convert.ToInt32(Console.ReadLine());

            int m = num / 2;
            int flag = 0;

            for(int i=2;i<=m;i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine("given no is not a prime number");
                    flag = 1;
                    break;
                }
                
            }
            if (flag == 0)
            {
                Console.WriteLine("its a prime number");
            }

        }

    }
}