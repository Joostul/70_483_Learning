using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            //var del1 = new WorkPerformedHandler(WorkPerformed1);
            //var del2 = new WorkPerformedHandler(WorkPerformed2);
            //var del3 = new WorkPerformedHandler(WorkPerformed3);

            //del1 += del2 + del3;

            var worker = new Worker();
            worker.WorkPerformed += Worker_WorkPerformed;
            worker.WorkCompleted += delegate(object sender, EventArgs e)
            {
                Console.WriteLine("Work was completed for this day.");
            };
            worker.DoWork(8, WorkType.SoftwareEngineering);

            //var delResult = del1(8, WorkType.GoToMeetings);

            Console.ReadKey();
        }

        private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"On hour {e.Hours.ToString()} {e.WorkType.ToString()} was performed by {sender}.");
        }

        //static int WorkPerformed1(int hours, WorkType workType)
        //{
        //    Console.WriteLine($"WorkPerformed1 called with {hours} hours and type: {workType}!");
        //    return hours + 1;
        //}

        //static int WorkPerformed2(int hours, WorkType workType)
        //{
        //    Console.WriteLine($"WorkPerformed2 called with {hours} hours and type: {workType}!");
        //    return hours + 2;
        //}

        //static int WorkPerformed3(int hours, WorkType workType)
        //{
        //    Console.WriteLine($"WorkPerformed3 called with {hours} hours and type: {workType}!");
        //    return hours + 3;
        //}
    }
}