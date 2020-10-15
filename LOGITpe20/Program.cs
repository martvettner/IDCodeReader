using System;

namespace LOGITpe20
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayLOGIT();
        }
        public static void DisplayLOGIT()
        {
            string newString = "LOGITpe20";
            
            string log = newString.Substring(0, 5);
            string pe = newString.Substring(5, 2);
            string num = newString.Substring(7, 2);
            Console.WriteLine(log);
            Console.WriteLine(pe);
            Console.WriteLine(num);
        }
        
    }
}
