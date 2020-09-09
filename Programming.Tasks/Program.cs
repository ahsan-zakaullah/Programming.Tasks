using System;

namespace Programming.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide the number for factorial");
            int val= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial of {0} is .. ",val);
            MindStromTasks.PrintFactorial(val);
            MindStromTasks.PrintTriangle(val);
            MindStromTasks.PrintStar(val);
        }
    }
}
