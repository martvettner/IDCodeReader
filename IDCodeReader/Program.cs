using System;

namespace IDCodeReader
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your ID code: ");
            string IDcode = Console.ReadLine();
            int IDlength = IDcode.Length;

            if(Validate(IDcode))
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong format");
            }

        }
        public static bool Validate(string IDcode)
        {
            if (IDcode.Length == 11)
            {
                try
                {
                    long.Parse(IDcode);
                    return true;
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Wrong format: {e}");
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        public static void HelloUser(string IDcode)
        {
            int FirstNum = Int32.Parse(IDcode[0].ToString());
            if(FirstNum == 1 || FirstNum == 3 || FirstNum == 5)
            {
                Console.WriteLine("Hello, Sir!");
            }
            else if (FirstNum == 2 || FirstNum == 4 || FirstNum == 6)
            {
                Console.WriteLine("Hello Madam!");
            }

        }

    }
}
