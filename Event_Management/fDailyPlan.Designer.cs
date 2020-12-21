
namespace Event_Management
{
    partial class fDailyPlan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEvent = new System.Windows.Forms.Panel();
            this.dtpkDay = new System.Windows.Forms.DateTimePicker();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mnsiAddEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsiDayNow = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPreviousDay = new System.Windows.Forms.Button();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.mnsMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlEvent);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 487);
            this.panel1.TabIndex = 0;
            // 
            // pnlEvent
            // 
            this.pnlEvent.Location = new System.Drawing.Point(4, 41);
            this.pnlEvent.Name = "pnlEvent";
            this.pnlEvent.Size = new System.Drawing.Size(505, 458);
            this.pnlEvent.TabIndex = 0;
            // 
            // dtpkDay
            // 
            this.dtpkDay.Location = new System.Drawing.Point(126, 3);
            this.dtpkDay.Name = "dtpkDay";
            this.dtpkDay.Size = new System.Drawing.Size(254, 22);
            this.dtpkDay.TabIndex = 1;
            // 
            // mnsMain
            // 
            this.mnsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsiAddEvent,
            this.mnsiDayNow});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(536, 30);
            this.mnsMain.TabIndex = 1;
            this.mnsMain.Text = "menuStrip1";
            // 
            // mnsiAddEvent
            // 
            this.mnsiAddEvent.Name = "mnsiAddEvent";
            this.mnsiAddEvent.Size = new System.Drawing.Size(90, 26);
            this.mnsiAddEvent.Text = "Thêm việc";
            // 
            // mnsiDayNow
            // 
            this.mnsiDayNow.Name = "mnsiDayNow";
            this.mnsiDayNow.Size = new System.Drawing.Size(83, 26);
            this.mnsiDayNow.Text = "Hôm nay";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNextDay);
            this.panel3.Controls.Add(this.btnPreviousDay);
            this.panel3.Controls.Add(this.dtpkDay);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 31);
            this.panel3.TabIndex = 1;
            // 
            // btnPreviousDay
            // 
            this.btnPreviousDay.Location = new System.Drawing.Point(14, 2);
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Size = new System.Drawing.Size(106, 26);
            this.btnPreviousDay.TabIndex = 2;
            this.btnPreviousDay.Text = "Hôm qua";
            this.btnPreviousDay.UseVisualStyleBackColor = true;
            // 
            // btnNextDay
            // 
            this.btnNextDay.Location = new System.Drawing.Point(386, 2);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(106, 26);
            this.btnNextDay.TabIndex = 3;
            this.btnNextDay.Text = "Ngày mai";
            this.btnNextDay.UseVisualStyleBackColor = true;
            // 
            // fDailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnsMain);
            this.MainMenuStrip = this.mnsMain;
            this.Name = "fDailyPlan";
            this.Text = "Lịch trong ngày";
            this.panel1.ResumeLayout(false);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNextDay;
        private System.Windows.Forms.Button btnPreviousDay;
        private System.Windows.Forms.DateTimePicker dtpkDay;
        private System.Windows.Forms.Panel pnlEvent;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem mnsiAddEvent;
        private System.Windows.Forms.ToolStripMenuItem mnsiDayNow;
    }
}