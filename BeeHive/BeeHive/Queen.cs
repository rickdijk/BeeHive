using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHive
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber = 0;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork(string jobToBeDone, int amountOfShifts)
        {
            foreach (Worker worker in workers)
            {
                if (!worker.DoThisJob(jobToBeDone, amountOfShifts))
                    continue;
                return worker.DoThisJob(jobToBeDone, amountOfShifts);
            }
            return false;
        }

        public string WorkTheNextShift(int shiftNumber)
        {
            this.shiftNumber = shiftNumber;
            string shiftReport = $"Report for shift #{shiftNumber}";
            for (int i = 0; i < workers.Length; i++)
            {
                int workerIndex = i + 1;
                if (workers[i].DidYouFinish())
                {
                    shiftReport += $"\r\n Worker #{workerIndex} finished the job";
                }

                if (!String.IsNullOrEmpty(workers[i].CurrentJob))
                {
                    if (workers[i].ShiftsLeft == 1)
                    {
                        shiftReport += $"\r\n Worker #{workerIndex} will be done with '{workers[i].CurrentJob}' " +
                            "after this shift";
                    }
                    else
                    {
                        shiftReport += $"\r\n Worker #{workerIndex} is doing '{workers[i].CurrentJob}' " +
                            $"for {workers[i].ShiftsLeft} more shifts";
                    }
                }
                else
                {
                    shiftReport += $"\r\n Worker #{workerIndex} is not working";
                }
            }
            return shiftReport;
        }


    }
}
