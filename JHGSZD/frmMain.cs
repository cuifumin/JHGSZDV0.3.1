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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private static int intCr = 0;
        Panel pnlMainMiddle = null;

        private void frmMain_Load(object sender, EventArgs e)
        {

            setPath();

            refreshSysTime();

            initPnls();

            formatDataGridView();

            clsPublicStatic.init();

            Draw();

            showOnMonitor(1);

            intCr = 0;
            btnTJ.Enabled = false;

            timer1.Enabled = true;
        }

        private void setPath()
        {
            if (System.Environment.GetEnvironmentVariable("Path").IndexOf(Application.StartupPath) < 0)
            {
                //System.Environment.SetEnvironmentVariable("Path", Application.StartupPath + "\\instantclient10;");
                System.Environment.SetEnvironmentVariable("Path", "D:\\instantclient10;");
            }
        }

        private void formatDataGridView()
        {
            formatDataGridView(dataGridView2);
            formatDataGridView(dataGridView1);
            formatDataGridView(dataGridView3);
            formatDataGridView(dataGridView4);
        }

        private void formatDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.Location = new Point(5, 155);
            dgv.Width = 758;
            dgv.Height = 282;
        }

        private void showOnMonitor(int showOnMonitor)
        {
            Screen[] sc;
            sc = Screen.AllScreens;
            if (showOnMonitor >= sc.Length)
            {
                showOnMonitor = 0;
            }

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(sc[showOnMonitor].Bounds.Left, sc[showOnMonitor].Bounds.Top);
            // If you intend the form to be maximized, change it to normal then maximized.  
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Draw()
        {
            for (int i = 0; i < 4; i++)
            {
                intCr = i;

                if (i == 0)
                {
                    pnlMainMiddle = pnl_TJ;
                }
                else if (i == 1)
                {
                    pnlMainMiddle = pnl_JN;
                }
                else if (i == 2)
                {
                    pnlMainMiddle = pnl_BB;
                }
                else if (i == 3)
                {
                    pnlMainMiddle = pnl_NJ;
                }

                drawLine();

                drawWind();

                drawYW();

                drawDz();

                drawRain();

                drawTrainStation();

            }

        }

        private void drawRain()
        {
            for (int i = 0; i < clsPublicStatic.intRailNumber; i++)
            {
                if (clsPublicStatic.lstRainPostionK[intCr, i] == null)
                {
                    continue;
                }

                for (int index = 0; index < clsPublicStatic.lstRainPostionK[intCr, i].Count; index++)
                {
                    addRainPt(i, index);
                }
            }
        }

        private void addRainPt(int intRi, int intCi)
        {
            Point pt = getRainStartPt(intRi, intCi);

            PictureBox pb = new PictureBox();
            pb.Name = "pbRainPt_" + intRi + "_" + intCi + "_" + intCr;
            pb.Location = pt;
            pb.Size = new Size(22, 22);
            pb.Image = global::JHGSZD.Properties.Resources.绿点;
            pb.Click += pbRainPt_Click;
            pnlMainMiddle.Controls.Add(pb);

            Label lblRainK = new Label();
            lblRainK.AutoSize = true;
            lblRainK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRainK.Location = new System.Drawing.Point(pt.X - 25, pt.Y - 43);
            lblRainK.Name = "lblRain_" + intRi + "_" + intCi + "_" + intCr;
            lblRainK.Size = new System.Drawing.Size(73, 19);
            lblRainK.Text = clsPublicStatic.lstRainPostionK[intCr, intRi].ToArray()[intCi];
            pnlMainMiddle.Controls.Add(lblRainK);

            PictureBox pb2 = new PictureBox();
            pb2.Name = "RainPtAlarm_" + intRi + "_" + intCi + "_" + intCr;
            pb2.Location = new Point(pt.X - 28 + 11, pt.Y + 50);
            pb2.Size = new Size(55, 26);
            pb2.Image = global::JHGSZD.Properties.Resources.雨正常;
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.Click += pbRainPtAlarm_Click;
            pb2.Visible = true;
            pnlMainMiddle.Controls.Add(pb2);

        }

        //private void pbRain_Click(object sender, EventArgs e)
        //{
        //    //PictureBox pb = (PictureBox)sender;

        //    //if (intRainCount < 3)
        //    //{
        //    //    if (intRainCount == 0)
        //    //    {
        //    //        pb.Image = global::JHGSZD.Properties.Resources.雨正常;
        //    //    }
        //    //    else if (intRainCount == 1)
        //    //    {
        //    //        pb.Image = global::JHGSZD.Properties.Resources.雨1级报警;
        //    //    }
        //    //    else if (intRainCount == 2)
        //    //    {
        //    //        pb.Image = global::JHGSZD.Properties.Resources.雨2级报警;
        //    //    }
        //    //    intRainCount++;
        //    //}
        //    //else
        //    //{
        //    //    intRainCount = 0;
        //    //}
        //}

        private Point getRainStartPt(int intRi, int intCi)
        {
            int intX = 0 + clsPublicStatic.lstRainPtX[intCr, intRi].ToArray()[intCi] + 39;
            int intY = 94 + clsPublicStatic.intLine2 * intRi + 8;

            return new Point(intX, intY);
        }

        private void drawDz()
        {
            for (int i = 0; i < clsPublicStatic.intRailNumber; i++)
            {
                if (clsPublicStatic.lstDZPostionK[intCr, i] == null)
                {
                    continue;
                }

                for (int index = 0; index < clsPublicStatic.lstDZPostionK[intCr, i].Count; index++)
                {
                    addDzPt(i, index);
                }
            }
        }

        private void addDzPt(int intRi, int intCi)
        {
            Point pt = getDzStartPt(intRi, intCi);

            PictureBox pb = new PictureBox();
            pb.Name = "pbDzPt_" + intRi + "_" + intCi + "_" + intCr;
            pb.Location = pt;
            pb.Size = new Size(22, 22);
            pb.Image = global::JHGSZD.Properties.Resources.绿点;
            pb.Click += pbDz_Click;
            pnlMainMiddle.Controls.Add(pb);

            Label lblWindK = new Label();
            lblWindK.AutoSize = true;
            //lblWindK.Width = 70;
            //lblWindK.he
            lblWindK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblWindK.Name = "lblDz_" + intRi + "_" + intCi + "_" + intCr;
            lblWindK.Size = new System.Drawing.Size(73, 19);
            lblWindK.Text = clsPublicStatic.lstDZPostionName[intCr, intRi].ToArray()[intCi];
            lblWindK.Location = new System.Drawing.Point(pt.X - 35, pt.Y - 43);
            pnlMainMiddle.Controls.Add(lblWindK);

            PictureBox pb2 = new PictureBox();
            pb2.Name = "PbDzPtAlarm_" + intRi + "_" + intCi + "_" + intCr;
            pb2.Location = new Point(pt.X - 28 + 11, pt.Y + 50);
            pb2.Size = new Size(55, 26);
            pb2.Image = global::JHGSZD.Properties.Resources.地震正常;
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.Click += pbDz_Click;
            pb2.Visible = true;
            pnlMainMiddle.Controls.Add(pb2);

            //PictureBox pbKuang = new PictureBox();
            //pbKuang.Name = "windPtAlarmKuang_" + intRowIndex + "_" + intColumnIndex;
            //pbKuang.Location = new Point(ptWindCenter.X - 32 + 11, ptWindCenter.Y + 45);
            //pbKuang.Size = new Size(64, 36);
            //pb.Visible = true;
            //pnlMainMiddle.Controls.Add(pbKuang);

        }

        private void pbDz_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string strPbName = ((PictureBox)sender).Name;
            string[] str = strPbName.Split('_');
            int intRi = int.Parse(str[1]);
            int intCi = int.Parse(str[2]);
            int intCr = int.Parse(str[3]);

            int intZi = clsPublicStatic.getIndexByRiCI(intCr, intRi, intCi, clsPublicStatic.lstDZPostionPtX);

            frmQueryEquip form = new frmQueryEquip();
            form.intIndex = intZi;
            form.intType = 3;
            form.intCr = intCr;
            form.Show();

            this.Cursor = Cursors.Arrow;

        }

        private Point getDzStartPt(int intRi, int intCi)
        {
            int intX = 0 + clsPublicStatic.lstDZPostionPtX[intCr, intRi].ToArray()[intCi] + 50;
            int intY = 94 + clsPublicStatic.intLine2 * intRi + 8;

            return new Point(intX, intY);
        }

        private void drawYW()
        {
            for (int i = 0; i < clsPublicStatic.intRailNumber; i++)
            {
                if (clsPublicStatic.lstYwPostionK[intCr, i] == null)
                {
                    continue;
                }

                for (int index = 0; index < clsPublicStatic.lstYwPostionK[intCr, i].Count; index++)
                {
                    addYwPt(i, index);
                }
            }
        }

        private void addYwPt(int intRi, int intCi)
        {
            Point pt = getYwStartPt(intRi, intCi);

            PictureBox pb = new PictureBox();
            pb.Size = new Size(60, 100);
            pb.Location = pt;
            pb.Name = "pbYw_" + intRi + "_" + intCi + "_" + intCr;
            pb.Image = global::JHGSZD.Properties.Resources.电网正常;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Visible = true;
            pb.Click += pbYw_Click;
            pnlMainMiddle.Controls.Add(pb);

            Label lblWindK = new Label();
            lblWindK.AutoSize = false;
            lblWindK.Height = 100;
            lblWindK.Width = 70;
            lblWindK.TextAlign = ContentAlignment.MiddleCenter;
            lblWindK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblWindK.Location = new System.Drawing.Point(pt.X - 5, pt.Y - 25);
            lblWindK.Name = "lblYW_" + intRi + "_" + intCi + "_" + intCr;
            lblWindK.Size = new System.Drawing.Size(73, 19);
            lblWindK.Text = clsPublicStatic.lstYwPostionName[intCr, intRi].ToArray()[intCi];
            lblWindK.Visible = true;

            pnlMainMiddle.Controls.Add(lblWindK);

        }

        private Point getYwStartPt(int intRi, int index)
        {
            int intX = 0 + clsPublicStatic.lstYwPostionPtX[intCr, intRi].ToArray()[index];
            int intY = 94 + clsPublicStatic.intLine2 * intRi - 31;

            return new Point(intX, intY);
        }

        private void SetPerPixelBitmapFilename()
        {

            //pictureBox16.Hide();
            //pictureBox16.DrawToBitmap((Bitmap)pictureBox16.Image, pictureBox16.Bounds);
        }

        private void drawTrainStation()
        {
            for (int i = 0; i < clsPublicStatic.intRailNumber; i++)
            {
                if (clsPublicStatic.lstTrainStationK[intCr, i] == null)
                {
                    continue;
                }

                string[] lst = clsPublicStatic.lstTrainStationK[intCr, i].ToArray();
                for (int j = 0; j < lst.Length; j++)
                {
                    addTrainStation(i, j, lst[j], clsPublicStatic.lstTrainStationName[intCr, i].ToArray()[j]);
                }

            }

        }

        private void drawWind()
        {
            for (int i = 0; i < clsPublicStatic.intRailNumber; i++)
            {
                if (clsPublicStatic.lstWindPtK[intCr, i] == null)
                {
                    return;
                }

                for (int j = 0; j < clsPublicStatic.lstWindPtK[intCr, i].Count; j++)
                {
                    addWindPoint(i, j);
                }
            }
        }

        private void drawLine()
        {
            for (int intRi = 0; intRi < clsPublicStatic.intRailNumber; intRi++)
            {
                if (clsPublicStatic.lstLineLength[intCr, intRi] != null)
                {
                    int[] intLens = clsPublicStatic.lstLineLength[intCr, intRi].ToArray();
                    for (int intCi = 0; intCi < intLens.Length; intCi++)
                    {
                        Point pt = getStartPx(intRi, intCi);

                        for (int i = 0; i < 6; i++)
                        {
                            drawLines(intLens[intCi], intRi, intCi, pt, i);
                        }

                    }
                }
            }
        }

        private void addWindPoint(int intRowIndex, int intColumnIndex)
        {
            Point ptWindCenter = getWindPtX(intRowIndex, intColumnIndex);

            addWindLabelPosition(ptWindCenter, intRowIndex, intColumnIndex);
            addWindPbPosition(ptWindCenter, intRowIndex, intColumnIndex);
            addWindAlarm(ptWindCenter, intRowIndex, intColumnIndex);
        }

        private Point getWindPtX(int intRi, int intCi)
        {
            int intX = 0 + clsPublicStatic.lstWindPtX[intCr, intRi].ToArray()[intCi] - 11;
            int intY = 94 + clsPublicStatic.intLine2 * intRi + 8;

            return new Point(intX, intY);
        }

        private void addWindAlarm(Point ptWindCenter, int intRi, int intCi)
        {
            PictureBox pb = new PictureBox();
            pb.Name = "windPtAlarm_" + intRi + "_" + intCi + "_" + intCr;
            //Console.WriteLine("windPtAlarm_" + intRi + "_" + intCi + "_" + intCr);
            pb.Location = new Point(ptWindCenter.X - 28 + 11, ptWindCenter.Y + 50);
            pb.Size = new Size(55, 26);
            //pb.Image = global::JHGSZD.Properties.Resources.正常状态;
            pb.BackgroundImage = global::JHGSZD.Properties.Resources.正常状态;
            pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pb.Visible = true;
            pb.Click += pbWindPtAlarm_Click;
            pnlMainMiddle.Controls.Add(pb);

            PictureBox pbKuang = new PictureBox();
            pbKuang.Name = "windPtAlarmKuang_" + intRi + "_" + intCi + "_" + intCr;
            pbKuang.Location = new Point(ptWindCenter.X - 32 + 11, ptWindCenter.Y + 45);
            pbKuang.Size = new Size(64, 36);
            pb.Visible = true;
            pnlMainMiddle.Controls.Add(pbKuang);
        }

        private void addWindPbPosition(Point ptWindCenter, int intRi, int intCi)
        {
            PictureBox pb = new PictureBox();
            pb.Name = "windPt_" + intRi + "_" + intCi + "_" + intCr;
            pb.Location = ptWindCenter;
            pb.Size = new Size(22, 22);
            pb.Image = global::JHGSZD.Properties.Resources.绿点;
            pb.Click += pbWindPt_Click;
            pnlMainMiddle.Controls.Add(pb);
        }

        private void pbWindPtAlarm_Click(object sender, EventArgs e)
        {
            string strPbName = ((PictureBox)sender).Name;
            string[] str = strPbName.Split('_');

            int intRi = int.Parse(str[1]);
            int intCi = int.Parse(str[2]);
            int intCr = int.Parse(str[3]);

            int intWindIndex = clsPublicStatic.getWindIndex(intCr, intRi, intCi);

            frmWindAlm form = new frmWindAlm();
            form.intWi = intWindIndex + 1;
            form.intCr = intCr;
            form.TopMost = true;
            form.Show();
        }

        private void pbRainPtAlarm_Click(object sender, EventArgs e)
        {
            string strPbName = ((PictureBox)sender).Name;
            string[] str = strPbName.Split('_');

            int intRi = int.Parse(str[1]);
            int intCi = int.Parse(str[2]);
            int intCr = int.Parse(str[3]);

            int intRainIndex = clsPublicStatic.getRainIndex(intCr, intRi, intCi);

            frmRainAlm form = new frmRainAlm();
            form.intRi = intRainIndex + 1;
            form.intCr = intCr;
            form.TopMost = true;
            form.Show();
        }

        private void pbWindPt_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string strPbName = ((PictureBox)sender).Name;
            string[] str = strPbName.Split('_');

            int intRi = int.Parse(str[1]);
            int intCi = int.Parse(str[2]);
            int intCr = int.Parse(str[3]);

            int intWindIndex = clsPublicStatic.getWindIndex(intCr, intRi, intCi);

            frmQueryFU form = new frmQueryFU();
            form.intIndex = intWindIndex;
            form.intType = 0;
            form.intCr = intCr;
            form.Show();

            this.Cursor = Cursors.Arrow;
        }

        private void pbRainPt_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string strPbName = ((PictureBox)sender).Name;
            string[] str = strPbName.Split('_');
            int intRi = int.Parse(str[1]);
            int intCi = int.Parse(str[2]);

            int intCr = int.Parse(str[3]);

            int intRainIndex = clsPublicStatic.getRainIndex(intCr, intRi, intCi);

            frmQueryFU form = new frmQueryFU();
            form.intIndex = intRainIndex;
            form.intType = 1;
            form.intCr = intCr;
            form.Show();

            this.Cursor = Cursors.Arrow;


        }

        List<int> lstWindAlarmChanged = new List<int>();
        List<int> lstRainAlarmChanged = new List<int>();

        private void addWindLabelPosition(Point ptWindCenter, int intRi, int intCi)
        {
            Label lblWindK = new Label();
            lblWindK.AutoSize = true;
            lblWindK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblWindK.Location = new System.Drawing.Point(ptWindCenter.X - 25, ptWindCenter.Y - 43);
            lblWindK.Name = "lblWind_" + intRi + "_" + intCi + "_" + intCr;
            lblWindK.Size = new System.Drawing.Size(73, 19);
            lblWindK.Text = clsPublicStatic.lstWindPtK[intCr, intRi].ToArray()[intCi];
            lblWindK.ForeColor = Color.White;
            pnlMainMiddle.Controls.Add(lblWindK);
        }

        Dictionary<string, int> dic = new Dictionary<string, int>();
        List<int> lst = new List<int>();

        private void drawLine(int intLineLength, int intRowIndex, int intColumnIndex)
        {
            lst.Add(intLineLength);

            //dic.Add(intRowIndex + "_" + intColumnIndex, intLineLength);

            Point ptLineStartPx = getStartPx(intRowIndex, intColumnIndex);

            drawLines(intLineLength, intRowIndex, intColumnIndex, ptLineStartPx, 0);
            drawLines(intLineLength, intRowIndex, intColumnIndex, ptLineStartPx, 1);
            drawLines(intLineLength, intRowIndex, intColumnIndex, ptLineStartPx, 2);

            drawLines(intLineLength, intRowIndex, intColumnIndex, ptLineStartPx, 3);
            drawLines(intLineLength, intRowIndex, intColumnIndex, ptLineStartPx, 4);
            drawLines(intLineLength, intRowIndex, intColumnIndex, ptLineStartPx, 5);
        }

        private void drawLines(int intLineLength, int intRowIndex, int intColumnIndex, Point ptLineStartPx, int index)
        {
            PictureBox pb = new PictureBox();
            pb.Name = "pb_line_" + intRowIndex + "_" + intColumnIndex + "_" + index;

            if (index == 0)
            {
                pb.Location = new Point(ptLineStartPx.X, ptLineStartPx.Y - clsPublicStatic.intLineHeight);
                pb.Visible = false;
            }
            else if (index == 1)
            {
                pb.Location = ptLineStartPx;
            }
            else if (index == 2)
            {
                pb.Location = new Point(ptLineStartPx.X, ptLineStartPx.Y + clsPublicStatic.intLineHeight);
                pb.Visible = false;
            }
            else if (index == 3)
            {
                pb.Location = new Point(ptLineStartPx.X, ptLineStartPx.Y + clsPublicStatic.intLineDistance - clsPublicStatic.intLineHeight);
                pb.Visible = false;
            }
            else if (index == 4)
            {
                pb.Location = new Point(ptLineStartPx.X, ptLineStartPx.Y + clsPublicStatic.intLineDistance);
            }
            else if (index == 5)
            {
                pb.Location = new Point(ptLineStartPx.X, ptLineStartPx.Y + clsPublicStatic.intLineDistance + clsPublicStatic.intLineHeight);
                pb.Visible = false;
            }

            pb.Width = intLineLength;
            pb.Height = clsPublicStatic.intLineHeight;
            //int intAlarmLevel=clsPublicStatic.lstIntWindAlarmLevel[intRowIndex].ToArray()[intColumnIndex];
            if (index == 4 || index == 1)
            {
                pb.BackgroundImage = global::JHGSZD.Properties.Resources.单绿线_短1;
            }
            else
            {
                pb.BackgroundImage = global::JHGSZD.Properties.Resources.单黄线1;
            }

            pnlMainMiddle.Controls.Add(pb);

        }

        private Point getStartPx(int intRowIndex, int intColumnIndex)
        {
            int intX = clsPublicStatic.intStartX;
            int intY = clsPublicStatic.intStartY;

            int intTemp = 0;

            int[] intLens = clsPublicStatic.lstLineLength[intCr, intRowIndex].ToArray();
            for (int i = 0; i < intColumnIndex; i++)
            {
                intTemp += intLens[i];
            }

            return new Point(intX + intTemp, intY + intRowIndex * clsPublicStatic.intLine2);
        }

        private void initPnls()
        {
            initPnl(pnl_TJ, "TJ");
            initPnl(pnl_JN, "JN");
            initPnl(pnl_BB, "BB");
            initPnl(pnl_NJ, "NJ");
        }

        private void initPnl(Panel pnl, string strCenter)
        {
            pnl.Left = 1;
            pnl.Top = 98;

            pnl.Width = 1900;
            pnl.Height = 980;
        }

        private void btnTJ_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string str = btn.Name.Substring(3);

            btnTJ.Enabled = true;
            btnJN.Enabled = true;
            btnBB.Enabled = true;
            btnNJ.Enabled = true;

            if (str == "TJ")
            {
                btnTJ.Enabled = false;

                intCr = 0;
                pnl_TJ.Visible = true;
                pnl_JN.Visible = false;
                pnl_BB.Visible = false;
                pnl_NJ.Visible = false;
            }
            else if (str == "JN")
            {
                btnJN.Enabled = false;

                intCr = 1;
                pnl_TJ.Visible = false;
                pnl_JN.Visible = true;
                pnl_BB.Visible = false;
                pnl_NJ.Visible = false;
            }
            else if (str == "BB")
            {
                btnBB.Enabled = false;

                intCr = 2;
                pnl_TJ.Visible = false;
                pnl_JN.Visible = false;
                pnl_BB.Visible = true;
                pnl_NJ.Visible = false;
            }
            else if (str == "NJ")
            {
                btnNJ.Enabled = false;

                intCr = 3;
                pnl_TJ.Visible = false;
                pnl_JN.Visible = false;
                pnl_BB.Visible = false;
                pnl_NJ.Visible = true;
            }
        }

        private void addTrainStation(int intRi, int j, string strTrainStationK, string strTrainStationName)
        {

            Point pt = getTrainStationCenter(intRi, j);

            Label lblStationK = new Label();
            lblStationK.AutoSize = false;
            lblStationK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblStationK.Location = new System.Drawing.Point(pt.X - 65, pt.Y - 68);
            lblStationK.Name = "lblStationK_" + intRi + "_" + strTrainStationK;
            lblStationK.Size = new System.Drawing.Size(130, 19);
            lblStationK.Text = strTrainStationK;
            lblStationK.TextAlign = ContentAlignment.MiddleCenter;
            lblStationK.Visible = true;
            pnlMainMiddle.Controls.Add(lblStationK);

            Label lblTSNAME = new Label();
            lblTSNAME.AutoSize = false;
            lblTSNAME.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTSNAME.Location = new System.Drawing.Point(pt.X - 65, pt.Y - 90);
            lblTSNAME.Name = "lblStationName_" + intRi + "_" + strTrainStationName;
            lblTSNAME.Size = new System.Drawing.Size(130, 19);
            lblTSNAME.Text = strTrainStationName;
            lblTSNAME.TextAlign = ContentAlignment.MiddleCenter;
            lblTSNAME.Visible = true;
            pnlMainMiddle.Controls.Add(lblTSNAME);

            Label lblTsLimit = new Label();
            lblTsLimit.AutoSize = false;
            lblTsLimit.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTsLimit.ForeColor = Color.Blue;
            lblTsLimit.Location = new System.Drawing.Point(pt.X - 48, pt.Y + 50);
            lblTsLimit.Name = "lblStationLimit_" + intRi + "_" + strTrainStationName;
            lblTsLimit.Size = new System.Drawing.Size(100, 19);
            lblTsLimit.Text = "站台限速";
            lblTsLimit.TextAlign = ContentAlignment.MiddleCenter;
            lblTsLimit.Visible = false;
            pnlMainMiddle.Controls.Add(lblTsLimit);

            PictureBox pb = new PictureBox();

            pb.Size = new Size(130, 85);
            pb.Name = "pb_" + intRi + "_" + strTrainStationName;
            pb.Image = global::JHGSZD.Properties.Resources.图片6;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Location = new Point(pt.X - 70, pt.Y - 43);
            pb.Visible = true;
            pb.BackColor = Color.Transparent;
            pnlMainMiddle.Controls.Add(pb);

        }

        private Point getTrainStationCenter(int intRi, int j)
        {
            int intX = 25 + clsPublicStatic.lstTrainStationPtX[intCr, intRi].ToArray()[j];
            int intY = 94 + 20 + clsPublicStatic.intLine2 * intRi;

            return new Point(intX, intY);
        }

        private void pbYw_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string strPbName = ((PictureBox)sender).Name;
            string[] str = strPbName.Split('_');
            int intRi = int.Parse(str[1]);
            int intCi = int.Parse(str[2]);
            int intCr = int.Parse(str[3]);

            int intYi = clsPublicStatic.getIndexByRiCI(intCr, intRi, intCi, clsPublicStatic.lstYwPostionPtX);

            frmQueryEquip form = new frmQueryEquip();
            form.intIndex = intYi;
            form.intType = 1;
            form.intCr = intCr;
            form.Show();

            this.Cursor = Cursors.Arrow;

        }

        private void setYwLine(int intRi, int intCi, int index, int intValue)
        {
            PictureBox pbLine = (PictureBox)pnlMainMiddle.Controls.Find("pb_line_" + intRi + "_" + intCi + "_" + index, true)[0];

            if (intValue == -1)//server不通
            {
                pbLine.BackgroundImage = global::JHGSZD.Properties.Resources.单白线1;
            }
            else if (intValue == 0)//正常行车
            {
                pbLine.BackgroundImage = global::JHGSZD.Properties.Resources.单绿线_短1;
            }
            else if (intValue == 1)//临时通车
            {
                pbLine.BackgroundImage = global::JHGSZD.Properties.Resources.单黄线1;
            }
            else//停车
            {
                pbLine.BackgroundImage = global::JHGSZD.Properties.Resources.单红线1;
            }
        }

        private static int getYwIndex(PictureBox pb)
        {
            string[] strs = pb.Name.Split('_');
            int intRi = int.Parse(strs[1]);
            int intCi = int.Parse(strs[2]);

            int intYwIndex = 0;
            for (int i = 0; i <= intRi; i++)
            {
                if (i == intRi)
                {
                    intYwIndex += intCi;
                    break;
                }
                else
                {
                    intYwIndex += clsPublicStatic.lstYwPostionK[intCr, i].Count;
                }
            }
            return intYwIndex;
        }

        DataSet dsAlarmData = new DataSet();
        DataSet[] dsPositionData = new DataSet[4];

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //读取报警列表
            for (int i = 0; i < 4; i++)
            {
                refreshAlarmData(i);
                //读取监测点状态
                refreshPositionStatus(i);
            }
        }

        private void refreshPositionStatus(int intCr)
        {
            //读取风速值
            refreshWindValue(intCr);
            //读取风报警
            refreshWindAlarm(intCr);
            //读取雨数值
            refreshRainValue(intCr);
            //读取雨报警
            refreshRainAlarm(intCr);
        }

        private void refreshRainAlarm(int intCr)
        {
            string strSQL = "select * from CURRENT_RAIN_ALARM";
            string strTableName = "CURRENT_RAIN_ALARM";
            DataSet ds = new DataSet();
            int intInfo = oracleDAO.getDataSet(strSQL, strTableName, ds, intCr);

            if (intInfo == 0)//查询失败
            {
                return;
            }

            for (int i = 0; i < clsPublicStatic.intRainNum[intCr] - 1; i++)
            {
                clsPublicStatic.RainPositionAlarm[intCr, i + 1] = int.Parse(ds.Tables[0].Rows[i]["ALARMLEVEL"].ToString());
                clsPublicStatic.rainPositionAlarmTime[intCr, i + 1] = DateTime.Parse(ds.Tables[0].Rows[i]["DATETIME"].ToString());
            }
        }

        private void refreshWindAlarm(int intCr)
        {
            string strSQL = "select * from CURRENT_WIND_ALARM";
            string strTableName = "CURRENT_WIND_ALARM";
            DataSet ds = new DataSet();
            int intInfo = oracleDAO.getDataSet(strSQL, strTableName, ds, intCr);

            if (intInfo == 0)//查询失败
            {
                return;
            }

            for (int i = 0; i < clsPublicStatic.intWindNum[intCr] - 1; i++)
            {
                clsPublicStatic.windPositionAlarm[intCr, i + 1] = int.Parse(ds.Tables[0].Rows[i]["ALARMLEVEL"].ToString());
                clsPublicStatic.windPositionAlarmTime[intCr, i + 1] = DateTime.Parse(ds.Tables[0].Rows[i]["DATETIME"].ToString());
            }
        }

        private void refreshRainValue(int intCr)
        {
            string strSQL = "select * from CURRENT_RAIN_RECORD";
            string strTableName = "CURRENT_RAIN_RECORD";
            DataSet ds = new DataSet();
            int intInfo = oracleDAO.getDataSet(strSQL, strTableName, ds, intCr);

            if (intInfo == 0)//查询失败
            {
                return;
            }

            for (int i = 0; i < clsPublicStatic.intRainNum[intCr] - 1; i++)
            {
                clsPublicStatic.rainPositionHour[intCr, i + 1] = double.Parse(ds.Tables[0].Rows[i]["HYULIANG"].ToString());
                clsPublicStatic.rainPositionDay[intCr, i + 1] = double.Parse(ds.Tables[0].Rows[i]["DYULIANG"].ToString());
                clsPublicStatic.rainPositionContinuours[intCr, i + 1] = double.Parse(ds.Tables[0].Rows[i]["LIANXU"].ToString());
            }
        }

        private void refreshWindValue(int intCr)
        {
            string strSQL = "select * from CURRENT_WIND_RECORD";
            string strTableName = "CURRENT_WIND_RECORD";
            DataSet ds = new DataSet();
            int intInfo = oracleDAO.getDataSet(strSQL, strTableName, ds, intCr);

            if (intInfo == 0)//查询失败
            {
                return;
            }

            for (int i = 0; i < clsPublicStatic.intWindNum[intCr] - 1; i++)
            {
                clsPublicStatic.windPositionV[intCr, i + 1] = double.Parse(ds.Tables[0].Rows[i]["FENGSU"].ToString());
            }
        }

        private void refreshAlarmData(int intCr)
        {
            string strConn = AppUtil.conStrArray[intCr];
            string strSQL = "select * from STATION_ALARM_HISTORY where END_STATUS=0 order by ID desc";
            string strTableName = "T" + intCr;
            DataSet ds = new DataSet();
            int intInfo = oracleDAO.getDataSet(strConn, strSQL, strTableName, ds, intCr);

            DataTable dt;

            if (intInfo == 0)//查询失败
            {
                if (dsAlarmData.Tables.Contains(strTableName))
                {
                    return;
                }
                //连接失败
                //MessageBox.Show("查询失败！");
                dt = clsPublicStatic.initAlarmTable(strTableName);
            }
            else
            {
                dt = clsPublicStatic.TranslateAlarm(ds, strTableName);
            }

            if (dsAlarmData.Tables.Contains(strTableName))
            {
                dsAlarmData.Tables.Remove(strTableName);
                dsAlarmData.AcceptChanges();
            }

            dsAlarmData.Tables.Add(dt);
            dsAlarmData.AcceptChanges();

        }

        

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string strTableName = "T" + intCr;

            if (dsAlarmData.Tables.Contains(strTableName))
            {
                refreshDgv(strTableName);
            }

            refreshCentersStatus();

            refreshWindAlarmStatus();

            refreshRainAlarmStatus();

        }

        private void refreshRainAlarmStatus()
        {
            for (int i = 0; i < 4; i++)
            {
                refreshRainAlarmStatus(i);
            }
        }

        private void refreshRainAlarmStatus(int intCr)
        {
            for (int i = 0; i < clsPublicStatic.intRainNum[intCr]; i++)
            {
                if (clsPublicStatic.rainPositionAlarmTime[intCr, i + 1] > clsPublicStatic.rainPositionAlarmTimeUpt[intCr, i + 1])
                {
                    refreshRainAlarmStatusSig(i, intCr);
                    clsPublicStatic.rainPositionAlarmTimeUpt[intCr, i + 1] = clsPublicStatic.rainPositionAlarmTime[intCr, i + 1];
                }
            }
        }

        private void refreshRainAlarmStatusSig(int intRi, int intCr)
        {
            int[] intRiCi = clsPublicStatic.getRiCiByIndex(intRi, clsPublicStatic.lstRainPtX, intCr);
            Panel pnlMain = getPanel(intCr);
            PictureBox pbLine = (PictureBox)pnlMain.Controls.Find("rainPtAlarm_" + intRiCi[0] + "_" + intRiCi[1] + "_" + intCr, true)[0];
            int intAlarmLevel = clsPublicStatic.RainPositionAlarm[intCr, intRi+1];
            if (intAlarmLevel == 0)
            {
                pbLine.Image = global::JHGSZD.Properties.Resources.雨正常;
            }
            else if (intAlarmLevel == 1)
            {
                pbLine.Image = global::JHGSZD.Properties.Resources.雨1级报警;
            }
            else if (intAlarmLevel == 2)
            {
                pbLine.Image = global::JHGSZD.Properties.Resources.雨2级报警;
            }
        }

        private void refreshWindAlarmStatus()
        {
            for (int i = 0; i <4; i++)
            {
                refreshWindAlarmStatus(i);
            }
        }

        private void refreshWindAlarmStatus(int intCr)
        {
            for (int i = 0; i < clsPublicStatic.intWindNum[intCr]-1; i++)
            {
                if (clsPublicStatic.windPositionAlarmTime[intCr, i + 1] > clsPublicStatic.windPositionAlarmTimeUpt[intCr, i + 1])
                {
                    refreshWindAlarmStatusSig(i, intCr);
                    clsPublicStatic.windPositionAlarmTimeUpt[intCr, i + 1] = clsPublicStatic.windPositionAlarmTime[intCr, i + 1];
                }
            }
        }

        private void refreshWindAlarmStatusSig(int intWi, int intCr)
        {
            int[] intRiCi = clsPublicStatic.getRiCiByIndex(intWi, clsPublicStatic.lstWindPtX, intCr);
            Panel pnlMain = getPanel(intCr);
            PictureBox pb = (PictureBox)pnlMain.Controls.Find("windPtAlarm_" + intRiCi[0] + "_" + intRiCi[1] + "_" + intCr, true)[0];
            int intAlarmLevel = clsPublicStatic.windPositionAlarm[intCr, intWi+1];
            if (intAlarmLevel == 0)
            {
                pb.BackgroundImage = global::JHGSZD.Properties.Resources.正常状态;
            }
            else if (intAlarmLevel == 1)
            {
                pb.BackgroundImage = global::JHGSZD.Properties.Resources._15_20蓝色报警状态;
            }
            else if (intAlarmLevel == 2)
            {
                pb.BackgroundImage = global::JHGSZD.Properties.Resources._20_25黄色报警状态;
            }
            else if (intAlarmLevel == 3)
            {
                pb.BackgroundImage = global::JHGSZD.Properties.Resources._25_30橙色报警状态;
            }
            else if (intAlarmLevel == 4)
            {
                pb.BackgroundImage = global::JHGSZD.Properties.Resources._30红色报警状态;
            }
        }

        private Panel getPanel(int intCr)
        {
            if (intCr == 0)
            {
                return pnl_TJ;
            }
            else if (intCr == 1)
            {
                return pnl_JN;
            }
            else if (intCr == 2)
            {
                return pnl_BB;
            }
            else
            {
                return pnl_NJ;
            }
        }

        private void refreshCentersStatus()
        {
            refreshCenterStatus(0, btnTJ);
            refreshCenterStatus(1, btnJN);
            refreshCenterStatus(2, btnBB);
            refreshCenterStatus(3, btnNJ);
        }

        private void refreshCenterStatus(int intCr, Button btnCr)
        {
            if (AppUtil.appDBstatus[intCr] == 0)
            {
                //btnCr.BackColor = Color.Red;
                btnCr.ForeColor = Color.Red;
            }
            else
            {
                //btnCr.BackColor = Color.White;
                btnCr.ForeColor = Color.Black;
            }
        }

        private void refreshDgv(string strTableName)
        {
            DataGridView dgv = dataGridView1;
            if (intCr == 0)
            {
                dgv = dataGridView1;
            }
            else if (intCr == 1)
            {
                dgv = dataGridView2;
            }
            else if (intCr == 2)
            {
                dgv = dataGridView4;
            }
            else if (intCr == 3)
            {
                dgv = dataGridView3;
            }

            dgv.DataSource = dsAlarmData.Tables[strTableName];
            dgv.Columns["基站里程"].Width = 150;
            dgv.Columns["设备类型"].Width = 150;
            dgv.Columns["信息类型"].Width = 150;
            dgv.Columns["报警开始时间"].Width = 180;
            dgv.Columns["报警结束时间"].Width = 180;
            dgv.Refresh();

            //if (intCr == 0)
            //{
            //    dataGridView1.DataSource = dsAlarmData.Tables[strTableName];
            //    dataGridView1.Columns["基站里程"].Width = 150;
            //    dataGridView1.Columns["设备类型"].Width = 150;
            //    dataGridView1.Columns["信息类型"].Width = 150;
            //    dataGridView1.Columns["报警开始时间"].Width = 180;
            //    dataGridView1.Columns["报警结束时间"].Width = 180;
            //    dataGridView1.Refresh();
            //}
            //else if (intCr == 1)
            //{
            //    dataGridView2.DataSource = dsAlarmData.Tables[strTableName];
            //    dataGridView2.Columns["基站里程"].Width = 150;
            //    dataGridView2.Columns["设备类型"].Width = 150;
            //    dataGridView2.Columns["信息类型"].Width = 150;
            //    dataGridView2.Columns["报警开始时间"].Width = 180;
            //    dataGridView2.Columns["报警结束时间"].Width = 180;
            //    dataGridView2.Refresh();
            //}
            //else if (intCr == 2)
            //{
            //    dataGridView4.DataSource = dsAlarmData.Tables[strTableName];
            //    dataGridView4.Columns["基站里程"].Width = 150;
            //    dataGridView4.Columns["设备类型"].Width = 150;
            //    dataGridView4.Columns["信息类型"].Width = 150;
            //    dataGridView4.Columns["报警开始时间"].Width = 180;
            //    dataGridView4.Columns["报警结束时间"].Width = 180;
            //    dataGridView4.Refresh();
            //}
            //else if (intCr == 3)
            //{
            //    dataGridView3.DataSource = dsAlarmData.Tables[strTableName];
            //    dataGridView3.Columns["基站里程"].Width = 150;
            //    dataGridView3.Columns["设备类型"].Width = 150;
            //    dataGridView3.Columns["信息类型"].Width = 150;
            //    dataGridView3.Columns["报警开始时间"].Width = 180;
            //    dataGridView3.Columns["报警结束时间"].Width = 180;
            //    dataGridView3.Refresh();
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker2.IsBusy)
            {
                backgroundWorker2.RunWorkerAsync();
            }

            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
                //Console.WriteLine(DateTime.Now.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmQueryEquip from = new frmQueryEquip();
            from.intCr = intCr;
            from.Show();
        }

        private void btnFUtime_Click(object sender, EventArgs e)
        {
            frmLiveFU form = new frmLiveFU();
            form.intCr = intCr;
            form.Show();
        }

        private void btnQueryFU_Click(object sender, EventArgs e)
        {
            frmQueryFU from = new frmQueryFU();
            from.intCr = intCr;
            from.Show();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            refreshSysTime();
        }

        private void refreshSysTime()
        {
            DateTime dt = DateTime.Now;

            lblSysDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lblSysTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

    }
}
