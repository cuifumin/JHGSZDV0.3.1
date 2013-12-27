using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace JHGSZD
{
    class AppUtil
    {
        public static int privateLogin = 0;

        public static int publicLogin = 0;

        public static string appName = "京沪高铁";

        public static string[] appAliasArray = new string[] { "JHTJDB", "JHJNDB", "JHBBDB", "JHNJDB" };

        public static string[] appType = new string[] { "风", "异物", "雨", "地震" };

        public static int[] appDBstatus = new int[4];
        public static int intCr = 0;

        public static string appPath = "D:\\query_wh\\";

        public static string configFileName = "\\config.txt";

        public static string logPath = appPath + "syslog\\";

        //public static string appPath = Application.StartupPath;

        ////public static string configFileName = "\\config.txt";

        //public static string logPath = "D:\\query_wh\\syslog\\";

        public static string[] conStrArray = new string[]{
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.4.209) (PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=JHTJDB)));Persist Security Info=True;User Id=root; Password=jcad;",
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.4.219) (PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=JHJNDB)));Persist Security Info=True;User Id=root; Password=jcad;",
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.4.229) (PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=JHBBDB)));Persist Security Info=True;User Id=root; Password=jcad;",
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.4.239) (PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=JHNJDB)));Persist Security Info=True;User Id=root; Password=jcad;"};

         static  AppUtil()
        {
            try
            {
                if (!Directory.Exists(logPath))
                {
                    Directory.CreateDirectory(logPath);
                }
            }
            catch (Exception)
            {
            }
        }

        //返回1代表读取成功，返回0没有找到, 返回-1 异常
        public static int read(string name, ref string array)
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(AppUtil.appPath + AppUtil.configFileName, Encoding.Default);
                string content = sr.ReadLine();

                while (content != null)
                {
                    string[] row = content.Split('=');

                    if (name.Equals(row[0].Trim()))
                    {
                        array = row[1];
                        return 1;
                    }
                    content = sr.ReadLine();
                }

                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                try
                {
                    sr.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        public static int read(string name, ref string[] array)
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(AppUtil.appPath + AppUtil.configFileName, Encoding.Default);
                string content = sr.ReadLine();

                while (content != null)
                {
                    string[] row = content.Split('=');

                    if (name.Equals(row[0].Trim()))
                    {
                        string[] rows = row[1].Split(',');
                        array = new string[rows.Length];

                        for (int i = 0; i < rows.Length; i++)
                        {
                            array[i] = rows[i];
                        }
                        return 1;
                    }
                    content = sr.ReadLine();
                }

                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                try
                {
                    sr.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        public static int read(string name, int intCr,ref string[] array)
        {
            StreamReader sr = null;

            try
            {
                string strConfigName = "";

                if (intCr == 0)
                {
                    strConfigName = "\\TJ_Config.txt";
                }
                else if (intCr == 1)
                {
                    strConfigName = "\\JN_Config.txt";
                }
                else if (intCr == 2)
                {
                    strConfigName = "\\BB_Config.txt";
                }
                else if (intCr == 3)
                {
                    strConfigName = "\\NJ_Config.txt";
                }

                sr = new StreamReader(AppUtil.appPath + strConfigName, Encoding.Default);
                string content = sr.ReadLine();

                while (content != null)
                {
                    string[] row = content.Split('=');

                    if (name.Equals(row[0].Trim()))
                    {
                        string[] rows = row[1].Split(',');
                        array = new string[rows.Length];

                        for (int i = 0; i < rows.Length; i++)
                        {
                            array[i] = rows[i];
                        }
                        return 1;
                    }
                    content = sr.ReadLine();
                }

                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                try
                {
                    sr.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        public static int read(string name,int intCr, ref string[,] array)
        {
            StreamReader sr = null;

            try
            {
                string strConfigName = "";

                if (intCr==0)
                {
                    strConfigName = "\\TJ_Config.txt";
                }
                else if (intCr == 1)
                {
                    strConfigName = "\\JN_Config.txt";
                }
                else if (intCr == 2)
                {
                    strConfigName = "\\BB_Config.txt";
                }
                else if (intCr == 3)
                {
                    strConfigName = "\\NJ_Config.txt";
                }

                sr = new StreamReader(AppUtil.appPath + strConfigName, Encoding.Default);
                string content = sr.ReadLine();

                while (content != null)
                {
                    string[] row = content.Split('=');

                    if (name.Equals(row[0].Trim()))
                    {
                        string[] rows = row[1].Split(',');

                        for (int i = 0; i < rows.Length; i++)
                        {
                            array[intCr,i] = rows[i];
                        }
                        return 1;
                    }
                    content = sr.ReadLine();
                }

                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                try
                {
                    sr.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        public static int read(string name, int intCr, ref string[,] array,ref int[] intNum)
        {
            StreamReader sr = null;

            try
            {
                string strConfigName = "";

                if (intCr == 0)
                {
                    strConfigName = "\\TJ_Config.txt";
                }
                else if (intCr == 1)
                {
                    strConfigName = "\\JN_Config.txt";
                }
                else if (intCr == 2)
                {
                    strConfigName = "\\BB_Config.txt";
                }
                else if (intCr == 3)
                {
                    strConfigName = "\\NJ_Config.txt";
                }

                sr = new StreamReader(AppUtil.appPath + strConfigName, Encoding.Default);
                string content = sr.ReadLine();

                while (content != null)
                {
                    string[] row = content.Split('=');

                    if (name.Equals(row[0].Trim()))
                    {
                        string[] rows = row[1].Split(',');

                        intNum[intCr]=rows.Length;

                        for (int i = 0; i < rows.Length; i++)
                        {
                            array[intCr, i] = rows[i];
                        }
                        return 1;
                    }
                    content = sr.ReadLine();
                }

                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                try
                {
                    sr.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        public static int read(string name, ref string[][] array)
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(AppUtil.appPath + AppUtil.configFileName, Encoding.Default);
                string content = sr.ReadLine();

                while (content != null)
                {
                    string[] row = content.Split('=');

                    if (name.Equals(row[0].Trim()))
                    {
                        string[] arrays = row[1].Split(';');
                        array = new string[arrays.Length][];

                        for (int i = 0; i < arrays.Length; i++)
                        {
                            string[] rows = arrays[i].Split(',');
                            array[i] = new string[rows.Length];

                            for (int j = 0; j < rows.Length; j++)
                            {
                                array[i][j] = rows[j];
                            }
                        }

                        return 1;
                    }
                    content = sr.ReadLine();
                }

                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                try
                {
                    sr.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        public static int read(string name, ref int array)
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(AppUtil.appPath + AppUtil.configFileName, Encoding.Default);
                string content = sr.ReadLine();

                while (content != null)
                {
                    string[] row = content.Split('=');

                    if (name.Equals(row[0].Trim()))
                    {
                        array = Convert.ToInt32(row[1]);
                        return 1;
                    }
                    content = sr.ReadLine();
                }

                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                try
                {
                    sr.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        public static int read(string name, ref int[] array)
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(AppUtil.appPath + AppUtil.configFileName, Encoding.Default);
                string content = sr.ReadLine();

                while (content != null)
                {
                    string[] row = content.Split('=');
                    if (name.Equals(row[0].Trim()))
                    {
                        string[] rows = row[1].Split(',');
                        array = new int[rows.Length];
                        for (int i = 0; i < rows.Length; i++)
                        {
                            array[i] = Convert.ToInt32(rows[i]);
                        }
                        return 1;
                    }
                    content = sr.ReadLine();
                }

                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                try
                {
                    sr.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        public static int read(string name, ref int[][] array)
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(AppUtil.appPath + AppUtil.configFileName, Encoding.Default);
                string content = sr.ReadLine();

                while (content != null)
                {
                    string[] row = content.Split('=');
                    if (name.Equals(row[0].Trim()))
                    {
                        string[] arrays = row[1].Split(';');
                        array = new int[arrays.Length][];

                        for (int i = 0; i < arrays.Length; i++)
                        {
                            string[] rows = arrays[i].Split(',');
                            array[i] = new int[rows.Length];

                            for (int j = 0; j < rows.Length; j++)
                            {
                                array[i][j] = Convert.ToInt32(rows[j]);
                            }
                        }
                        return 1;
                    }
                    content = sr.ReadLine();
                }

                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                try
                {
                    sr.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        public static int read(string name, ref DateTime array)
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(AppUtil.appPath + AppUtil.configFileName, Encoding.Default);
                string content = sr.ReadLine();

                while (content != null)
                {
                    string[] row = content.Split('=');

                    if (name.Equals(row[0]))
                    {
                        array = DateTime.Parse(row[1].ToString());
                        return 1;
                    }
                    content = sr.ReadLine();
                }

                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                try
                {
                    sr.Close();
                }
                catch (Exception)
                {
                }
            }
        }

    }
}
