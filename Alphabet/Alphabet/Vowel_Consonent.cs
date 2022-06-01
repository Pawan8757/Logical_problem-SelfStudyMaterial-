using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
   public class Vowel_Consonent
    {
        public void find()
        {
            Console.WriteLine("Enter any character");
            char ch = Convert.ToChar(Console.ReadLine());

            if(ch=='a' || ch=='e' || ch=='i' || ch=='o' ||ch=='u')
            {
                Console.WriteLine(ch +" is vowel");
            }
           
            else
            {
                Console.WriteLine(ch +" is consonant");
            }
            Console.ReadLine();
        }
    }
}
