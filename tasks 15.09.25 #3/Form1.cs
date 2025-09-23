
using System;
using System.Windows.Forms;

namespace tasks_15._09._25__3
{
    public partial class Form1 : Form
    {
        private int seconds = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            seconds = 0;
            labelTime.Text = "00:00";
            timer1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            int minutes = seconds / 60;
            int sec = seconds % 60;
            labelTime.Text = $"{minutes:D2}:{sec:D2}";
        }
    }
}


