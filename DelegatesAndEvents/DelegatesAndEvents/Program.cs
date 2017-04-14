using System;

namespace DelegatesAndEvents
{
    public delegate int WorkPerformedHandler(int hours, WorkType workType);

    class Program
    {
        static void Main(string[] args)
        {
            var del1 = new WorkPerformedHandler(WorkPerformed1);
            var del2 = new WorkPerformedHandler(WorkPerformed2);
            var del3 = new WorkPerformedHandler(WorkPerformed3);

            del1 += del2 + del3;

            var delResult = del1(8, WorkType.GoToMeetings);

            Console.ReadKey();
        }

        static int WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed1 called with {hours} hours and type: {workType}!");
            return hours + 1;
        }

        static int WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed2 called with {hours} hours and type: {workType}!");
            return hours + 2;
        }

        static int WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed3 called with {hours} hours and type: {workType}!");
            return hours + 3;
        }
    }
}