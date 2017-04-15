using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
            worker.WorkPerformed += (sender, e) => 
                Console.WriteLine($"On hour {e.Hours.ToString()} {e.WorkType.ToString()} was performed by {sender}.");
            worker.WorkCompleted += (sender, e) =>
                Console.WriteLine("Work was completed for this day.");
            worker.DoWork(8, WorkType.SoftwareEngineering);

            Console.ReadKey();
        }
    }
}