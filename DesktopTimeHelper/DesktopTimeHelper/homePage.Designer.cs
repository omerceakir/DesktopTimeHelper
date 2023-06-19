namespace DesktopTimeHelper
{
    partial class homePage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.tbxHour = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimeRun = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rLogout = new System.Windows.Forms.RadioButton();
            this.rSleep = new System.Windows.Forms.RadioButton();
            this.rRestart = new System.Windows.Forms.RadioButton();
            this.rShutDown = new System.Windows.Forms.RadioButton();
            this.rTakeTime = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxMinute = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblMinute);
            this.groupBox1.Controls.Add(this.lblHour);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(10, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(224, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = ".";
            // 
            // lblSn
            // 
            this.lblSn.AutoSize = true;
            this.lblSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSn.Location = new System.Drawing.Point(260, 22);
            this.lblSn.Name = "lblSn";
            this.lblSn.Size = new System.Drawing.Size(104, 73);
            this.lblSn.TabIndex = 3;
            this.lblSn.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(101, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 73);
            this.label3.TabIndex = 2;
            this.label3.Text = ".";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMinute.Location = new System.Drawing.Point(137, 22);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(104, 73);
            this.lblMinute.TabIndex = 1;
            this.lblMinute.Text = "00";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHour.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHour.Location = new System.Drawing.Point(14, 22);
            this.lblHour.Name = "lblHour";
            this.lblHour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHour.Size = new System.Drawing.Size(104, 73);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "00";
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.Location = new System.Drawing.Point(278, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 31);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestart.Location = new System.Drawing.Point(278, 59);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(88, 31);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // tbxHour
            // 
            this.tbxHour.Location = new System.Drawing.Point(153, 14);
            this.tbxHour.MaxLength = 2;
            this.tbxHour.Name = "tbxHour";
            this.tbxHour.Size = new System.Drawing.Size(41, 26);
            this.tbxHour.TabIndex = 4;
            this.tbxHour.Text = "01";
            this.tbxHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimeRun);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnRestart);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(10, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 141);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnTimeRun
            // 
            this.btnTimeRun.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimeRun.Location = new System.Drawing.Point(278, 96);
            this.btnTimeRun.Name = "btnTimeRun";
            this.btnTimeRun.Size = new System.Drawing.Size(88, 31);
            this.btnTimeRun.TabIndex = 10;
            this.btnTimeRun.Text = "TIMER";
            this.btnTimeRun.UseVisualStyleBackColor = true;
            this.btnTimeRun.Click += new System.EventHandler(this.btnTimeRun_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rLogout);
            this.groupBox4.Controls.Add(this.rSleep);
            this.groupBox4.Controls.Add(this.rRestart);
            this.groupBox4.Controls.Add(this.rShutDown);
            this.groupBox4.Controls.Add(this.rTakeTime);
            this.groupBox4.Location = new System.Drawing.Point(6, 59);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 72);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // rLogout
            // 
            this.rLogout.AutoSize = true;
            this.rLogout.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rLogout.Location = new System.Drawing.Point(152, 43);
            this.rLogout.Name = "rLogout";
            this.rLogout.Size = new System.Drawing.Size(72, 22);
            this.rLogout.TabIndex = 11;
            this.rLogout.Text = "LOGOUT";
            this.rLogout.UseVisualStyleBackColor = true;
            // 
            // rSleep
            // 
            this.rSleep.AutoSize = true;
            this.rSleep.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rSleep.Location = new System.Drawing.Point(201, 17);
            this.rSleep.Name = "rSleep";
            this.rSleep.Size = new System.Drawing.Size(60, 22);
            this.rSleep.TabIndex = 10;
            this.rSleep.Text = "SLEEP";
            this.rSleep.UseVisualStyleBackColor = true;
            // 
            // rRestart
            // 
            this.rRestart.AutoSize = true;
            this.rRestart.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rRestart.Location = new System.Drawing.Point(42, 43);
            this.rRestart.Name = "rRestart";
            this.rRestart.Size = new System.Drawing.Size(74, 22);
            this.rRestart.TabIndex = 9;
            this.rRestart.Text = "RESTART";
            this.rRestart.UseVisualStyleBackColor = true;
            // 
            // rShutDown
            // 
            this.rShutDown.AutoSize = true;
            this.rShutDown.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rShutDown.Location = new System.Drawing.Point(96, 17);
            this.rShutDown.Name = "rShutDown";
            this.rShutDown.Size = new System.Drawing.Size(94, 22);
            this.rShutDown.TabIndex = 8;
            this.rShutDown.Text = "SHUT DOWN";
            this.rShutDown.UseVisualStyleBackColor = true;
            // 
            // rTakeTime
            // 
            this.rTakeTime.AutoSize = true;
            this.rTakeTime.Checked = true;
            this.rTakeTime.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTakeTime.Location = new System.Drawing.Point(5, 17);
            this.rTakeTime.Name = "rTakeTime";
            this.rTakeTime.Size = new System.Drawing.Size(85, 22);
            this.rTakeTime.TabIndex = 6;
            this.rTakeTime.TabStop = true;
            this.rTakeTime.Text = "TAKE TIME";
            this.rTakeTime.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxMinute);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbxHour);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(6, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 46);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // tbxMinute
            // 
            this.tbxMinute.Location = new System.Drawing.Point(202, 14);
            this.tbxMinute.MaxLength = 2;
            this.tbxMinute.Name = "tbxMinute";
            this.tbxMinute.Size = new System.Drawing.Size(41, 26);
            this.tbxMinute.TabIndex = 6;
            this.tbxMinute.Text = "10";
            this.tbxMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hour / Minute :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(392, 254);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "homePage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop Time Helper - C3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox tbxHour;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rLogout;
        private System.Windows.Forms.RadioButton rSleep;
        private System.Windows.Forms.RadioButton rRestart;
        private System.Windows.Forms.RadioButton rShutDown;
        private System.Windows.Forms.RadioButton rTakeTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxMinute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSn;
        private System.Windows.Forms.Button btnTimeRun;
        private System.Windows.Forms.Timer timer2;
    }
}