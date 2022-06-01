using System;
namespace SumOfNaturalNumber
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a valid input");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i <=num; i++)
            {
                if(i%2==0)
                {
                    sum = sum + i;  
                }              
            }
            Console.WriteLine(sum);
        }
    }
}