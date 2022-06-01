using System;
namespace Easy
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number whose multiplication you want");
            int num=Convert.ToInt32(Console.ReadLine());

            int cube = num * num * num;
            Console.WriteLine(cube);
        }
    }
}