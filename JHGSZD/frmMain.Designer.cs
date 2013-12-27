namespace JHGSZD
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFUtime = new System.Windows.Forms.Button();
            this.btnQueryFU = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNJ = new System.Windows.Forms.Button();
            this.btnBB = new System.Windows.Forms.Button();
            this.btnJN = new System.Windows.Forms.Button();
            this.btnTJ = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSysDate = new System.Windows.Forms.Label();
            this.lblSysTime = new System.Windows.Forms.Label();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.lblTiTle = new System.Windows.Forms.Label();
            this.pnl_TJ = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_JN = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pnl_NJ = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.pnl_BB = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.pnl_TJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_JN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pnl_NJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.pnl_BB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnFUtime);
            this.panel1.Controls.Add(this.btnQueryFU);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox16);
            this.panel1.Controls.Add(this.lblTiTle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 97);
            this.panel1.TabIndex = 2;
            // 
            // btnFUtime
            // 
            this.btnFUtime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFUtime.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFUtime.Location = new System.Drawing.Point(728, 58);
            this.btnFUtime.Name = "btnFUtime";
            this.btnFUtime.Size = new System.Drawing.Size(120, 37);
            this.btnFUtime.TabIndex = 1;
            this.btnFUtime.Text = "风雨实时显示";
            this.btnFUtime.UseVisualStyleBackColor = true;
            this.btnFUtime.Visible = false;
            this.btnFUtime.Click += new System.EventHandler(this.btnFUtime_Click);
            // 
            // btnQueryFU
            // 
            this.btnQueryFU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueryFU.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQueryFU.Location = new System.Drawing.Point(859, 58);
            this.btnQueryFU.Name = "btnQueryFU";
            this.btnQueryFU.Size = new System.Drawing.Size(120, 37);
            this.btnQueryFU.TabIndex = 1;
            this.btnQueryFU.Text = "风、雨记录查询";
            this.btnQueryFU.UseVisualStyleBackColor = true;
            this.btnQueryFU.Click += new System.EventHandler(this.btnQueryFU_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(978, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 37);
            this.button5.TabIndex = 1;
            this.button5.Text = "设备记录查询";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnNJ);
            this.panel3.Controls.Add(this.btnBB);
            this.panel3.Controls.Add(this.btnJN);
            this.panel3.Controls.Add(this.btnTJ);
            this.panel3.Location = new System.Drawing.Point(185, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 41);
            this.panel3.TabIndex = 2;
            // 
            // btnNJ
            // 
            this.btnNJ.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNJ.Location = new System.Drawing.Point(356, 0);
            this.btnNJ.Name = "btnNJ";
            this.btnNJ.Size = new System.Drawing.Size(120, 37);
            this.btnNJ.TabIndex = 1;
            this.btnNJ.Text = "上海局（南京）";
            this.btnNJ.UseVisualStyleBackColor = true;
            this.btnNJ.Click += new System.EventHandler(this.btnTJ_Click);
            // 
            // btnBB
            // 
            this.btnBB.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBB.Location = new System.Drawing.Point(238, -1);
            this.btnBB.Name = "btnBB";
            this.btnBB.Size = new System.Drawing.Size(120, 37);
            this.btnBB.TabIndex = 0;
            this.btnBB.Text = "上海局（蚌埠）";
            this.btnBB.UseVisualStyleBackColor = true;
            this.btnBB.Click += new System.EventHandler(this.btnTJ_Click);
            // 
            // btnJN
            // 
            this.btnJN.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnJN.Location = new System.Drawing.Point(120, -1);
            this.btnJN.Name = "btnJN";
            this.btnJN.Size = new System.Drawing.Size(120, 37);
            this.btnJN.TabIndex = 0;
            this.btnJN.Text = "济南局(济南)";
            this.btnJN.UseVisualStyleBackColor = true;
            this.btnJN.Click += new System.EventHandler(this.btnTJ_Click);
            // 
            // btnTJ
            // 
            this.btnTJ.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTJ.Location = new System.Drawing.Point(2, 0);
            this.btnTJ.Name = "btnTJ";
            this.btnTJ.Size = new System.Drawing.Size(120, 37);
            this.btnTJ.TabIndex = 0;
            this.btnTJ.Text = "北京局(天津)";
            this.btnTJ.UseVisualStyleBackColor = true;
            this.btnTJ.Click += new System.EventHandler(this.btnTJ_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblSysDate);
            this.panel2.Controls.Add(this.lblSysTime);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 95);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "系统时间";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSysDate
            // 
            this.lblSysDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSysDate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysDate.ForeColor = System.Drawing.Color.Black;
            this.lblSysDate.Location = new System.Drawing.Point(15, 39);
            this.lblSysDate.Name = "lblSysDate";
            this.lblSysDate.Size = new System.Drawing.Size(148, 23);
            this.lblSysDate.TabIndex = 0;
            this.lblSysDate.Text = "2012-07-16";
            this.lblSysDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSysTime
            // 
            this.lblSysTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSysTime.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysTime.ForeColor = System.Drawing.Color.Black;
            this.lblSysTime.Location = new System.Drawing.Point(15, 62);
            this.lblSysTime.Name = "lblSysTime";
            this.lblSysTime.Size = new System.Drawing.Size(148, 23);
            this.lblSysTime.TabIndex = 0;
            this.lblSysTime.Text = "20:20:20";
            this.lblSysTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox16.Image = global::JHGSZD.Properties.Resources.KTK;
            this.pictureBox16.Location = new System.Drawing.Point(1104, 16);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(178, 62);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 0;
            this.pictureBox16.TabStop = false;
            // 
            // lblTiTle
            // 
            this.lblTiTle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTiTle.Font = new System.Drawing.Font("华文中宋", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTiTle.Location = new System.Drawing.Point(233, 6);
            this.lblTiTle.Name = "lblTiTle";
            this.lblTiTle.Size = new System.Drawing.Size(815, 49);
            this.lblTiTle.TabIndex = 0;
            this.lblTiTle.Text = "京沪高铁防灾安全监控系统";
            this.lblTiTle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_TJ
            // 
            this.pnl_TJ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_TJ.BackColor = System.Drawing.Color.Black;
            this.pnl_TJ.Controls.Add(this.panel4);
            this.pnl_TJ.Controls.Add(this.dataGridView1);
            this.pnl_TJ.ForeColor = System.Drawing.Color.White;
            this.pnl_TJ.Location = new System.Drawing.Point(2, 98);
            this.pnl_TJ.Name = "pnl_TJ";
            this.pnl_TJ.Size = new System.Drawing.Size(846, 418);
            this.pnl_TJ.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(634, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 282);
            this.panel4.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(625, 282);
            this.dataGridView1.TabIndex = 1;
            // 
            // pnl_JN
            // 
            this.pnl_JN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_JN.BackColor = System.Drawing.Color.Black;
            this.pnl_JN.Controls.Add(this.panel5);
            this.pnl_JN.Controls.Add(this.dataGridView2);
            this.pnl_JN.ForeColor = System.Drawing.Color.White;
            this.pnl_JN.Location = new System.Drawing.Point(205, 110);
            this.pnl_JN.Name = "pnl_JN";
            this.pnl_JN.Size = new System.Drawing.Size(1041, 410);
            this.pnl_JN.TabIndex = 4;
            this.pnl_JN.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(653, 107);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(193, 286);
            this.panel5.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 107);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(625, 286);
            this.dataGridView2.TabIndex = 3;
            // 
            // pnl_NJ
            // 
            this.pnl_NJ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_NJ.BackColor = System.Drawing.Color.Black;
            this.pnl_NJ.Controls.Add(this.dataGridView3);
            this.pnl_NJ.ForeColor = System.Drawing.Color.White;
            this.pnl_NJ.Location = new System.Drawing.Point(381, 120);
            this.pnl_NJ.Name = "pnl_NJ";
            this.pnl_NJ.Size = new System.Drawing.Size(658, 400);
            this.pnl_NJ.TabIndex = 4;
            this.pnl_NJ.Visible = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 97);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(625, 282);
            this.dataGridView3.TabIndex = 2;
            // 
            // pnl_BB
            // 
            this.pnl_BB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_BB.BackColor = System.Drawing.Color.Black;
            this.pnl_BB.Controls.Add(this.dataGridView4);
            this.pnl_BB.ForeColor = System.Drawing.Color.White;
            this.pnl_BB.Location = new System.Drawing.Point(531, 123);
            this.pnl_BB.Name = "pnl_BB";
            this.pnl_BB.Size = new System.Drawing.Size(638, 397);
            this.pnl_BB.TabIndex = 4;
            this.pnl_BB.Visible = false;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(2, 94);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(625, 282);
            this.dataGridView4.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1282, 538);
            this.Controls.Add(this.pnl_BB);
            this.Controls.Add(this.pnl_NJ);
            this.Controls.Add(this.pnl_TJ);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_JN);
            this.Name = "frmMain";
            this.Text = "京沪高铁防灾系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.pnl_TJ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_JN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pnl_NJ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.pnl_BB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSysDate;
        private System.Windows.Forms.Label lblSysTime;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label lblTiTle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNJ;
        private System.Windows.Forms.Button btnBB;
        private System.Windows.Forms.Button btnJN;
        private System.Windows.Forms.Button btnTJ;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnl_TJ;
        private System.Windows.Forms.Panel pnl_JN;
        private System.Windows.Forms.Panel pnl_NJ;
        private System.Windows.Forms.Panel pnl_BB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btnFUtime;
        private System.Windows.Forms.Button btnQueryFU;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}