using System;
namespace Perfect_Number;
public class Exercise28
{
    public static void Main()
    {


        Console.Write("Find perfect numbers within a given number of range:\n");
        Console.Write("\n\n");

        Console.Write("Enter the number :");
        int num=Convert.ToInt32(Console.ReadLine());

        int i, sum = 0;
        for(i = 1; i < num; i++)
        {
            if(num%i==0)
            {
                sum = sum + i;
            }
        }
        if(sum==num)
        {
            Console.WriteLine("The {num} is a perfect number");
        }
        else
        {
            Console.WriteLine("NOT A PERFECT NUMBER");
        }
    }
}
