using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {

        public static string GetResponse(int number)
        {
            string response = FizzBuzzGame.BuildResponse(number);

            return response;
        }

        private static string BuildResponse(int number)
        {
            string response = "";

            if (IsMultipleOfThreeOrFive(number))
            {
                response += IsMultipleOfThree(number) ? "fizz" : "";
                response += IsMultipleOfThreeAndFive(number) ? " " : "";
                response += IsMultipleOfFive(number) ? "buzz" : "";
            }
            else
            {
                response += number.ToString();
            }
            return response;
        }

        private static bool IsMultipleOfThree(int number)
        {
            return number % 3 == 0;
        }

        private static bool IsMultipleOfFive(int number)
        {
            return number % 5 == 0;
        }

        private static bool IsMultipleOfThreeOrFive(int number)
        {
            return IsMultipleOfThree(number) || IsMultipleOfFive(number);
        }

        private static bool IsMultipleOfThreeAndFive(int number)
        {
            return IsMultipleOfThree(number) && IsMultipleOfFive(number);
        }
    }
}
