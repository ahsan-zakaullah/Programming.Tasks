using System;

namespace Programming.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please Enter the Number");
            //int val = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Result of {0} is .. ", val);
            //MindStromTasks.PrintFactorial(val);
            //MindStromTasks.PrintTriangle(val);
            //MindStromTasks.PrintStar(val);
            //MindStromTasks.FindLowestDecimal(val);
            int[] array = { -3, 1, 2, -2, 5, 6 };
            var result = MindStromTasks.MaximalTripletCount(array);
            var testMap = new StringMap<Customer>();

            var r = testMap.AddElement("A", new Customer() { Name = "Ahsan" });
            var count = testMap.Count;
            var d = testMap.DefaultValue;
            d = testMap.GetValue("B");
            var rr = testMap.RemoveElement("A");

        }
    }
}
