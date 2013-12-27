using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JHGSZD
{
    public partial class frmLiveFU : Form
    {
        Font font_Label = new Font("Calibri", 12);
        double dblRainYMax = 60;
        double dblRainYInterval = 10;
        double dblRainAlarm = 12;

        double[] dbl_V = new double[100];
        double[] dbl_R = new double[100];

        bool bWindStatus = true;
        bool bRainStatus = true;
        bool bRainHour = true;

        int _IntCr = 0;
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

        public frmLiveFU()
        {
            InitializeComponent();
        }

        private void frmLiveFU_SizeChanged(object sender, EventArgs e)
        {

            pnlWInd.Height = this.Height / 2 - 20;
            pnlRain.Top = pnlWInd.Top + pnlWInd.Height + 5;
            pnlRain.Height = this.Height / 2;

            refWindLevelLine();

            refWindAxisY();

            refRainLevelLine();

            ref_Wind_pnl();

            ref_Rain_pnl();
        }

        private void ref_Rain_pnl()
        {
            int intRainnteval = Convert.ToInt16((double)(pnlRain.Width - 30) / 6);
            int intRainStart = (pnlRain.Width - intRainnteval * 5) / 2 - 20;

            refRainAxisY();

            refRainLevelLine();

            for (int i = 0; i < clsPublicStatic.intRainNum[intCr] - 1; i++)
            {
                Control ctl = pnlRain.Controls.Find("lbl_Rain_K_" + i, true)[0];
                ctl.Top = pnlRain.Height - 50;
                ctl.Left = i * intRainnteval + intRainStart;

                Control ctl2 = pnlRain.Controls.Find("pnl_Rain_R_" + i, true)[0];
                ctl2.Height = Convert.ToInt16(dbl_R[i] / dblRainYMax * pnlRain.Height * 0.75);
                Panel pnl = (Panel)ctl2;

                refRainRColor(i, pnl);

                pnl.Width = intRainnteval / 5;
                pnl.Top = pnlRain.Height - 50 - pnl.Height; ;
                pnl.Left = ctl.Left + ctl.Width / 2 - pnl.Width / 2;

                ctl = pnlRain.Controls.Find("lbl_Rain_R_" + i, true)[0];
                ctl.Top = pnl.Top - 20;
                ctl.Left = pnl.Left;
                ctl.Text = dbl_R[i].ToString();
                ctl.Width = pnl.Width;
            }

        }

        private void ref_Wind_pnl()
        {
            int intWindInteval = Convert.ToInt16((double)(pnlWInd.Width - 30) / clsPublicStatic.intWindNum[intCr]);
            int intWindStart = (pnlWInd.Width - intWindInteval * (clsPublicStatic.intWindNum[intCr] - 1)) / 2 + 20;

            for (int i = 0; i < clsPublicStatic.intWindNum[intCr] - 1; i++)
            {
                Control ctl = pnlWInd.Controls.Find("pb_wind_" + i, true)[0];
                ctl.Top = pnlWInd.Height - 40;
                ctl.Left = i * intWindInteval + intWindStart + intWindInteval / 2;

                Control ctl2 = pnlWInd.Controls.Find("pnl_V_" + i, true)[0];
                ctl2.Height = Convert.ToInt16(dbl_V[i] / 40 * pnlWInd.Height * 0.75);
                Panel pnl = (Panel)ctl2;
                refWindVColor(i, pnl);
                pnl.Width = intWindInteval * 7 / 10;
                pnl.Top = pnlWInd.Height - 50 - pnl.Height; ;
                pnl.Left = ctl.Left + ctl.Width / 2 - pnl.Width / 2;

                ctl = pnlWInd.Controls.Find("lbl_wind_V_" + i, true)[0];
                Label lbl = (Label)ctl;
                ctl.Top = pnl.Top - 15;
                ctl.Left = pnl.Left;
                ctl.Text = dbl_V[i].ToString();
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Height = 15;
                lbl.Width = pnl.Width;
            }
        }

        private void refWindAxisY()
        {

            Control ctl = pnlWInd.Controls.Find("Wind_Y_1", true)[0];
            int intHeight = Convert.ToInt32(pnlWInd.Height * 0.75);
            ctl.Top = pnlWInd.Height - 50 - intHeight + 1;
            ctl.Height = intHeight;

            ctl = pnlWInd.Controls.Find("Wind_Y_2", true)[0];
            ctl.Top = pnlWInd.Height - 50 - intHeight + 1;
            ctl.Height = intHeight;
            ctl.Left = pnlWInd.Width - 20;

            for (int i = 0; i < 9; i++)
            {
                ctl = pnlWInd.Controls.Find("Wind_Y1_" + i, true)[0];
                ctl.Top = pnlWInd.Height - 50 - intHeight * i / 8;

                Control ctl2 = pnlWInd.Controls.Find("Wind_Y1_Num_" + i, true)[0];
                ctl2.Top = ctl.Top - ctl2.Height / 2;
            }

        }

        private void refWindLevelLine()
        {
            int[] intLevel = new int[6] { 0, 15, 20, 25, 30, 40 };
            for (int i = 0; i < 6; i++)
            {
                Control ctl = pnlWInd.Controls.Find("Wind_Level_" + i, true)[0];
                ctl.Top = pnlWInd.Height - 50 - Convert.ToInt16(Convert.ToDouble(intLevel[i]) / 40 * pnlWInd.Height * 0.75);
                ctl.Width = pnlWInd.Width - 61;
                if (i > 0)
                {
                    ctl.SendToBack();
                }

            }

        }

        private void refRainAxisY()
        {

            Control ctl = pnlRain.Controls.Find("Rain_Y_1", true)[0];
            int intHeight = Convert.ToInt32(pnlRain.Height * 0.75);
            ctl.Top = pnlRain.Height - 50 - intHeight + 1;
            ctl.Height = intHeight;

            ctl = pnlRain.Controls.Find("Rain_Y_2", true)[0];
            ctl.Top = pnlRain.Height - 50 - intHeight + 1;
            ctl.Height = intHeight;
            ctl.Left = pnlRain.Width - 20;

            int intCount = (int)dblRainYMax / (int)dblRainYInterval + 1;

            for (int i = 0; i < 100; i++)
            {
                ctl = pnlRain.Controls.Find("Rain_Y1_" + i, true)[0];
                Control ctl2 = pnlRain.Controls.Find("Rain_Y1_Num_" + i, true)[0];

                if (i < intCount)
                {
                    ctl.Top = pnlRain.Height - 50 - Convert.ToInt16((dblRainYInterval * i) / dblRainYMax * pnlRain.Height * 0.75);
                    ctl.Visible = true;

                    ctl2.Top = ctl.Top - ctl2.Height / 2;
                    ctl2.Visible = true;
                    ctl2.Text = (i * dblRainYInterval).ToString();
                }
                else
                {
                    ctl.Visible = false;
                    ctl2.Visible = false;
                }
            }

        }

        private void refRainLevelLine()
        {
            double[] dblLevel = new double[3] { 0, dblRainAlarm, dblRainYMax };
            for (int i = 0; i < 3; i++)
            {
                Control ctl = pnlRain.Controls.Find("Rain_Level_" + i, true)[0];
                ctl.Top = pnlRain.Height - 50 - Convert.ToInt16(dblLevel[i] / dblRainYMax * pnlRain.Height * 0.75);
                ctl.Width = pnlRain.Width - 60;
                if (i > 0)
                {
                    ctl.SendToBack();
                }
            }
        }

        private void refRainRColor(int i, Panel pnl)
        {
            if (bRainStatus == false)
            {
                pnl.BackColor = Color.Gray;
                return;
            }

            if (dbl_R[i] >= dblRainAlarm)
            {
                pnl.BackColor = Color.Yellow;
            }
            else
            {
                pnl.BackColor = Color.FromArgb(50, 205, 50);
            }
        }

        private void refWindVColor(int i, Panel pnl)
        {
            if (bWindStatus == false)
            {
                pnl.BackColor = Color.Gray;
                return;
            }

            if (dbl_V[i] > 30)
            {
                pnl.BackColor = Color.Red;
            }
            else if (dbl_V[i] > 25)
            {
                pnl.BackColor = Color.Orange;
            }
            else if (dbl_V[i] > 20)
            {
                pnl.BackColor = Color.Yellow;
            }
            else if (dbl_V[i] > 15)
            {
                pnl.BackColor = Color.FromArgb(30, 144, 255);
            }
            else
            {
                pnl.BackColor = Color.FromArgb(50, 205, 50);
            }
        }

        private void frmLiveFU_Load(object sender, EventArgs e)
        {

            initControls_Wind();

            initControls_Rain();

            refWindLevelLine();

            refWindAxisY();

            refRainLevelLine();

            ref_Wind_pnl();

            ref_Rain_pnl();

            timer1.Enabled = true;

        }

        private void closeForm()
        {
            //throw new Exception("The method or operation is not implemented.");
        }

        private void initControls_Rain()
        {
            addRain_axis_Y();

            addRain_Level_Lines();

            //添加横坐标文字
            for (int i = 0; i < clsPublicStatic.intRainNum[intCr] - 1; i++)
            {
                //添加柱状图横坐标轴
                addRainLbl(i);

                //添加柱状图
                addRain_Zhu(i);

                //添加柱状图风速值
                addRain_V(i);

            }
        }

        private void initControls_Wind()
        {
            addWind_Level_Lines();

            addWind_axis_Y();

            //添加横坐标文字
            for (int i = 0; i < clsPublicStatic.intWindNum[intCr] - 1; i++)
            {
                //添加柱状图横坐标轴
                addWindLbl(i);

                //添加柱状图
                addWind_Zhu(i);

                //添加柱状图风速值
                addWind_V(i);

            }

        }

        private void addWind_axis_Y()
        {
            Panel pnl = new Panel();
            pnl.Name = "Wind_Y_1";
            pnl.Width = 1;
            pnl.Left = 40;
            pnl.BackColor = Color.White;
            pnlWInd.Controls.Add(pnl);

            pnl = new Panel();
            pnl.Name = "Wind_Y_2";
            pnl.Width = 1;
            pnl.BackColor = Color.White;
            pnlWInd.Controls.Add(pnl);

            for (int i = 0; i < 9; i++)
            {
                pnl = new Panel();
                pnl.Name = "Wind_Y1_" + i;
                pnl.Width = 5;
                pnl.Height = 2;
                pnl.Left = 35;
                pnl.BackColor = Color.White;
                pnlWInd.Controls.Add(pnl);

                Label lbl = new Label();
                lbl.Name = "Wind_Y1_Num_" + i;
                lbl.Left = 10;
                lbl.Width = 20;
                lbl.Height = 30;
                lbl.ForeColor = Color.White;
                lbl.TextAlign = ContentAlignment.MiddleRight;
                lbl.Text = (i * 5).ToString();
                //lbl.BackColor = Color.Yellow;
                pnlWInd.Controls.Add(lbl);
            }




        }

        private void addWind_Level_Lines()
        {

            for (int i = 0; i < 6; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Name = "Wind_Level_" + i;
                pb.Height = 1;
                pb.Left = 40;
                pb.BackgroundImage = Image.FromFile("Wind_Level_" + i + ".png");
                pb.BackgroundImageLayout = ImageLayout.Tile;
                pnlWInd.Controls.Add(pb);
            }


        }

        private void addRain_axis_Y()
        {
            Panel pnl = new Panel();
            pnl.Name = "Rain_Y_1";
            pnl.Width = 1;
            pnl.Left = 40;
            pnl.BackColor = Color.White;
            pnlRain.Controls.Add(pnl);

            pnl = new Panel();
            pnl.Name = "Rain_Y_2";
            pnl.Width = 1;
            pnl.BackColor = Color.White;
            pnlRain.Controls.Add(pnl);

            addRainY_kedu();

        }

        private void addRainY_kedu()
        {
            //int intCount = (int)dblRainYMax / (int)dblRainYInterval + 1;

            int intCount = 100;

            Panel pnl;

            for (int i = 0; i < intCount; i++)
            {
                pnl = new Panel();
                pnl.Name = "Rain_Y1_" + i;
                pnl.Width = 5;
                pnl.Height = 2;
                pnl.Left = 35;
                pnl.BackColor = Color.White;
                pnl.Visible = false;
                pnlRain.Controls.Add(pnl);

                Label lbl = new Label();
                lbl.Name = "Rain_Y1_Num_" + i;
                lbl.Left = 5;
                lbl.Width = 25;
                lbl.Height = 30;
                lbl.ForeColor = Color.White;
                lbl.TextAlign = ContentAlignment.MiddleRight;
                lbl.Text = (i * dblRainYInterval).ToString();
                lbl.Visible = false;
                pnlRain.Controls.Add(lbl);
            }

        }

        private void addRain_Level_Lines()
        {

            for (int i = 0; i < 3; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Name = "Rain_Level_" + i;
                pb.Height = 1;
                pb.Left = 40;
                if (i == 1)
                {
                    pb.BackgroundImage = Image.FromFile("Rain_Level_" + i + ".png");
                }
                else
                {
                    pb.BackgroundImage = Image.FromFile("Rain_Level_0.png");
                }

                pb.BackgroundImageLayout = ImageLayout.Tile;
                pnlRain.Controls.Add(pb);
            }


        }

        private void addRain_V(int i)
        {
            Label lbl = new Label();
            lbl.Name = "lbl_Rain_R_" + i;
            lbl.ForeColor = Color.White;
            //lbl.AutoSize = true;
            lbl.Font = font_Label;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            pnlRain.Controls.Add(lbl);
        }

        private void addRain_Zhu(int i)
        {
            int intRainInteval = Convert.ToInt16((double)pnlRain.Width / 6);
            Panel pnl = new Panel();
            pnl.Name = "pnl_Rain_R_" + i;
            pnl.Width = intRainInteval / 1 * 5;
            pnl.Top = pnlWInd.Height - 60 - pnl.Height;
            pnl.BackColor = Color.Green;
            pnlRain.Controls.Add(pnl);
        }

        private void addRainLbl(int i)
        {
            string strPK = clsPublicStatic.rainPositionK[intCr, i + 1];

            Label lbl = new Label();
            lbl.Name = "lbl_Rain_K_" + i;
            lbl.Font = font_Label;
            lbl.Text = strPK;
            lbl.ForeColor = Color.White;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            pnlRain.Controls.Add(lbl);

        }

        private void addWind_V(int i)
        {
            Label lbl = new Label();
            lbl.Name = "lbl_wind_V_" + i;
            //lbl.AutoSize = true;
            lbl.ForeColor = Color.White;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            pnlWInd.Controls.Add(lbl);
        }

        private void addWind_Zhu(int i)
        {
            int intWindInteval = Convert.ToInt16((double)pnlWInd.Width / 32);
            Panel pnl = new Panel();
            pnl.Name = "pnl_V_" + i;
            pnl.Width = intWindInteval / 3 * 5;
            pnl.Top = pnlWInd.Height - 60 - pnl.Height;
            pnl.BackColor = Color.Green;
            pnlWInd.Controls.Add(pnl);
        }

        private void addWindLbl(int i)
        {
            string strPK = clsPublicStatic.windPositionK[intCr, i + 1];

            //addPbs(i, strPK);

            Label lbl = new Label();
            lbl.Name = "pb_wind_" + i;
            lbl.AutoSize = true;
            lbl.ForeColor = Color.White;
            lbl.Text = strPK.Substring(0, strPK.IndexOf("+")) + "\r\n+" + strPK.Substring(strPK.IndexOf("+") + 1);
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            pnlWInd.Controls.Add(lbl);
        }

        private void addPbs(int i, string strPK)
        {
            PictureBox pb = new PictureBox();
            pb.Name = "pb_wind_" + i;
            pb.Height = 50;
            pb.Width = 50;

            Font enFont = new Font("Times New Roman", 5);
            Image img = Image.FromFile("1.png");
            Graphics graphic = Graphics.FromImage(img);

            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            graphic.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            System.Drawing.Drawing2D.Matrix transform;

            SizeF size = graphic.MeasureString(strPK, enFont);
            Single posX = 0;
            Single posY = (pb.Height - Convert.ToInt16(size.Height)) / 2;
            graphic.TranslateTransform(posX, posY);
            transform = graphic.Transform;
            float shearX = 0.50F; //左倾斜文字
            float shearY = -0.40F;
            transform.Shear(shearX, shearY);
            graphic.Transform = transform;
            graphic.DrawString(strPK, enFont, new SolidBrush(Color.Black), 0, 0);
            //pictureBox1.Image = img;                
            pb.Image = img;
            pnlWInd.Controls.Add(pb);
        }

        //定时器，1s刷新一次
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy == false)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        //后台进程，获取数据
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            refreshWindData();

            refreshRainData();

            refRainYMax();
        }

        private void refreshRainData()
        {
            for (int i = 0; i < clsPublicStatic.intRainNum[intCr] - 1; i++)
            {
                if (bRainHour)
                {
                    dbl_R[i] = clsPublicStatic.rainPositionHour[intCr, i + 1];
                }
                else
                {
                    dbl_R[i] = clsPublicStatic.rainPositionContinuours[intCr, i + 1];
                }
            }

        }

        private void refreshWindData()
        {
            for (int i = 0; i < clsPublicStatic.intWindNum[intCr] - 1; i++)
            {
                dbl_V[i] = clsPublicStatic.windPositionV[intCr, i + 1];
            }
        }

        //后台进程执行完成后，刷新界面
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (this.WindowState == FormWindowState.Minimized)
            {
                return;
            }

            //if (bWindStatus)
            //{
            ref_Wind_pnl();
            //}
            //else
            //{
            //    //柱状图变灰
            //}

            //if (bRainStatus)
            //{
            ref_Rain_pnl();
            //}
            //else
            //{
            //    //柱状图变灰
            //}

            if (DateTime.Now.Second == 0)
            {
                GC.Collect();
            }

        }

        //随机生成数据
        private void getRainData_Rnd()
        {
            Random rnd = new Random();
            for (int i = 0; i < clsPublicStatic.intWindNum[intCr] - 1; i++)
            {
                dbl_V[i] = (double)rnd.Next(30, 240) / 10;
            }

            for (int i = 0; i < clsPublicStatic.intRainNum[intCr] - 1; i++)
            {
                dbl_R[i] = rnd.Next(0, 80);
            }
        }

        //计算雨量图Y轴最大坐标值
        private void refRainYMax()
        {
            double dblMax = getDblMax(dbl_R);

            if (dblMax < 60)
            {
                dblRainYMax = 60;
                dblRainYInterval = 10;
            }
            else
            {
                dblRainYMax = (((int)Math.Ceiling(dblMax)) / 10 + 3) * 10;
                dblRainYInterval = 20;
            }

        }

        private double getDblMax(double[] dbl_R)
        {
            double dbl = 0;

            for (int i = 0; i < dbl_R.Length; i++)
            {
                if (dbl_R[i] > dbl)
                {
                    dbl = dbl_R[i];
                }
            }

            return dbl;

        }

        //切换显示小时雨量或连续雨量
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.dblRainAlarm = 12;
                bRainHour = true;
            }
            else
            {
                this.dblRainAlarm = 40;
                bRainHour = false;
            }

            refreshRainData();

            refRainLevelLine();

        }

        private void frmLiveFU_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

    }
}