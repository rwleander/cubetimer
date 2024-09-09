//  cube timer - main form

using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Drawing;
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

        String fileName = "scores.txt";
        DateTime startTime, endTime;
        bool isRunning = false;


        //  on load, set up list view

        private void mainForm_Load(object sender, EventArgs e)
        {
            lvData.Columns.Clear();
            lvData.Columns.Add("time", 150, HorizontalAlignment.Center);
            lvData.Columns.Add("Date", 400, HorizontalAlignment.Left);
            LoadScores();
        }

        //  on click of start, start the timer
        //  if timer running, stop the timer and display the message

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isRunning == true)
            {
                endTime = DateTime.Now;
                TimeSpan diff = endTime - startTime;
                int mm = diff.Minutes;
                int ss = diff.Seconds;
                isRunning = false;
                String msg = "Your time is " + mm.ToString() + ":" + ss.ToString() + "\n\nDo you want to save your time?";
                if (MessageBox.Show(msg, "Cube Timer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PostTime(mm, ss);
                }
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

        //------------------
        //  private methods

        //  load list view with scores file

        private void LoadScores()
        {
            TextReader rdr;
            ListViewItem lvItem;
            String buff, timeString, dateString;
            int i;

            //  clear the list and open the file

            lvData.Items.Clear();

            try
            {
                rdr = File.OpenText(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot load scores - " + ex.Message);
                return;
            }

            //  load the file

            buff = rdr.ReadLine();
            while (buff != null)
            {
                i = buff.IndexOf(" ");
                if (i > 0)
                {
                    timeString = buff.Substring(0, i).Trim(); ;
                    dateString = buff.Substring(i, buff.Length - i).Trim();
                }
                else
                {
                    timeString = buff;
                    dateString = "";
                }

                lvItem = new ListViewItem(timeString);
                lvItem.SubItems.Add(dateString);
                lvItem.Tag = buff;
                lvData.Items.Add(lvItem);
                buff = rdr.ReadLine();
            }

            rdr.Close();
        }

        //  add time to list

        private void PostTime(int mm, int ss)
        {
            ListViewItem lvItem;
            String timeString = mm.ToString() + ":" + ss.ToString();
            String dateString = DateTime.Now.ToString();
            lvItem = new ListViewItem(timeString);
            lvItem.SubItems.Add(dateString);
            lvItem.Tag = timeString + " " + dateString;
            lvData.Items.Add(lvItem);

            SaveScores();
        }

        //  save scores

        private void SaveScores()
        {
            TextWriter wrtr;
            ListViewItem lvItem;
            int i = 0;

            try
            {
                wrtr = File.CreateText(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file - " + ex.Message);
                return;
            }

            while ((i < lvData.Items.Count) && (i < 10))
            {
                lvItem = lvData.Items[i];
                wrtr.WriteLine(lvItem.Tag);
                i++;
            }

            wrtr.Close();
        }

    }
}

