using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab
{
    public class Validator
    {

        public static int GetPositiveInputInt()
        {
            int result = -1;
            while (int.TryParse(Console.ReadLine(), out result) == false || result <= 0)
            {
                Console.WriteLine("Invalid input, try again with a positive number.");
            }
            return result;
        }

        public static bool GetContinue()
        {
            bool result = false;
            while (true)
            {
                Console.WriteLine("Would you like to run again? y/n");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
            return result;
        }
        public static bool GetContinue(string message)
        {
            bool result = false;
            while (true)
            {
                Console.WriteLine($"{message} y/n");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
            return result;

        }



            public static bool numberCheck(int x, int y)
        {
            if (x > y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }








    }
}
