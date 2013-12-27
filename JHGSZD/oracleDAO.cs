using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
using System.Data;

namespace JHGSZD
{
    class oracleDAO
    {
        public static StringBuilder exceptionMsg;

        public static DataSet getDataSet(string conStr, string sql, string tableName)
        {
            DataSet dataSet = new DataSet();
            OracleConnection con = ConnectionUtil.getConn(conStr);
            OracleDataAdapter adapter = new OracleDataAdapter(sql, con);

            try
            {
                con.Open();
                adapter.Fill(dataSet, tableName);

                return dataSet;
            }
            catch (Exception e)
            {
                exceptionMsg = new StringBuilder().AppendLine("exception message : " + e.Message).AppendLine("exception stacktrace : " + e.StackTrace).AppendLine("connect string : " + conStr).AppendLine("sql : " + sql);
                return null;
            }
            finally
            {
                ConnectionUtil.closeConn(con);
            }
        }

        public static int getDataSet(string conStr, string sql, string tableName, DataSet dsData)
        {

            if (dsData.Tables.Contains(tableName))
            {
                dsData.Tables.Remove(tableName);
                dsData.AcceptChanges();
            }

            OracleConnection con = ConnectionUtil.getConn(conStr);
            OracleDataAdapter adapter = new OracleDataAdapter(sql, con);

            try
            {
                con.Open();
                if (AppUtil.appDBstatus[AppUtil.intCr] == 0)
                {
                    AppUtil.appDBstatus[AppUtil.intCr] = 1;
                }
                adapter.Fill(dsData, tableName);
                return 1;
            }
            catch (Exception e)
            {

                if (AppUtil.appDBstatus[AppUtil.intCr] == 1)
                {
                    AppUtil.appDBstatus[AppUtil.intCr] = 0;
                }

                exceptionMsg = new StringBuilder().AppendLine("exception message : " + e.Message).AppendLine("exception stacktrace : " + e.StackTrace).AppendLine("connect string : " + conStr).AppendLine("sql : " + sql);
                return 0;
            }
            finally
            {
                ConnectionUtil.closeConn(con);
            }
        }

        public static int getDataSet(string sql, string tableName, DataSet dsData, int intCr)
        {
            string conStr = AppUtil.conStrArray[intCr];

            if (dsData.Tables.Contains(tableName))
            {
                dsData.Tables.Remove(tableName);
                dsData.AcceptChanges();
            }

            OracleConnection con = ConnectionUtil.getConn(conStr);
            OracleDataAdapter adapter = new OracleDataAdapter(sql, con);

            try
            {
                con.Open();
                if (AppUtil.appDBstatus[intCr] == 0)
                {
                    AppUtil.appDBstatus[intCr] = 1;
                }
                adapter.Fill(dsData, tableName);
                return 1;
            }
            catch (Exception e)
            {

                if (AppUtil.appDBstatus[intCr] == 1)
                {
                    AppUtil.appDBstatus[intCr] = 0;
                }

                exceptionMsg = new StringBuilder().AppendLine("exception message : " + e.Message).AppendLine("exception stacktrace : " + e.StackTrace).AppendLine("connect string : " + conStr).AppendLine("sql : " + sql);
                return 0;
            }
            finally
            {
                ConnectionUtil.closeConn(con);
            }
        }

        public static int getDataSet(string conStr, string sql, string tableName, DataSet dsData, int intCr)
        {

            if (dsData.Tables.Contains(tableName))
            {
                dsData.Tables.Remove(tableName);
                dsData.AcceptChanges();
            }

            OracleConnection con = ConnectionUtil.getConn(conStr);
            OracleDataAdapter adapter = new OracleDataAdapter(sql, con);

            try
            {
                con.Open();
                if (AppUtil.appDBstatus[intCr] == 0)
                {
                    AppUtil.appDBstatus[intCr] = 1;
                }
                adapter.Fill(dsData, tableName);
                return 1;
            }
            catch (Exception e)
            {

                if (AppUtil.appDBstatus[intCr] == 1)
                {
                    AppUtil.appDBstatus[intCr] = 0;
                }

                exceptionMsg = new StringBuilder().AppendLine("exception message : " + e.Message).AppendLine("exception stacktrace : " + e.StackTrace).AppendLine("connect string : " + conStr).AppendLine("sql : " + sql);
                return 0;
            }
            finally
            {
                ConnectionUtil.closeConn(con);
            }
        }

        public static DateTime getTimeNow(string conStr)
        {
            DateTime dtNow = DateTime.Now;
            string tableName = "dual";
            string sql = "select sysdate from dual";
            DataSet dataSet = oracleDAO.getDataSet(conStr, sql, tableName);

            try
            {
                if (dataSet != null && dataSet.Tables.Count == 1 && dataSet.Tables[tableName].Rows.Count == 1)
                {
                    dtNow = DateTime.Parse(dataSet.Tables[tableName].Rows[0][0].ToString());
                }
            }
            catch (Exception)
            {
            }

            return dtNow;
        }

    }

    class ConnectionUtil
    {
        public static OracleConnection getConn(string conStr)
        {
            OracleConnection conn = null;

            try
            {
                conn = new OracleConnection(conStr);
            }
            catch (Exception)
            {
            }
            return conn;
        }

        public static void closeConn(OracleConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (Exception)
            {
            }
        }
    }

}
