using System;
namespace tutorial
{
    class program
    {
        public static void Main(string[] args)
        {
            string str1 = "reheat";
            string str2 = "heater";

            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Since length are different so it can't be anagram");
            }
            else
            {
                char[] ch1 = str1.ToLower().ToCharArray();
                char[] ch2 = str2.ToLower().ToCharArray();

                Array.Sort(ch1);
                Array.Sort(ch2);
                

                if (Array.Equals(ch2, ch1))
                {
                    Console.WriteLine("it's an anagram");
                }
                else
                {
                    Console.WriteLine("Not an anagram");
                }
            }
        }
    }
}
