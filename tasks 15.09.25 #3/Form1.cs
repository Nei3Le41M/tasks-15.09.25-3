using System;
using System.Windows.Forms;

namespace tasks_15._09._25__3
{
    public partial class Form1 : Form
    {
        private int minutes = 0;
        private int seconds = 0;
        private int milliseconds = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 10;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            minutes = 0;
            seconds = 0;
            milliseconds = 0;
            labelTime.Text = "00:00:00";
            listBox1.Items.Clear();
            timer1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            milliseconds += 18;

            if (milliseconds >= 1000)
            {
                milliseconds = 0;
                seconds++;
            }

            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;
            }

            labelTime.Text = $"{minutes:D2}:{seconds:D2}:{milliseconds / 10:D2}";
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                pause.Text = "Продолжить";
            }
            else
            {
                timer1.Start();
                pause.Text = "Пауза";
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string lapTime = $"{minutes:D2}:{seconds:D2}:{milliseconds / 10:D2}";
            listBox1.Items.Add(lapTime);
        }
    }
}