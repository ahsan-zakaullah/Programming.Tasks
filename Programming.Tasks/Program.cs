using System;

namespace Programming.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Number");
            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result of {0} is .. ", val);
            //MindStromTasks.PrintFactorial(val);
            //MindStromTasks.PrintTriangle(val);
            //MindStromTasks.PrintStar(val);
            MindStromTasks.FindLowestDecimal(val);
        }
    }
}
