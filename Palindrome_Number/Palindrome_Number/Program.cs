using System;
namespace number
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a valid input");
            int num=Convert.ToInt32(Console.ReadLine());

            int rev = 0;
            int rem = 0;
            int backup = num;
            while(num > 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num= num / 10;
            }
            if(backup==rev)
            {
                Console.WriteLine("It's palindrome");
            }
            else
            {
                Console.WriteLine("It's not a palindrome number");
            }
        }
    }
}