using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Conversion
{
    class Temp
    {
        public void CelToFar()
        {
            Console.WriteLine("Enter the celcius temperature");
            int celcius=Convert.ToInt32(Console.ReadLine());

            double farhenheit = (celcius * 9) / 5 + 32;
            Console.WriteLine("Farheit would be "+farhenheit);

        }

        public void FarToCel()
        {
            Console.WriteLine("Enter the farheinheit temperature");
            int farheinheit = Convert.ToInt32(Console.ReadLine());

            double celcius = (farheinheit - 32) * 5 / 9;
            Console.WriteLine("Celcius would be "+celcius);

        }
    }
}
