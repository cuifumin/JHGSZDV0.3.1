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
    public partial class frmRainAlm : Form
    {
        public frmRainAlm()
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

        int _IntRi;
        public int intRi
        {
            get
            {
                return this._IntRi;
            }
            set
            {
                this._IntRi = value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshData();
            timer1.Enabled = true;
        }

        private void refreshData()
        {
            lblWAPtK.Text = clsPublicStatic.rainPositionK[intCr, intRi];
            int intAlarm = clsPublicStatic.RainPositionAlarm[intCr, intRi];
            refreshAlarm(intAlarm);
            lblWAPtTime.Text = gerAlmTime();
            lblWAPtRange.Text = clsPublicStatic.rainPositionLimitStartK[intCr, intRi] + " 至 " + clsPublicStatic.rainPositionLimitEndK[intCr, intRi];
            lblRainHour.Text = clsPublicStatic.rainPositionHour[intCr, intRi].ToString()+"mm";
            lblRainDay.Text = clsPublicStatic.rainPositionDay[intCr, intRi].ToString() + "mm";
            lblRainLianxu.Text = clsPublicStatic.rainPositionContinuours[intCr, intRi].ToString() + "mm";
        }

        private string gerAlmTime()
        {
            if (DateTime.Parse(clsPublicStatic.rainPositionAlarmTime[intCr, intRi].ToString()).Year<2010)
            {
                return "";
            }
            return clsPublicStatic.rainPositionAlarmTime[intCr, intRi].ToString();
        }

        private void refreshAlarm(int intAlarm)
        {
            lblWAPtLevel.Text = intAlarm + " 级";
            if (intAlarm == 0)
            {
                pnlWindAlarmCenter.BackColor = Color.Green;
                lblLimit.Text = "正常";
            }
            else if (intAlarm==1)
            {
                pnlWindAlarmCenter.BackColor = Color.Yellow;
                lblLimit.Text = "120km/h";
            }
            else if (intAlarm == 2)
            {
                pnlWindAlarmCenter.BackColor = Color.Orange;
                lblLimit.Text = "45km/h";
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
