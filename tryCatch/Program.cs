using System;

namespace C__pratic
{
    class Program
    {
        static void Main(string[] args)
        {

            try{
                string s = Console.ReadLine();
                int i = Convert.ToInt16(s);
                Console.WriteLine("i is from string to int (explicit Conversion): " + i);
            }  
            catch(Exception ex){
                Console.WriteLine("your entered is wrong");
                Console.WriteLine(ex);
            }  
            finally{
                  Console.WriteLine("your operation is completed");   
            }
        }
    }
}
