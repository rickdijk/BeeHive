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
            for (int i = 0; i < workers.Length; i++)
            {
                if(workers[i].DoThisJob)
                {

                }
            }
        }

        public string WorkTheNextShift()
        {

        }


    }
}
