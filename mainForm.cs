//  cube timer - main form

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cubeTimer
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
                        InitializeComponent();
        }

        //  variables

        DateTime startTime, endTime; 
        bool isRunning = false;


        //  on load, set up list view

                private void mainForm_Load(object sender, EventArgs e)
        {
            lvData.Columns.Clear();
            lvData.Columns.Add("time", 150, HorizontalAlignment.Center);
            lvData.Columns.Add("Date", 400, HorizontalAlignment.Left);
            lvData.Items.Clear();
        }

        //  on click of start, start the timer
        //  if timer running, stop the timer and display the message

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isRunning == true)
            {
                endTime = DateTime.Now;
                TimeSpan diff = endTime- startTime;
                int mm = diff.Minutes;
                int ss = diff.Seconds;
                isRunning = false;
                MessageBox.Show("Your time is " + mm.ToString() + ":" + ss.ToString());
                btnStart.Text = "Start Timer";
                btnClose.Text = "Close";
            }
            else
            {
                startTime = DateTime.Now;
                btnStart.Text = "Stop Timer";
                btnClose.Text = "Cancel";
                isRunning = true;
            }                                
        }


        //  close the program
        //'  if timer is running, cancel the timer

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isRunning == true)
            {
                isRunning = false;
                btnStart.Text = "Start Timer";
                btnClose.Text = "Close";
            }
            else
            { 
            Close();
        }
        }

}
    }

