using System;
namespace flip
{
    class program
    {
        public static void Main(string[] args)
        {
            int head=0;
            int tail=0;
            int headcount=0;
            int tailcount=0;

            double headPercentage;
            double tailPercentage;

            Console.WriteLine("Enter the no of flip that you want to");
            int toss=Convert.ToInt32(Console.ReadLine());

           if(toss>0)
            {
                for (int i = 0; i <toss; i++)
                {
                    Random rand = new Random();
                    int num = rand.Next(2);

                    if (num == 1)
                    {
                        head = 1;
                        headcount += head;
                    }
                    else if (num == 0)
                    {
                        tail = 1;
                        tailcount += tail;
                    }
                    Console.WriteLine(num);
                }
                    int total = headcount + tailcount;
                    
                    headPercentage = (headcount * 100) / total;
                    tailPercentage = (tailcount * 100) / total;

                    Console.WriteLine("HEAD PERCENTAGE = " + headPercentage);
                    Console.WriteLine("TAIL PERCENTAGE = " + tailPercentage);

               
            }
           

        }

    }
}