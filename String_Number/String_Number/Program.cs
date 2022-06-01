using System;

namespace Easy
{
    class program
    {
        public static void Main(string[] args)
        {
            string name = "MOM";
            string rev = "";

            for(int i =name.Length-1;i>=0;i--)
            {
                rev=rev+name[i];
            }
            
           if(rev==name)
            {
                Console.WriteLine("given no is an armstrong number");
            }
            else
            {
                Console.WriteLine("Not an armstrong number");
            }
        }
    }

}