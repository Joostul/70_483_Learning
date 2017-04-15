using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {

            var worker = new Worker();
            worker.WorkPerformed += Worker_WorkPerformed;
            worker.WorkCompleted += delegate(object sender, EventArgs e)
            {
                Console.WriteLine("Work was completed for this day.");
            };
            worker.DoWork(8, WorkType.SoftwareEngineering);

            Console.ReadKey();
        }

        private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"On hour {e.Hours.ToString()} {e.WorkType.ToString()} was performed by {sender}.");
        }
    }
}