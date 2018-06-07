using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHive
{
    public partial class Form1 : Form
    {
        Queen queen;
        int thisShift = 0;

        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing",
                            "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" });
            Queen queen = new Queen(workers);
        }

        private void assignJobButton_Click(object sender, EventArgs e)
        {
            string doThisJob = workerBeeJob.ValueMember;
            int numberOfShifts = Decimal.ToInt32(shifts.Value);
            queen.AssignWork(doThisJob, numberOfShifts);
        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            queen.WorkTheNextShift(thisShift + 1);
        }
    }
}
