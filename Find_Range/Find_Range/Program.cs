using System;
namespace Easy
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter starting value");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Ending value");
            int j = Convert.ToInt32(Console.ReadLine());
            
            for (int num =i; num <=j; num++)
            {
                int count = 0;

                for (int k=1;k<=num;k++)
                    {
                        if(num%k==0)
                        {
                            count++;
                        }
                    }
                    if(count==2)
                    {
                        Console.WriteLine(fac);
                    }
                    
                }
            Console.ReadLine();
        }
        }
    }