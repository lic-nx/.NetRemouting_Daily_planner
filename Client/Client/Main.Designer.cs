
namespace Client
{
    partial class Main
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
            this.addTask = new System.Windows.Forms.Button();
            this.taskText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timeStartPicker = new System.Windows.Forms.DateTimePicker();
            this.timeEndPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.timeStartLabel = new System.Windows.Forms.Label();
            this.timeEndLabel = new System.Windows.Forms.Label();
            this.taskLabel = new System.Windows.Forms.Label();
            this.deliteButton = new System.Windows.Forms.Button();
            this.deliteTexBox = new System.Windows.Forms.TextBox();
            this.deliteLabel = new System.Windows.Forms.Label();
            this.listAdmin = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.LoginTextbox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TimerTomato = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.timerStartButton = new System.Windows.Forms.Button();
            this.timeStartTextBox = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTask
            // 
            this.addTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTask.Location = new System.Drawing.Point(716, 60);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(201, 47);
            this.addTask.TabIndex = 0;
            this.addTask.Text = "Добавить задачу";
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // taskText
            // 
            this.taskText.Location = new System.Drawing.Point(450, 70);
            this.taskText.Name = "taskText";
            this.taskText.Size = new System.Drawing.Size(237, 26);
            this.taskText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(621, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // datePicker
            // 
            this.datePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(9, 68);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(138, 26);
            this.datePicker.TabIndex = 3;
            // 
            // timeStartPicker
            // 
            this.timeStartPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStartPicker.Location = new System.Drawing.Point(163, 68);
            this.timeStartPicker.Name = "timeStartPicker";
            this.timeStartPicker.ShowUpDown = true;
            this.timeStartPicker.Size = new System.Drawing.Size(111, 26);
            this.timeStartPicker.TabIndex = 4;
            // 
            // timeEndPicker
            // 
            this.timeEndPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEndPicker.Location = new System.Drawing.Point(303, 68);
            this.timeEndPicker.Name = "timeEndPicker";
            this.timeEndPicker.ShowUpDown = true;
            this.timeEndPicker.Size = new System.Drawing.Size(114, 26);
            this.timeEndPicker.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата задачи";
            // 
            // timeStartLabel
            // 
            this.timeStartLabel.AutoSize = true;
            this.timeStartLabel.Location = new System.Drawing.Point(159, 31);
            this.timeStartLabel.Name = "timeStartLabel";
            this.timeStartLabel.Size = new System.Drawing.Size(117, 20);
            this.timeStartLabel.TabIndex = 7;
            this.timeStartLabel.Text = "Время начала";
            // 
            // timeEndLabel
            // 
            this.timeEndLabel.AutoSize = true;
            this.timeEndLabel.Location = new System.Drawing.Point(299, 31);
            this.timeEndLabel.Name = "timeEndLabel";
            this.timeEndLabel.Size = new System.Drawing.Size(106, 20);
            this.timeEndLabel.TabIndex = 8;
            this.timeEndLabel.Text = "Время конца";
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Location = new System.Drawing.Point(446, 30);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(67, 20);
            this.taskLabel.TabIndex = 9;
            this.taskLabel.Text = "Задача";
            // 
            // deliteButton
            // 
            this.deliteButton.Location = new System.Drawing.Point(324, 246);
            this.deliteButton.Name = "deliteButton";
            this.deliteButton.Size = new System.Drawing.Size(201, 47);
            this.deliteButton.TabIndex = 10;
            this.deliteButton.Text = "удалить запись";
            this.deliteButton.UseVisualStyleBackColor = true;
            this.deliteButton.Click += new System.EventHandler(this.deliteButton_Click);
            // 
            // deliteTexBox
            // 
            this.deliteTexBox.Location = new System.Drawing.Point(27, 256);
            this.deliteTexBox.Name = "deliteTexBox";
            this.deliteTexBox.Size = new System.Drawing.Size(181, 26);
            this.deliteTexBox.TabIndex = 11;
            this.deliteTexBox.TextChanged += new System.EventHandler(this.deliteTexBox_TextChanged);
            // 
            // deliteLabel
            // 
            this.deliteLabel.AutoSize = true;
            this.deliteLabel.Location = new System.Drawing.Point(23, 204);
            this.deliteLabel.Name = "deliteLabel";
            this.deliteLabel.Size = new System.Drawing.Size(295, 20);
            this.deliteLabel.TabIndex = 12;
            this.deliteLabel.Text = "введите номер задачи для удаления";
            // 
            // listAdmin
            // 
            this.listAdmin.FormattingEnabled = true;
            this.listAdmin.ItemHeight = 20;
            this.listAdmin.Location = new System.Drawing.Point(616, 219);
            this.listAdmin.Name = "listAdmin";
            this.listAdmin.Size = new System.Drawing.Size(333, 224);
            this.listAdmin.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ErrorMessageLabel);
            this.groupBox1.Controls.Add(this.EnterButton);
            this.groupBox1.Controls.Add(this.PasswordTextbox);
            this.groupBox1.Controls.Add(this.LoginTextbox);
            this.groupBox1.Controls.Add(this.PasswordLabel);
            this.groupBox1.Controls.Add(this.loginLabel);
            this.groupBox1.Location = new System.Drawing.Point(293, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 310);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторизация";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(18, 205);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorMessageLabel.TabIndex = 5;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(79, 236);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(168, 30);
            this.EnterButton.TabIndex = 4;
            this.EnterButton.Text = "войти";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(47, 167);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(250, 26);
            this.PasswordTextbox.TabIndex = 3;
            // 
            // LoginTextbox
            // 
            this.LoginTextbox.Location = new System.Drawing.Point(47, 82);
            this.LoginTextbox.Name = "LoginTextbox";
            this.LoginTextbox.Size = new System.Drawing.Size(250, 26);
            this.LoginTextbox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(108, 127);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(139, 20);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Введите пароль ";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(108, 37);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(122, 20);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "введите логин";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.timeStartLabel);
            this.groupBox2.Controls.Add(this.addTask);
            this.groupBox2.Controls.Add(this.taskText);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.datePicker);
            this.groupBox2.Controls.Add(this.timeStartPicker);
            this.groupBox2.Controls.Add(this.taskLabel);
            this.groupBox2.Controls.Add(this.timeEndPicker);
            this.groupBox2.Controls.Add(this.timeEndLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(952, 166);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(9, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Включить спонсоров";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimerTomato
            // 
            this.TimerTomato.Interval = 25000;
            this.TimerTomato.Tick += new System.EventHandler(this.TimerTomato_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            // 
            // timerStartButton
            // 
            this.timerStartButton.Location = new System.Drawing.Point(27, 433);
            this.timerStartButton.Name = "timerStartButton";
            this.timerStartButton.Size = new System.Drawing.Size(143, 37);
            this.timerStartButton.TabIndex = 18;
            this.timerStartButton.Text = "начать отсчет";
            this.timerStartButton.UseVisualStyleBackColor = true;
            this.timerStartButton.Click += new System.EventHandler(this.timerStartButton_Click);
            // 
            // timeStartTextBox
            // 
            this.timeStartTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStartTextBox.Location = new System.Drawing.Point(21, 358);
            this.timeStartTextBox.Name = "timeStartTextBox";
            this.timeStartTextBox.ShowUpDown = true;
            this.timeStartTextBox.Size = new System.Drawing.Size(200, 26);
            this.timeStartTextBox.TabIndex = 20;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 626);
            this.Controls.Add(this.timeStartTextBox);
            this.Controls.Add(this.timerStartButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listAdmin);
            this.Controls.Add(this.deliteTexBox);
            this.Controls.Add(this.deliteLabel);
            this.Controls.Add(this.deliteButton);
            this.Name = "Main";
            this.Text = "main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.TextBox taskText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timeStartPicker;
        private System.Windows.Forms.DateTimePicker timeEndPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeStartLabel;
        private System.Windows.Forms.Label timeEndLabel;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Button deliteButton;
        private System.Windows.Forms.TextBox deliteTexBox;
        private System.Windows.Forms.Label deliteLabel;
        private System.Windows.Forms.ListBox listAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox LoginTextbox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer TimerTomato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button timerStartButton;
        private System.Windows.Forms.DateTimePicker timeStartTextBox;
    }
}