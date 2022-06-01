using System;
namespace Easy
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a valid input");
            int i=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a end valid input");
            int j = Convert.ToInt32(Console.ReadLine());

            for(int k=i; k<=j; k++)
            {
                int count = 0;
                for (int num = 1; num <= k; num++)
                {
                    if (k % num == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(k);
                }
            }
        }
    }
}