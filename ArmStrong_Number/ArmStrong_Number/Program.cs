using System;
namespace number
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a valid input");
            int num=Convert.ToInt32(Console.ReadLine());

            int result = 0;
            int temp = num;
            int rem = 0;
            while(temp!=0)
            {
                rem = temp % 10;
                result += rem * rem * rem;
                temp = temp / 10;
            }
            if(num==result)
            {
                Console.WriteLine("{0} is a armstrong number",num);
            }
            else
            {
                Console.WriteLine("{0} is not an armstrong number", num);
            }
        }
    }
}