using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JHGSZD
{
    public partial class frmWindAlm : Form
    {
        public frmWindAlm()
        {
            InitializeComponent();
        }

        int _IntCr;
        public int intCr
        {
            get
            {
                return this._IntCr;
            }
            set
            {
                this._IntCr = value;
            }
        }

        int _IntWi;
        public int intWi
        {
            get
            {
                return this._IntWi;
            }
            set
            {
                this._IntWi = value;
            }
        }

        private string strWindK = "";
        int intAlarm = 0;
        double dblV = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshData();
            timer1.Enabled = true;
        }

        private void refreshData()
        {
            lblWAPtK.Text = clsPublicStatic.windPositionK[intCr, intWi];
            intAlarm = clsPublicStatic.windPositionAlarm[intCr, intWi];
            refreshAlarm();
            lblWAPtTime.Text = gerAlmTime();
            lblWAPtRange.Text = clsPublicStatic.windPositionLimitStartK[intCr, intWi] + " 至 " + clsPublicStatic.windPositionLimitEndK[intCr, intWi];
            lblWindV.Text = clsPublicStatic.windPositionV[intCr, intWi].ToString();
        }

        private string gerAlmTime()
        {
            if (DateTime.Parse(clsPublicStatic.windPositionAlarmTime[intCr, intWi].ToString()).Year < 2010)
            {
                return "";
            }
            return clsPublicStatic.windPositionAlarmTime[intCr, intWi].ToString();
        }

        private void refreshAlarm()
        {
            lblWAPtLevel.Text = intAlarm + " 级";
            if (intAlarm == 0)
            {
                pnlWindAlarmCenter.BackColor = Color.Green;
                lblLimit.Text = "正常";
            }
            else if (intAlarm==1)
            {
                pnlWindAlarmCenter.BackColor = Color.CornflowerBlue;
                lblLimit.Text = "300km/h";
            }
            else if (intAlarm == 2)
            {
                pnlWindAlarmCenter.BackColor = Color.Yellow;
                lblLimit.Text = "200km/h";
            }
            else if (intAlarm == 3)
            {
                pnlWindAlarmCenter.BackColor = Color.Orange;
                lblLimit.Text = "120km/h";
            }
            else if (intAlarm == 4)
            {
                pnlWindAlarmCenter.BackColor = Color.Red;
                lblLimit.Text = "停车";
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            refreshData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void pnlWindAlarmCenter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
