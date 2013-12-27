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
    public partial class frmQueryFU : Form
    {
        public frmQueryFU()
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
            int intInfo = oracleDAO.getDataSet(strConn, strSQL, strTableName, ds, intCr);

            DataTable dt;

            if (intInfo == 0)//查询失败
            {
                //连接失败
                MessageBox.Show("查询失败！");

                if (intType == 0)
                {
                    dt = clsPublicStatic.initWindLishiTable(strTableName);
                }
                else
                {
                    dt = clsPublicStatic.initRainLishiTable(strTableName);
                }
            }
            else
            {
                if (intType == 0)
                {
                    dt = clsPublicStatic.initWindLishiTable(strTableName);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DataRow row = dt.NewRow();
                        row[0] = ds.Tables[0].Rows[i]["datetime"].ToString();
                        row[1] = ds.Tables[0].Rows[i]["fengsu"].ToString();
                        dt.Rows.Add(row);
                    }
                    dt.AcceptChanges();
                }
                else
                {
                    dt = clsPublicStatic.initRainLishiTable(strTableName);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DataRow row = dt.NewRow();
                        row[0] = ds.Tables[0].Rows[i]["datetime"].ToString();
                        row[1] = ds.Tables[0].Rows[i]["HYULIANG"].ToString();
                        row[2] = ds.Tables[0].Rows[i]["24hyuliang"].ToString();
                        row[3] = ds.Tables[0].Rows[i]["LIANXUYULIANG"].ToString();
                        dt.Rows.Add(row);
                    }
                    dt.AcceptChanges();
                }

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

                dataGridView1.Columns["时间"].Width = 180;
                if (intType==0)
                {
                    dataGridView1.Columns["风速"].Width = 150;
                }
                else
                {
                    dataGridView1.Columns["小时雨量"].Width = 150;
                    dataGridView1.Columns["小时雨量"].Width = 150;
                    dataGridView1.Columns["连续雨量"].Width = 150;
                }
                
                dataGridView1.Refresh();
            }
        }

        private string getStringSQL()
        {
            string strSQL = "";

            string strTableName = "";
            if (intType == 0)
            {
                strTableName = "FENG_LISHI_" + clsPublicStatic.windPositionName[intCr, comboBox1.SelectedIndex + 1];
            }
            else
            {
                strTableName = "RAIN_LISHI_" + clsPublicStatic.rainPositionName[intCr, comboBox1.SelectedIndex + 1];
            }

            strSQL = "select * from  " + strTableName + " where  datetime>=to_date('" + dtpStart.Value + "', 'yyyy-mm-dd hh24:mi:ss') and datetime<=to_date('" + dtpEnd.Value + "', 'yyyy-mm-dd hh24:mi:ss') order by ID";
            return strSQL;
        }

        public int intType = -1;
        public int intIndex = -1;

        private void frmQuery_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Parse(DateTime.Now.AddHours(-1).ToString("yyyy-MM-dd HH:mm:ss"));
            dtpEnd.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            if (intType != -1)
            {
                if (intType == 1)
                {
                    radioButton2.Checked = true;
                }
                comboBox1.SelectedIndex = intCr;

                string strK = "";
                if (intType == 0)
                {
                    strK = clsPublicStatic.windPositionK[intCr, intIndex + 1];
                }
                else if (intType == 1)
                {
                    strK = clsPublicStatic.rainPositionK[intCr, intIndex + 1];
                }

                queryLoad(strK);

            }
            else
            {
                intType = 0;
                comboBox1.SelectedIndex = intCr;
            }

        }

        private void queryLoad(string strK)
        {

            cbo_Pname.Text = strK;

            string strConn = AppUtil.conStrArray[intCr];
            string strSQL = "";

            strSQL = getStringSQL();

            queryBySQL(strConn, strSQL);

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            intCr = comboBox1.SelectedIndex;

            refreshCobList();
        }

        private void refreshCobList()
        {
            cbo_Pname.Items.Clear();
            for (int i = 1; i < 100; i++)
            {
                string str = "";
                try
                {
                    if (intType != 1)
                    {
                        str = clsPublicStatic.windPositionK[intCr, i].ToString();
                    }
                    else
                    {
                        str = clsPublicStatic.rainPositionK[intCr, i].ToString();
                    }

                }
                catch (Exception)
                {
                    break;
                }

                cbo_Pname.Items.Add(str);
            }
            cbo_Pname.SelectedIndex = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            intType = 0;
            refreshCobList();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            intType = 1;
            refreshCobList();
        }
    }
}
