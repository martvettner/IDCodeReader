using System;
using System.Globalization;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = "interpolation";
            Console.WriteLine($"{someString.Length}");
            string NewString = someString.Substring(0, 5);
            Console.WriteLine(NewString);
            string polastring = someString.Substring(5, 8);
            Console.WriteLine(polastring);
        }
    }
}
