using System;
using System.Security.Cryptography.X509Certificates;

namespace YearValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year were you born?");
            string userInput = Console.ReadLine();

            if (Validate(userInput))
            {
                CalculateAge(userInput);
            }
        }
        public static bool Validate(string YearInput)
        {
            if(YearInput.Length == 4)
            {
                try
                {
                    Int32.Parse(YearInput);
                    return true;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error);
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Wrong format");
                return false;
            }
          
        }
        public static void CalculateAge(string YearInput)
        {
            int Year = Int32.Parse(YearInput);

            DateTime now = DateTime.Now;
            string currentYear = now.Year.ToString();
            int YearNow = Int32.Parse(currentYear);
            int age = YearNow - Year;

            Console.WriteLine($"You are {age} Years old");
        }

        }

    }


