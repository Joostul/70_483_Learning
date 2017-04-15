using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    public class Worker
    {
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i + 1, workType);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            (WorkPerformed as EventHandler<WorkPerformedEventArgs>)?.Invoke(this, new WorkPerformedEventArgs(hours, workType));
        }

        protected virtual void OnWorkCompleted()
        {
            (WorkCompleted as EventHandler)?.Invoke(this, EventArgs.Empty);
        }
    }
}
