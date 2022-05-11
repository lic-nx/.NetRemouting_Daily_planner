
namespace Client
{
    partial class timer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerMin = new System.Windows.Forms.Label();
            this.timerSec = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerMin
            // 
            this.timerMin.AutoSize = true;
            this.timerMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerMin.Location = new System.Drawing.Point(148, 74);
            this.timerMin.Name = "timerMin";
            this.timerMin.Size = new System.Drawing.Size(117, 82);
            this.timerMin.TabIndex = 0;
            this.timerMin.Text = "00";
            // 
            // timerSec
            // 
            this.timerSec.AutoSize = true;
            this.timerSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerSec.Location = new System.Drawing.Point(332, 74);
            this.timerSec.Name = "timerSec";
            this.timerSec.Size = new System.Drawing.Size(115, 82);
            this.timerSec.TabIndex = 1;
            this.timerSec.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(271, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 82);
            this.label3.TabIndex = 2;
            this.label3.Text = ":";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(91, 218);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(174, 35);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Пуск";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(295, 218);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(174, 35);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Сброс";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timerSec);
            this.Controls.Add(this.timerMin);
            this.Name = "timer";
            this.Text = "timer";
            this.Load += new System.EventHandler(this.timer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label timerMin;
        private System.Windows.Forms.Label timerSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button resetButton;
    }
}