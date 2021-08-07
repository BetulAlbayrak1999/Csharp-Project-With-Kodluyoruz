using System;

namespace C__pratic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion
            int i = 7;
            float i2 = i;
            Console.WriteLine("i is from int to float (Implicit Conversion): " + y);
            //Explicit Conversion
            float x = 7.7F;
            int y = Convert.ToInt16(x);
            Console.WriteLine("y is from float to int: " + y);

            string s = "20";
            int s2 = Convert.ToInt16(s);
            Console.WriteLine("s2 is from string to int: " + s2);

            DateTime dt = DateTime.Now;
            string dt2 = dt.ToString();
            Console.WriteLine("dt2 is from dateTime to string: " + dt2);

        }
    }
}
