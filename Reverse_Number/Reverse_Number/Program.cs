using System;
namespace number
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a valid input");
            int num=Convert.ToInt32(Console.ReadLine());

            int backup = num;
            int rem, rev = 0;
            while(num>0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;

            }
            Console.WriteLine($"Reverse number is {rev}");
        }
    }
}