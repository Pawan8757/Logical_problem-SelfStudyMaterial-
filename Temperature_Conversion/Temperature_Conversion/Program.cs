using System;

namespace Temperature_Conversion
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("this is the temperature conversion tutorial");
            Temp temp = new Temp();
            temp.FarToCel();
            //temp.CelToFar();
        }
    }
}