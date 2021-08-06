using System;

namespace C__pratic
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            string s1 = "20";
            int sum = x + Convert.ToInt16(s1);
            Console.WriteLine("sum: " + sum);

            DateTime dt = DateTime.Now;
            Console.WriteLine("DateTime: " + dt);

            string s2 = dt.ToString("yyyy.MM.dd");
            Console.WriteLine("DateTime ToString: " + s2);
        }
    }
}
