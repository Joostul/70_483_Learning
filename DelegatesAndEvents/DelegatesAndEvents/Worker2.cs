using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    public class Worker2
    {
        public Action<int, WorkType> WorkPerformed;

        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                WorkPerformed(i + 1, workType);
            }
        }
    }
}
