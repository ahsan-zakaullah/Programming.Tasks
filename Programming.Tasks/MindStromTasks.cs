using System;

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
            for (int i = 1; i <= number; i++)
            {
                for (int j = i; j < 2*number-i; j++)
                {
                    for (int k = 0; k <j; k++)
                    {
                        Console.Write("* ");
                    }
                    
                }
                Console.WriteLine();
            }

        }
    }
}
