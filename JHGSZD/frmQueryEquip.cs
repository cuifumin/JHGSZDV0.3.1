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
    public partial class frmQueryEquip : Form
    {
        public frmQueryEquip()
        {
            InitializeComponent();
        }

        DataSet dsAlarmData = new DataSet();

        public int intCr = -1;
        private static int[] intFilter = new int[4] { 1, 1, 1, 1 };

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strConn = AppUtil.conStrArray[intCr];
            string strSQL = getStringSQL();
            queryBySQL(strConn, strSQL);
        }

        private void queryBySQL(string strConn, string strSQL)
        {
            string strTableName = "data";
            DataSet ds = new DataSet();
            int intInfo = oracleDAO.getDataSet(strConn, strSQL, strTableName, ds,intCr);

            DataTable dt;

            if (intInfo == 0)//查询失败
            {
                //连接失败
                MessageBox.Show("查询失败！");
                dt = clsPublicStatic.initAlarmTable(strTableName);
            }
            else
            {
                dt = clsPublicStatic.TranslateAlarm(ds, strTableName, intFilter);
            }

            if (dsAlarmData.Tables.Contains(strTableName))
            {
                dsAlarmData.Tables.Remove(strTableName);
                dsAlarmData.AcceptChanges();
            }

            dsAlarmData.Tables.Add(dt);
            dsAlarmData.AcceptChanges();

            if (dsAlarmData.Tables.Contains(strTableName))
            {
                dataGridView1.DataSource = dsAlarmData.Tables[strTableName];
                dataGridView1.Columns["基站里程"].Width = 150;
                dataGridView1.Columns["设备类型"].Width = 150;
                dataGridView1.Columns["信息类型"].Width = 150;
                dataGridView1.Columns["报警开始时间"].Width = 180;
                dataGridView1.Columns["报警结束时间"].Width = 180;
                dataGridView1.Refresh();
            }
        }

        private string getStringSQL()
        {
            string strSQL = "";
            if (cbo_Pname.SelectedIndex == 0)
            {
                strSQL = "select * from STATION_ALARM_HISTORY where datetime>=to_date('" + dtpStart.Value + "', 'yyyy-mm-dd hh24:mi:ss') and datetime<=to_date('" + dtpEnd.Value + "', 'yyyy-mm-dd hh24:mi:ss') order by ID desc";
            }
            else
            {
                strSQL = "select * from  STATION_ALARM_HISTORY where stationID='" + cbo_Pname.SelectedItem.ToString() + "' and datetime>=to_date('" + dtpStart.Value + "', 'yyyy-mm-dd hh24:mi:ss') and datetime<=to_date('" + dtpEnd.Value + "', 'yyyy-mm-dd hh24:mi:ss') order by ID desc";
            }

            return strSQL;
        }

        public int intType = -1;
        public int intIndex = -1;

        private void frmQuery_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Parse(DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd HH:mm:ss"));
            dtpEnd.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            if (intType != -1)
            {
                comboBox1.SelectedIndex = intCr;

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;

                string strK = "";
                if (intType == 0)
                {
                    checkBox1.Checked = true;
                    strK = clsPublicStatic.windStationK[intCr, intIndex + 1];
                }
                else if (intType == 1)
                {
                    checkBox2.Checked = true;
                    strK = clsPublicStatic.YwStationK[intCr, intIndex + 1];
                }
                else if (intType == 2)
                {
                    checkBox3.Checked = true;
                    strK = clsPublicStatic.rainStationK[intCr, intIndex + 1];
                }
                else if (intType == 3)
                {
                    checkBox4.Checked = true;
                    strK = clsPublicStatic.DzStationK[intCr, intIndex + 1];
                }

                queryLoad(strK);
            }
            else
            {
                comboBox1.SelectedIndex = intCr;
            }

        }

        private void queryLoad(string strK)
        {

            cbo_Pname.Text = strK;

            string strConn = AppUtil.conStrArray[intCr];
            string strSQL = "";

            strSQL = "select * from  STATION_ALARM_HISTORY where stationID='" + strK + "' and datetime>=to_date('" + dtpStart.Value + "', 'yyyy-mm-dd hh24:mi:ss') and datetime<=to_date('" + dtpEnd.Value + "', 'yyyy-mm-dd hh24:mi:ss') order by ID desc";

            queryBySQL(strConn, strSQL);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                intFilter[0] = 1;
            }
            else
            {
                intFilter[0] = 0;
            }

            filterResult();
        }

        private void filterResult()
        {

            //if (dsAlarmData.Tables.Count == 0)
            //{
            //    return;
            //}

            //if (dsAlarmData.Tables[0].Rows.Count == 0)
            //{
            //    return;
            //}



        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                intFilter[1] = 1;
            }
            else
            {
                intFilter[1] = 0;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                intFilter[2] = 1;
            }
            else
            {
                intFilter[2] = 0;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                intFilter[3] = 1;
            }
            else
            {
                intFilter[3] = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            intCr = comboBox1.SelectedIndex;

            refreshCobList();
        }

        private void refreshCobList()
        {
            cbo_Pname.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                string str = "";
                try
                {
                    str = clsPublicStatic.StationKAll[intCr, i].ToString();
                }
                catch (Exception)
                {
                    break;
                }

                cbo_Pname.Items.Add(str);
            }
            cbo_Pname.SelectedIndex = 0;
        }
    }
}
