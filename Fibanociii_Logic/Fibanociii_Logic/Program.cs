using System;
namespace Easy
{
    class program
    {
        public static void Main(string[] args)
        {
            int a = 0,b = 1, c;
            Console.WriteLine(a + " " + b);
            Console.WriteLine("Enter a valid input");
            int num=Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i <=num; i++)
            {
               c = a + b;
               Console.WriteLine(c + " ");
               a = b;
               b = c;
            }
            
        }
    }
}