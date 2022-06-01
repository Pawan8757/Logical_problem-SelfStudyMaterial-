using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
    public  class Upper_Lower
    {
        public void FindOut()
        {
            Console.WriteLine("Enter any character");
            char ch=Convert.ToChar(Console.ReadLine());

            if(ch>=65 && ch<=97)
            {
                Console.WriteLine("uppercase");
            }
            else 
            {
                Console.WriteLine("Lowercase");
            }
        }
    }
}
