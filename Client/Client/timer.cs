using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class timer : Form
    {
        int howMuchTimerWork=0;
        int timeForWorkMinuts=25, timeForWorkSeconds=0, timeForRestMinuts=10, timeForRestSeconds=0;
      
        private void resetButton_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (howMuchTimerWork / 2 != 0)
            {

                if (timeForWorkMinuts > 0 && timeForWorkSeconds > 0)
                {
                    timeForWorkMinuts = (timeForWorkMinuts * 60 + timeForWorkSeconds - 1) / 60;
                    timeForWorkSeconds = (timeForWorkMinuts * 60 + timeForWorkSeconds - 1) % 60;
                    timerMin.Text = timeForWorkMinuts.ToString();
                    timerSec.Text = timeForWorkSeconds.ToString();

                }
                else
                {
                    timeForWorkMinuts = 25;
                    timeForWorkSeconds = 0;
                    howMuchTimerWork++;
                }
            }
            else
            {
                if (timeForRestMinuts > 0 && timeForRestSeconds > 0)
                {
                    timeForRestMinuts = (timeForRestMinuts * 60 + timeForRestSeconds - 1) / 60;
                    timeForRestSeconds = (timeForRestMinuts * 60 + timeForRestSeconds - 1) % 60;
                    timerMin.Text = timeForRestMinuts.ToString();
                    timerSec.Text = timeForRestSeconds.ToString();

                }
                else
                {
                    timeForRestMinuts = 10;
                    timeForRestSeconds = 0;
                    howMuchTimerWork++;
                }

            }

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                StartButton.Text = "Старт";
                resetButton.Enabled = true;
            }
            else 
            {
                timer1.Enabled = true;
                StartButton.Text = "Стоп";
                resetButton.Enabled = false;
            }
        }

        private void timer_Load(object sender, EventArgs e)
        {
           

        }

        public timer()
        {
            InitializeComponent();
            timer1.Interval = 500;
            timerMin.Text = timeForWorkMinuts.ToString();
            timerSec.Text = timeForWorkSeconds.ToString();


        }
    }
}
