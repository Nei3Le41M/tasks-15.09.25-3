using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace tasks_15._09._25__3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelTime = new Label();
            buttonStart = new Button();
            buttonStop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pause = new Button();
            save = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // labelTime
            // 
            labelTime.BackColor = Color.FromArgb(0, 0, 64);
            labelTime.Font = new System.Drawing.Font("Segoe UI", 50F, FontStyle.Bold);
            labelTime.ForeColor = SystemColors.Control;
            labelTime.Location = new Point(90, 9);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(496, 107);
            labelTime.TabIndex = 0;
            labelTime.Text = "00:00:00";
            labelTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.DarkViolet;
            buttonStart.FlatStyle = FlatStyle.Popup;
            buttonStart.Font = new System.Drawing.Font("DIN", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStart.ForeColor = Color.Transparent;
            buttonStart.Location = new Point(12, 158);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(160, 60);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Старт";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = Color.DarkViolet;
            buttonStop.FlatStyle = FlatStyle.Popup;
            buttonStop.Font = new System.Drawing.Font("DIN", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStop.ForeColor = Color.White;
            buttonStop.Location = new Point(510, 158);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(160, 60);
            buttonStop.TabIndex = 2;
            buttonStop.Text = "Стоп";
            buttonStop.UseVisualStyleBackColor = false;
            buttonStop.Click += buttonStop_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pause
            // 
            pause.BackColor = Color.DarkViolet;
            pause.FlatStyle = FlatStyle.Popup;
            pause.Font = new System.Drawing.Font("DIN", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pause.ForeColor = Color.White;
            pause.Location = new Point(344, 158);
            pause.Name = "pause";
            pause.Size = new Size(160, 60);
            pause.TabIndex = 3;
            pause.Text = "Пауза";
            pause.UseVisualStyleBackColor = false;
            pause.Click += pause_Click;
            // 
            // save
            // 
            save.BackColor = Color.DarkViolet;
            save.FlatStyle = FlatStyle.Popup;
            save.Font = new System.Drawing.Font("DIN", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save.ForeColor = Color.White;
            save.Location = new Point(178, 158);
            save.Name = "save";
            save.Size = new Size(160, 60);
            save.TabIndex = 4;
            save.Text = "Интервал";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(0, 0, 64);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new System.Drawing.Font("Segoe UI", 15F);
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 35;
            listBox1.Location = new Point(291, 300);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(89, 140);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(680, 452);
            Controls.Add(listBox1);
            Controls.Add(save);
            Controls.Add(pause);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(labelTime);
            Name = "Form1";
            Text = "Секундомер";
            ResumeLayout(false);
        }

        #endregion

        private Label labelTime;
        private Button buttonStart;
        private Button buttonStop;
        private System.Windows.Forms.Timer timer1;
        private Button pause;
        private Button save;
        private ListBox listBox1;
    }
}
