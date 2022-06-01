using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number
{
    public class Findout
    {
        public void calcultingHarmonic()
        {
            Console.WriteLine("Enter the valid input");
            int num= Convert.ToInt32(Console.ReadLine());
          
            double harmonic = 0.0;
            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine("1/{0}", i);
                harmonic = harmonic + 1/(float)i;
            }
            Console.WriteLine("\n \n");

            Console.WriteLine("the harmonic value of {num} are " + harmonic);
        }
    }
}
