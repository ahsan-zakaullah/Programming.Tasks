using System;
using System.Collections.Generic;
using System.Linq;

namespace Programming.Tasks
{
    public static class MindStromTasks
    {
        public static void PrintFactorial(int number)
        {
            for (int i = number - 1; i > 0; i--)
            {
                number *= i;
            }
            Console.WriteLine(number);
        }

        public static void PrintTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
        public static void PrintStar(int number)
        {
            var temp = number;
            for (int j = 1; j <= number; j++)
            {
                for (int k = 0; k < 2 * temp - 1; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                for (int i = 0; i < j; i++)
                {

                    Console.Write("  ");
                }

                temp--;
            }
        }

        public static void FindLowestDecimal(int number)
        {

            char[] chars=number.ToString().ToCharArray();
            
            // TODO: Need to further dig in
            var result =Convert.ToInt32(chars.Min());
            Console.WriteLine(result);
        }
    }
}
