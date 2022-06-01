using System;
namespace Easy
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter starting range");
            int i=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter ending range");
            int j=Convert.ToInt32(Console.ReadLine());

            for(int num=i; num<=j; num++)
            {
                int count = 0;
                for(int k=1; k<=num; k++)
                {
                    if (num % k == 0)
                    {
                        count++;
                    }
                   
                }
                if(count == 2)
                {
                    Console.WriteLine(num);
                }
               
            }
            Console.ReadLine();
        }
    }
}