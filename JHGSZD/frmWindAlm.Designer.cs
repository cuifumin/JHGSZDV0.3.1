namespace JHGSZD
{
    partial class frmWindAlm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlWindAlarmCenter = new System.Windows.Forms.Panel();
            this.lblWindV = new System.Windows.Forms.Label();
            this.lblWAPtRange = new System.Windows.Forms.Label();
            this.lblWAPtLevel = new System.Windows.Forms.Label();
            this.lblWAPtTime = new System.Windows.Forms.Label();
            this.lblWAPtK = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.pnlWindAlarmCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWindAlarmCenter
            // 
            this.pnlWindAlarmCenter.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlWindAlarmCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlWindAlarmCenter.Controls.Add(this.lblLimit);
            this.pnlWindAlarmCenter.Controls.Add(this.lblWindV);
            this.pnlWindAlarmCenter.Controls.Add(this.lblWAPtRange);
            this.pnlWindAlarmCenter.Controls.Add(this.lblWAPtLevel);
            this.pnlWindAlarmCenter.Controls.Add(this.lblWAPtTime);
            this.pnlWindAlarmCenter.Controls.Add(this.label5);
            this.pnlWindAlarmCenter.Controls.Add(this.label4);
            this.pnlWindAlarmCenter.Controls.Add(this.label6);
            this.pnlWindAlarmCenter.Controls.Add(this.label3);
            this.pnlWindAlarmCenter.Controls.Add(this.label2);
            this.pnlWindAlarmCenter.Controls.Add(this.label1);
            this.pnlWindAlarmCenter.Controls.Add(this.lblWAPtK);
            this.pnlWindAlarmCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWindAlarmCenter.Location = new System.Drawing.Point(0, 0);
            this.pnlWindAlarmCenter.Name = "pnlWindAlarmCenter";
            this.pnlWindAlarmCenter.Size = new System.Drawing.Size(345, 217);
            this.pnlWindAlarmCenter.TabIndex = 2;
            this.pnlWindAlarmCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWindAlarmCenter_Paint);
            // 
            // lblWindV
            // 
            this.lblWindV.BackColor = System.Drawing.Color.Transparent;
            this.lblWindV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWindV.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblWindV.ForeColor = System.Drawing.Color.Black;
            this.lblWindV.Location = new System.Drawing.Point(119, 181);
            this.lblWindV.Name = "lblWindV";
            this.lblWindV.Size = new System.Drawing.Size(136, 28);
            this.lblWindV.TabIndex = 0;
            this.lblWindV.Text = "22222222222";
            this.lblWindV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWAPtRange
            // 
            this.lblWAPtRange.BackColor = System.Drawing.Color.Transparent;
            this.lblWAPtRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWAPtRange.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblWAPtRange.ForeColor = System.Drawing.Color.Black;
            this.lblWAPtRange.Location = new System.Drawing.Point(117, 146);
            this.lblWAPtRange.Name = "lblWAPtRange";
            this.lblWAPtRange.Size = new System.Drawing.Size(223, 28);
            this.lblWAPtRange.TabIndex = 0;
            this.lblWAPtRange.Text = "K8888+888 至 K8888+888";
            this.lblWAPtRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWAPtLevel
            // 
            this.lblWAPtLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblWAPtLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWAPtLevel.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblWAPtLevel.ForeColor = System.Drawing.Color.Black;
            this.lblWAPtLevel.Location = new System.Drawing.Point(119, 41);
            this.lblWAPtLevel.Name = "lblWAPtLevel";
            this.lblWAPtLevel.Size = new System.Drawing.Size(69, 28);
            this.lblWAPtLevel.TabIndex = 0;
            this.lblWAPtLevel.Text = "22222222222";
            this.lblWAPtLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWAPtTime
            // 
            this.lblWAPtTime.BackColor = System.Drawing.Color.Transparent;
            this.lblWAPtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWAPtTime.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblWAPtTime.ForeColor = System.Drawing.Color.Black;
            this.lblWAPtTime.Location = new System.Drawing.Point(119, 111);
            this.lblWAPtTime.Name = "lblWAPtTime";
            this.lblWAPtTime.Size = new System.Drawing.Size(221, 28);
            this.lblWAPtTime.TabIndex = 0;
            this.lblWAPtTime.Text = "22222222222";
            this.lblWAPtTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWAPtK
            // 
            this.lblWAPtK.BackColor = System.Drawing.Color.Transparent;
            this.lblWAPtK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWAPtK.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblWAPtK.ForeColor = System.Drawing.Color.Black;
            this.lblWAPtK.Location = new System.Drawing.Point(117, 6);
            this.lblWAPtK.Name = "lblWAPtK";
            this.lblWAPtK.Size = new System.Drawing.Size(138, 28);
            this.lblWAPtK.TabIndex = 0;
            this.lblWAPtK.Text = "22222222222";
            this.lblWAPtK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "监测点里程";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "报警等级";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "限速值";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "限速范围";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "风速";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "报警时间";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLimit
            // 
            this.lblLimit.BackColor = System.Drawing.Color.Transparent;
            this.lblLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLimit.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblLimit.ForeColor = System.Drawing.Color.Black;
            this.lblLimit.Location = new System.Drawing.Point(119, 76);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(136, 28);
            this.lblLimit.TabIndex = 0;
            this.lblLimit.Text = "22222222222";
            this.lblLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmWindALarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 217);
            this.Controls.Add(this.pnlWindAlarmCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWindALarm";
            this.Text = "风报警";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlWindAlarmCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWindAlarmCenter;
        private System.Windows.Forms.Label lblWindV;
        private System.Windows.Forms.Label lblWAPtRange;
        private System.Windows.Forms.Label lblWAPtLevel;
        private System.Windows.Forms.Label lblWAPtTime;
        private System.Windows.Forms.Label lblWAPtK;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label label6;
    }
}

