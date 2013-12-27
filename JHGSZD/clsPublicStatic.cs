using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace JHGSZD
{

    class clsPublicStatic
    {
        public static int intRailNumber = 3;

        public static int[,] intAppServerStatus = new int[3, 10];
        public static int[,] intAppServerStatus_ZB = new int[3, 5];

        public static int intStartX = 15;
        public static int intStartY = 94;

        //界面图标标准
        public static int intLineHeight = 4;
        //轨道双线间距
        public static int intLineDistance = 34;

        //轨道双线间距
        public static int intLine2 = 200;

        public static int intlineNum = 100;

        public static int[] intWindNum = new int[4];
        public static int[] intRainNum = new int[4];

        public static int[,] intWindAlarmLevel = new int[4, 100];

        public static int intStationNum_Rain = 3;
        //public static int[] intRainAlm = new int[intRainNum];
        public static int[,] intRainAlarmLevel = new int[4, 100];
        public static string[,] intRainAlarmTime = new string[4, 100];

        public static int intYwNum = 3;
        public static int intStationNum_Yw = 2;
        public static int[] intYwStationYwNum = new int[2] { 2, 1 };

        public static int intStationNum_DZ = 3;

        public static List<int>[,] lstLineLength = new List<int>[4, 4];
        //车站里程
        public static List<string>[,] lstTrainStationK = new List<string>[4, 4];
        //车站名称
        public static List<string>[,] lstTrainStationName = new List<string>[4, 4];
        //车站位置
        public static List<int>[,] lstTrainStationPtX = new List<int>[4, 4];
        //风监测点里程
        public static List<string>[,] lstWindPtK = new List<string>[4, 4];
        //风监测点位置
        public static List<int>[,] lstWindPtX = new List<int>[4, 4];
        //异物监测点里程
        public static List<string>[,] lstYwPostionK = new List<string>[4, 4];
        //异物监测点名称
        public static List<string>[,] lstYwPostionName = new List<string>[4, 4];
        //异物监测点里程
        public static List<int>[,] lstYwPostionPtX = new List<int>[4, 4];
        //雨监测点里程
        public static List<string>[,] lstRainPostionK = new List<string>[4, 4];
        //雨物监测点名称
        public static List<string>[,] lstRainPostionName = new List<string>[4, 4];
        //雨物监测点里程
        public static List<int>[,] lstRainPtX = new List<int>[4, 4];

        //地震监测点里程
        public static List<string>[,] lstDZPostionK = new List<string>[4, 4];
        //地震监测点名称
        public static List<string>[,] lstDZPostionName = new List<string>[4, 4];
        //地震监测点里程
        public static List<int>[,] lstDZPostionPtX = new List<int>[4, 4];

        //地震监测点里程
        public static List<string>[] lstStationK = new List<string>[4];

        private static int[] intLineIndex = new int[4];
        private static int[] intWindIndex = new int[4];
        private static int[] intYwIndex = new int[4];
        private static int[] intRainIndex = new int[4];
        private static int[] intEqIndex = new int[4];

        private static int[] intStartPtX = new int[4];
        public static int[] intStationPtX = new int[4];

        public static string[,] windPositionName = new string[4, 100];
        public static string[,] windPositionK = new string[4, 100];
        public static string[,] windPositionLimitStartK = new string[4, 100];
        public static string[,] windPositionLimitEndK = new string[4, 100];
        public static string[,] rainPositionK = new string[4, 100];
        public static string[,] rainPositionName = new string[4, 100];
        public static string[,] rainPositionLimitStartK = new string[4, 100];
        public static string[,] rainPositionLimitEndK = new string[4, 100];
        public static string[,] YwPositionName = new string[4, 100];
        public static string[,] DzPositionName = new string[4, 100];

        public static int[,] windPositionAlarm = new int[4, 100];
        public static int[,] RainPositionAlarm = new int[4, 100];
        public static DateTime[,] windPositionAlarmTime = new DateTime[4, 100];
        public static DateTime[,] windPositionAlarmTimeUpt = new DateTime[4, 100];
        public static DateTime[,] rainPositionAlarmTime = new DateTime[4, 100];
        public static DateTime[,] rainPositionAlarmTimeUpt = new DateTime[4, 100];

        public static double[,] windPositionV = new double[4, 100];
        //public static double[,] windPositionVtime = new double[4, 100];

        public static double[,] rainPositionHour = new double[4, 100];
        public static double[,] rainPositionDay = new double[4, 100];
        public static double[,] rainPositionContinuours = new double[4, 100];
        //public static double[,] RainPositionHour = new double[4, 100];

        public static string[,] StationKAll = new string[4, 100];
        public static string[,] windStationK = new string[4, 100];
        public static string[,] rainStationK = new string[4, 100];
        public static string[,] YwStationK = new string[4, 100];
        public static string[,] DzStationK = new string[4, 100];

        private static int[,] intWindJG = new int[4, 2] { { 80, 50 }, { 65, 50 }, { 80, 50 }, { 67, 50 } };
        private static int[,] intRainJG = new int[4, 2] { { 80, 50 }, { 65, 50 }, { 80, 50 }, { 67, 50 } };
        private static int[,] intYwJG = new int[4, 2] { { 40, 100 }, { 30, 60 }, { 40, 100 }, { 15, 50 } };
        private static int[,] intDzJG = new int[4, 2] { { 40, 80 }, { 30, 70 }, { 40, 80 }, { 22, 60 } };


        public static string[] strWindAlarmLimit = new string[] { "正常行驶", "限速300km/h", "限速200km/h", "限速120km/h", "停车" };

        public static string[] strZDname = new string[3] { "调度终端", "工务调度终端", "工务终端" };
        public static string[] strPsType = new string[5] { "风", "雨", "雪", "异物", "地震" };
        public static string[] strZBType = new string[2] { "主板", "备板" };


        public static void setAppSvrStatus(int intZDType, int intPsType, int intZBindex, int intValue)
        {
            intAppServerStatus[intZDType - 1, intPsType * 2 + intZBindex] = intValue;
        }

        public static int getAppSvrStatus(int intZDType, int intPsType, int intZBindex)
        {
            int intValue = intAppServerStatus[intZDType - 1, intPsType * 2 + intZBindex];
            return intValue;
        }

        public static void init()
        {

            initPositionList();
            //initImageList();

            initSysList(0);
            initSysList(1);
            initSysList(2);
            initSysList(3);

        }

        private static void initPositionList()
        {
            for (int i = 0; i < 4; i++)
            {
                initPositionList(i);
            }
        }

        private static int initPositionList(int intCenter)
        {
            if (AppUtil.read("windPositionK", intCenter, ref windPositionK, ref intWindNum) <= 0) return 0;
            if (AppUtil.read("windPositionName", intCenter, ref windPositionName) <= 0) return 0;
            if (AppUtil.read("rainPositionK", intCenter, ref rainPositionK, ref intRainNum) <= 0) return 0;
            if (AppUtil.read("rainPositionName", intCenter, ref rainPositionName) <= 0) return 0;
            if (AppUtil.read("dropPositionName", intCenter, ref YwPositionName) <= 0) return 0;
            if (AppUtil.read("earthQuakePositionName", intCenter, ref DzPositionName) <= 0) return 0;
            if (AppUtil.read("allStationK", intCenter, ref StationKAll) <= 0) return 0;

            if (AppUtil.read("windPositionStartK", intCenter, ref windPositionLimitStartK) <= 0) return 0;
            if (AppUtil.read("windPositionEndK", intCenter, ref windPositionLimitEndK) <= 0) return 0;
            if (AppUtil.read("rainPositionStartK", intCenter, ref rainPositionLimitStartK) <= 0) return 0;
            if (AppUtil.read("rainPositionEndK", intCenter, ref rainPositionLimitEndK) <= 0) return 0;

            if (AppUtil.read("rainPositionK", intCenter, ref rainPositionK, ref intRainNum) <= 0) return 0;

            if (AppUtil.read("windStationK", intCenter, ref windStationK) <= 0) return 0;
            if (AppUtil.read("rainPositionK", intCenter, ref rainStationK) <= 0) return 0;
            if (AppUtil.read("dropStationK", intCenter, ref YwStationK) <= 0) return 0;
            if (AppUtil.read("earthQuakeStationK", intCenter, ref DzStationK) <= 0) return 0;

            return 1;
        }

        private static void initSysList(int intCenter)
        {
            int intWi = 1;
            int intYi = 1;
            int intUi = 1;
            int intZi = 1;

            int intRi = 0;
            intStartPtX[intCenter] = 0;

            if (intCenter == 0)
            {
                initPsTJ(intCenter, ref intWi, ref intYi, ref intUi, ref intZi, ref intRi);
            }
            else if (intCenter == 1)
            {
                initPsJN(intCenter, ref intWi, ref intYi, ref intUi, ref intZi, ref intRi);
            }
            else if (intCenter == 2)
            {
                initPsBB(intCenter, ref intWi, ref intYi, ref intUi, ref intZi, ref intRi);
            }
            else if (intCenter == 3)
            {
                try
                {
                    initPsNJ(intCenter, ref intWi, ref intYi, ref intUi, ref intZi, ref intRi);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + ex.StackTrace);
                }

            }

        }

        private static void initPsNJ(int intCenter, ref int intWi, ref int intYi, ref int intUi, ref int intZi, ref int intRi)
        {

            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addYwPt(intCenter, intRi, ref intYi);
            addYwPt(intCenter, intRi, ref intYi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//铁心桥变电所
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//塘山头分区所 
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);

            addLine(intCenter, 50, intRi);
            intRi++;
            intStartPtX[intCenter] = 0;


            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);

            addDz(intCenter, intRi, ref intZi);//塘山头分区所
            addYwPt(intCenter, intRi, ref intYi);
            addYwPt(intCenter, intRi, ref intYi);

            addWindPt(intCenter, intRi, ref intWi);
            addYwPt(intCenter, intRi, ref intYi);
            addWindPt(intCenter, intRi, ref intWi);
            addYwPt(intCenter, intRi, ref intYi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);

            addDz(intCenter, intRi, ref intZi);//塘山头分区所
            addYwPt(intCenter, intRi, ref intYi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);



            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addDz(intCenter, intRi, ref intZi);//前艾变电所

            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//前艾变电所  
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);

            addLine(intCenter, 50, intRi);
            intRi++;
            intStartPtX[intCenter] = 0;


            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//昆山南变电所
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//前艾变电所
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addYwPt(intCenter, intRi, ref intYi);
            addYwPt(intCenter, intRi, ref intYi);
            addDz(intCenter, intRi, ref intZi);//虹桥牵变所
            addRainPt(intCenter, intRi, ref intUi);

            addLine(intCenter, 30, intRi);
        }

        private static void initPsBB(int intCenter, ref int intWi, ref int intYi, ref int intUi, ref int intZi, ref int intRi)
        {

            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//徐州东变电所
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//沙庄分区所
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//大贠家分区所
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);

            addLine(intCenter, 50, intRi);
            intRi++;
            intStartPtX[intCenter] = 0;

            addWindPt(intCenter, intRi, ref intWi);



            addDz(intCenter, intRi, ref intZi);//大贠家分区所
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//大贠家分区所
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addYwPt(intCenter, intRi, ref intYi);
            addYwPt(intCenter, intRi, ref intYi);
            addDz(intCenter, intRi, ref intZi);//蚌埠南变电所
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addDz(intCenter, intRi, ref intZi);//小庄子分区所
            addWindPt(intCenter, intRi, ref intWi);

            addLine(intCenter, 50, intRi);
            intRi++;
            intStartPtX[intCenter] = 0;

            addRainPt(intCenter, intRi, ref intUi);
            addYwPt(intCenter, intRi, ref intYi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//桑间变电所
            addWindPt(intCenter, intRi, ref intWi);
            addYwPt(intCenter, intRi, ref intYi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addYwPt(intCenter, intRi, ref intYi);
            addRainPt(intCenter, intRi, ref intUi);
            addLine(intCenter, 50, intRi);

        }

        private static void initPsJN(int intCenter, ref int intWi, ref int intYi, ref int intUi, ref int intZi, ref int intRi)
        {
            addRainPt(intCenter, intRi, ref intUi);
            //addTrainStation(intCenter, intRi, "K0+0", "北京南站");
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);            
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addYwPt(intCenter, intRi, ref intYi);

            addLine(intCenter, 50, intRi);
            intRi++;
            intStartPtX[intCenter] = 0;

            addRainPt(intCenter, intRi, ref intUi);

            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addYwPt(intCenter, intRi, ref intYi);

            addRainPt(intCenter, intRi, ref intUi);

            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);

            addWindPt(intCenter, intRi, ref intWi);
            addYwPt(intCenter, intRi, ref intYi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);

            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addYwPt(intCenter, intRi, ref intYi);
            addWindPt(intCenter, intRi, ref intWi);
            addYwPt(intCenter, intRi, ref intYi);
            addYwPt(intCenter, intRi, ref intYi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);

            addLine(intCenter, 50, intRi);
            intRi++;
            intStartPtX[intCenter] = 0;


            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);



            addYwPt(intCenter, intRi, ref intYi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addYwPt(intCenter, intRi, ref intYi);
            addYwPt(intCenter, intRi, ref intYi);

            addWindPt(intCenter, intRi, ref intWi);

            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//望河分区所

            //addLine(intCenter, 50, intRi);
            //intRi++;
            //intStartPtX[intCenter] = 0;

            addWindPt(intCenter, intRi, ref intWi);
            //addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addYwPt(intCenter, intRi, ref intYi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//周营变电所


            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//江庄分区所

            //addWindPt(intCenter, intRi, ref intWi);
            //addWindPt(intCenter, intRi, ref intWi);
            //addRainPt(intCenter, intRi, ref intUi);
            //addWindPt(intCenter, intRi, ref intWi);
            addLine(intCenter, 50, intRi);

        }

        private static void initPsTJ(int intCenter, ref int intWi, ref int intYi, ref int intUi, ref int intZi, ref int intRi)
        {
            addTrainStation(intCenter, intRi, "K0+0", "北京南站");
            addRainPt(intCenter, intRi, ref intUi);

            addDz(intCenter, intRi, ref intZi);//李营变电所

            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);
            addYwPt(intCenter, intRi, ref intYi);
            addRainPt(intCenter, intRi, ref intUi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//豆张庄变电所
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            

            addDz(intCenter, intRi, ref intZi);//双口分区所

            addWindPt(intCenter, intRi, ref intWi);
            addLine(intCenter, 50, intRi);
            intRi++;
            intStartPtX[intCenter] = 0;
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//华苑变电所
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//唐官屯变电所
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//周官屯分区所
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//沧州西变电所
            addRainPt(intCenter, intRi, ref intUi); 
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addDz(intCenter, intRi, ref intZi);//黄家洼分区所
            addLine(intCenter, 50, intRi);
            intRi++;
            intStartPtX[intCenter] = 0;
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addWindPt(intCenter, intRi, ref intWi);
            addRainPt(intCenter, intRi, ref intUi);
            addLine(intCenter, 50, intRi);

        }

        private static void addDz(int intCenter, int intRi, ref int intZi)
        {
            string strZi = DzPositionName[intCenter, intZi];
            addDz(intCenter, intRi, "", strZi);
            intZi++;
        }

        private static void addWindPt(int intCenter, int intRi, ref int intWi)
        {
            string strWi = windPositionK[intCenter, intWi];
            addWindPt(intCenter, intRi, strWi);
            intWi++;
        }

        private static void addRainPt(int intCenter, int intRi, ref int intWi)
        {
            string strWi = rainPositionK[intCenter, intWi];
            addRainPt(intCenter, intRi, strWi);
            intWi++;
        }

        private static void addYwPt(int intCenter, int intRi, ref int intWi)
        {
            string strWi = YwPositionName[intCenter, intWi];
            addYwPt(intCenter, intRi, "", strWi);
            intWi++;
        }

        private static void addRainPt(int intCenter, int intRi, string strRainK)
        {
            addLine(intCenter, intRainJG[intCenter, 0], intRi);

            int intPx = intStartPtX[intCenter] - 50;
            //addLine(100, intRi);

            if (lstRainPostionK[intCenter, intRi] == null)
            {
                lstRainPostionK[intCenter, intRi] = new List<string>();
            }
            lstRainPostionK[intCenter, intRi].Add(strRainK);


            if (lstRainPtX[intCenter, intRi] == null)
            {
                lstRainPtX[intCenter, intRi] = new List<int>();
            }
            lstRainPtX[intCenter, intRi].Add(intPx);

            //linkLineToRain(intRainIndex, intLineIndex - 1);

            intRainIndex[intCenter]++;
        }

        private static void addDz(int intCenter, int intRi, string strDZK, string strDZName)
        {
            addLine(intCenter, intDzJG[intCenter, 0], intRi);

            int intPx = intStartPtX[intCenter];

            addLine(intCenter, intDzJG[intCenter, 1], intRi);

            if (lstDZPostionK[intCenter, intRi] == null)
            {
                lstDZPostionK[intCenter, intRi] = new List<string>();
            }
            lstDZPostionK[intCenter, intRi].Add(strDZK);

            if (lstDZPostionName[intCenter, intRi] == null)
            {
                lstDZPostionName[intCenter, intRi] = new List<string>();
            }
            lstDZPostionName[intCenter, intRi].Add(strDZName);

            if (lstDZPostionPtX[intCenter, intRi] == null)
            {
                lstDZPostionPtX[intCenter, intRi] = new List<int>();
            }
            lstDZPostionPtX[intCenter, intRi].Add(intPx);
        }

        private static void addYwPt(int intCenter, int intRi, string strYwK, string strYwName)
        {
            addLine(intCenter, intYwJG[intCenter, 0], intRi);

            int intPx = intStartPtX[intCenter] + 20;

            addLine(intCenter, intYwJG[intCenter, 1], intRi);
            //addLine(intCenter, 100, intRi);

            if (lstYwPostionK[intCenter, intRi] == null)
            {
                lstYwPostionK[intCenter, intRi] = new List<string>();
            }
            lstYwPostionK[intCenter, intRi].Add(strYwK);

            if (lstYwPostionName[intCenter, intRi] == null)
            {
                lstYwPostionName[intCenter, intRi] = new List<string>();
            }
            lstYwPostionName[intCenter, intRi].Add(strYwName);

            if (lstYwPostionPtX[intCenter, intRi] == null)
            {
                lstYwPostionPtX[intCenter, intRi] = new List<int>();
            }
            lstYwPostionPtX[intCenter, intRi].Add(intPx);

            linkLineToYW(intCenter, intYwIndex[intCenter], intLineIndex[intCenter] - 1);

            intYwIndex[intCenter]++;
        }

        private static void linkLineToYW(int intCenter, int intYi, int intLi)
        {
            if (lstYwLinkedLine[intCenter, intYi] == null)
            {
                lstYwLinkedLine[intCenter, intYi] = new List<int>();
            }
            lstYwLinkedLine[intCenter, intYi].Add(intLi);

            if (lstLineLinkedYw[intCenter, intLi] == null)
            {
                lstLineLinkedYw[intCenter, intLi] = new List<int>();
            }
            lstLineLinkedYw[intCenter, intLi].Add(intYi);
        }

        private static void addTrainStation(int intCenter, int intRi, string strTrainStationK, string strTrainStationName)
        {
            addLine(intCenter, 10, intRi);

            intStationPtX[intCenter] = intStartPtX[intCenter] + 65;

            addLine(intCenter, 110, intRi);

            if (lstTrainStationK[intCenter, intRi] == null)
            {
                lstTrainStationK[intCenter, intRi] = new List<string>();
            }

            lstTrainStationK[intCenter, intRi].Add(strTrainStationK);

            if (lstTrainStationName[intCenter, intRi] == null)
            {
                lstTrainStationName[intCenter, intRi] = new List<string>();
            }

            lstTrainStationName[intCenter, intRi].Add(strTrainStationName);

            if (lstTrainStationPtX[intCenter, intRi] == null)
            {
                lstTrainStationPtX[intCenter, intRi] = new List<int>();
            }
            lstTrainStationPtX[intCenter, intRi].Add(intStationPtX[intCenter]);

        }

        private static void addWindPt(int intCenter, int intRi, string strK)
        {
            addLine(intCenter, intWindJG[intCenter, 0], intRi);

            int intPtx = intStartPtX[intCenter];

            //addLine(100, intRi);

            addWindPt(intCenter, strK, intRi, intPtx);

            //if (lstIntWindPt[intCenter,intRi] == null)
            //{
            //    lstIntWindPt[intCenter,intRi] = new List<int>();
            //}

            //int intTemp = 0;
            //int[] intlens = lstIntLineLength[intCenter,intRi].ToArray();
            //for (int i = 0; i < intlens.Length; i++)
            //{
            //    intTemp += intlens[i];
            //}
            //lstIntWindPt[intCenter,intRi].Add(intTemp);

            //intWindIndex++;


            //linkWindAndLine(intLineIndex - 1, intWindIndex - 1);

        }

        public static List<int>[,] lstWindLinkedLine = new List<int>[4, 200];
        public static List<int>[,] lstLineLinkedWind = new List<int>[4, 200];

        public static List<int>[,] lstYwLinkedLine = new List<int>[4, 200];
        public static List<int>[,] lstLineLinkedYw = new List<int>[4, 200];

        public static List<int>[,] lstRainLinkedLine = new List<int>[4, 200];
        public static List<int>[,] lstLineLinkedRain = new List<int>[4, 200];

        private static void linkWindAndLine(int intCenter, int intLi, int intWi)
        {
            if (lstWindLinkedLine[intCenter, intWi] == null)
            {
                lstWindLinkedLine[intCenter, intWi] = new List<int>();
            }
            lstWindLinkedLine[intCenter, intWi].Add(intLi);

            if (lstLineLinkedWind[intCenter, intLi] == null)
            {
                lstLineLinkedWind[intCenter, intLi] = new List<int>();
            }
            lstLineLinkedWind[intCenter, intLi].Add(intWi);

        }

        public static int[] getLinkedLine_wind(int intCenter, int intWi)
        {
            try
            {
                return lstWindLinkedLine[intCenter, intWi].ToArray();
            }
            catch (Exception)
            {
                return null;
            }

        }

        public static int[] getLine_LinkedWind(int intCenter, int intLineIndex)
        {
            if (lstLineLinkedWind[intCenter, intLineIndex] == null)
            {
                return null;
            }

            return lstLineLinkedWind[intCenter, intLineIndex].ToArray();

        }

        public static string getLineRiCi(int intCenter, int intLineIndex)
        {
            string strLine = "";

            int index = 0;
            for (int i = 0; i < lstLineLength.Length; i++)
            {
                for (int j = 0; j < lstLineLength[intCenter, i].Count; j++)
                {
                    if (index == intLineIndex)
                    {
                        strLine = i + "_" + j;
                        return strLine;
                    }
                    index++;
                }
            }

            return strLine;
        }

        public static string getWindRiCi(int intCenter, int intWi)
        {
            string strRiCI = "";

            int index = 0;
            for (int i = 0; i < lstWindPtX.Length; i++)
            {
                for (int j = 0; j < lstWindPtX[intCenter, i].Count; j++)
                {
                    if (index == intWi)
                    {
                        strRiCI = i + "_" + j;
                        return strRiCI;
                    }
                    index++;
                }
            }

            return strRiCI;
        }

        public static int[] getRiCiByIndex(int intIndex, List<int>[] lst)
        {
            int[] ints = new int[2];

            int index = 0;
            for (int i = 0; i < lst.Length; i++)
            {
                for (int j = 0; j < lst[i].Count; j++)
                {
                    if (index == intIndex)
                    {
                        ints[0] = i;
                        ints[1] = j;
                        return ints;
                    }
                    index++;
                }
            }

            return ints;
        }

        public static int[] getRiCiByIndex(int intIndex, List<int>[,] lst, int intCr)
        {
            int[] ints = new int[2];

            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < lst[intCr, i].Count; j++)
                {
                    if (index == intIndex)
                    {
                        ints[0] = i;
                        ints[1] = j;
                        return ints;
                    }
                    index++;
                }
            }

            return ints;
        }

        public static int getIndexByRiCI(int intCr, int intRi, int intCi, List<int>[,] lst)
        {
            int index = 0;
            for (int i = 0; i < intRi; i++)
            {
                if (lst[intCr, i] == null)
                {
                    continue; 
                }

                index += lst[intCr, i].Count;
            }

            index += intCi;

            return index;
        }

        public static int getLineIndex(int intCenter, int intLineRi, int intLineCi)
        {
            int index = 0;
            for (int i = 0; i < intLineRi; i++)
            {
                if (lstLineLength[intCenter, i] == null)
                {
                    return index;
                }

                index += lstLineLength[intCenter, i].Count;
            }

            index += intLineCi;

            return index;
        }

        public static int getWindIndex(int intCenter, int intRi, int intCi)
        {
            int index = 0;
            for (int i = 0; i < intRi; i++)
            {
                if (lstWindPtX[intCenter, i] == null)
                {
                    return index;
                }

                index += lstWindPtX[intCenter, i].Count;
            }

            index += intCi;

            return index;
        }

        private static void addLine(int intCenter, int intLen, int intRi)
        {

            intStartPtX[intCenter] += intLen;

            if (lstLineLength[intCenter, intRi] == null)
            {
                lstLineLength[intCenter, intRi] = new List<int>();
            }

            lstLineLength[intCenter, intRi].Add(intLen);

            if (intWindIndex[intCenter] > 0)
            {
                linkWindAndLine(intCenter, intLineIndex[intCenter], intWindIndex[intCenter] - 1);
            }

            if (intWindIndex[intCenter] < intWindNum[intCenter])
            {
                linkWindAndLine(intCenter, intLineIndex[intCenter], intWindIndex[intCenter]);
            }

            if (intRainIndex[intCenter] > 0)
            {
                linkRainAndLine(intCenter, intLineIndex[intCenter], intRainIndex[intCenter] - 1);
            }

            if (intRainIndex[intCenter] < intRainNum[intCenter])
            {
                linkRainAndLine(intCenter, intLineIndex[intCenter], intRainIndex[intCenter]);
            }

            intLineIndex[intCenter]++;
        }

        private static void linkRainAndLine(int intCenter, int intLi, int intRi)
        {
            if (lstRainLinkedLine[intCenter, intRi] == null)
            {
                lstRainLinkedLine[intCenter, intRi] = new List<int>();
            }
            lstRainLinkedLine[intCenter, intRi].Add(intLi);

            if (lstLineLinkedRain[intCenter, intLi] == null)
            {
                lstLineLinkedRain[intCenter, intLi] = new List<int>();
            }
            lstLineLinkedRain[intCenter, intLi].Add(intRi);
        }

        private static void addWindPt(int intCenter, string strK, int intRi, int intPtX)
        {
            if (lstWindPtK[intCenter, intRi] == null)
            {
                lstWindPtK[intCenter, intRi] = new List<string>();
            }

            lstWindPtK[intCenter, intRi].Add(strK);

            if (lstWindPtX[intCenter, intRi] == null)
            {
                lstWindPtX[intCenter, intRi] = new List<int>();
            }
            lstWindPtX[intCenter, intRi].Add(intPtX);

            intWindAlarmLevel[intCenter, intWindIndex[intCenter]] = 0;

            intWindIndex[intCenter]++;
        }

        private static void initImageList()
        {
            imgWindAlarmLevel = new ImageList();
            //imgWindAlarmLevel.Images.Ad
            ////imgWindAlarmLevel.Images.Add(new Image().
        }

        public static ImageList imgWindAlarmLevel;

        public static bool bNetStatus = false;//终端网络状况

        public static int getRainIndex(int intCenter, int intRi, int intCi)
        {
            int index = 0;
            for (int i = 0; i < intRi; i++)
            {
                if (lstRainPtX[intCenter, i] == null)
                {
                    return index;
                }

                index += lstRainPtX[intCenter, i].Count;
            }

            index += intCi;

            return index;
        }

        internal static string getRainRiCi(int intCenter, int intRaini)
        {
            string strRiCI = "";

            int index = 0;
            for (int i = 0; i < lstRainPtX.Length; i++)
            {
                for (int j = 0; j < lstRainPtX[intCenter, i].Count; j++)
                {
                    if (index == intRaini)
                    {
                        strRiCI = i + "_" + j;
                        return strRiCI;
                    }
                    index++;
                }
            }

            return strRiCI;
        }

        public static int getYwIndex(int intStationIndex, int intStationYwIndex)
        {
            int index = 0;
            for (int i = 0; i < intStationNum_Rain; i++)
            {
                if (i < intStationIndex)
                {
                    index += intYwStationYwNum[i];
                    continue;
                }
                else if (i < intStationIndex)
                {
                    index += intStationYwIndex;
                    break;
                }
            }
            return index;
        }

        public static DataTable TranslateAlarm(DataSet ds, string strTableName)
        {

            DataTable dt = initAlarmTable(strTableName);

            DataTable dtSource = ds.Tables[strTableName];

            for (int i = 0; i < dtSource.Rows.Count; i++)
            {
                DataRow row = dt.NewRow();
                row["ID"] = dtSource.Rows[i]["ID"].ToString();
                row["基站里程"] = dtSource.Rows[i]["STATIONID"].ToString();
                int intType = int.Parse(dtSource.Rows[i]["CARD_TYPE"].ToString());
                string[] strInfo = getRowValue(intType, dtSource.Rows[i]);
                if (strInfo == null)
                {
                    continue;
                }
                row["设备类型"] = strInfo[0];
                row["信息类型"] = strInfo[1];
                row["报警开始时间"] = dtSource.Rows[i]["ALARM_TIME"].ToString();
                row["报警结束时间"] = dtSource.Rows[i]["END_TIME"].ToString();
                row["基站类型"] = AppUtil.appType[intType];
                dt.Rows.Add(row);
            }

            dt.AcceptChanges();
            return dt;

        }

        public static DataTable TranslateAlarm(DataSet ds, string strTableName, int[] intFilter)
        {

            DataTable dt = initAlarmTable(strTableName);

            DataTable dtSource = ds.Tables[strTableName];

            for (int i = 0; i < dtSource.Rows.Count; i++)
            {
                DataRow row = dt.NewRow();
                row["ID"] = dtSource.Rows[i]["ID"].ToString();
                row["基站里程"] = dtSource.Rows[i]["STATIONID"].ToString();
                int intType = int.Parse(dtSource.Rows[i]["CARD_TYPE"].ToString());
                if (intFilter[intType] == 0)
                {
                    continue;
                }
                string[] strInfo = getRowValue(intType, dtSource.Rows[i]);
                if (strInfo == null)
                {
                    continue;
                }
                row["设备类型"] = strInfo[0];
                row["信息类型"] = strInfo[1];
                row["报警开始时间"] = dtSource.Rows[i]["ALARM_TIME"].ToString();
                row["报警结束时间"] = dtSource.Rows[i]["END_TIME"].ToString();
                row["基站类型"] = AppUtil.appType[intType];
                dt.Rows.Add(row);
            }

            dt.AcceptChanges();
            return dt;

        }

        private static string[] getRowValue(int thread_index, DataRow row)
        {
            string[] rowStr = null;

            //过滤主控板主备状态
            if (row["byte_ID"].ToString() == "0" && row["bit_ID"].ToString() == "0" || row["byte_ID"].ToString() == "1" && row["bit_ID"].ToString() == "0")
            {
                return rowStr;
            }

            if (thread_index == 0)
            {
                rowStr = ConvertToChina.getWindStationOnOffState("" + row["byte_ID"], "" + row["bit_ID"], "0").Split(',');
            }
            else if (thread_index == 1)
            {
                rowStr = ConvertToChina.getDropStationOnOffState("" + row["byte_ID"], "" + row["bit_ID"], "0").Split(',');
            }
            else if (thread_index == 2)
            {
                rowStr = ConvertToChina.getWindStationOnOffState("" + row["byte_ID"], "" + row["bit_ID"], "0").Split(',');
            }
            else
            {
                if (row["byte_ID"].ToString() == "2" && row["bit_ID"].ToString() == "0" || row["byte_ID"].ToString() == "4" && row["bit_ID"].ToString() == "0")//过滤地震主备状态
                {
                    return rowStr;
                }

                rowStr = ConvertToChina.getEarthQuakeStationOnOffState("" + row["byte_ID"], "" + row["bit_ID"], "0").Split(',');
            }

            return rowStr;
        }

        public static DataTable initAlarmTable(string strTableName)
        {
            DataTable dt = new DataTable(strTableName);

            dt.Columns.Add("ID");
            dt.Columns.Add("基站里程");
            dt.Columns.Add("设备类型");
            dt.Columns.Add("信息类型");
            dt.Columns.Add("报警开始时间");
            dt.Columns.Add("报警结束时间");
            dt.Columns.Add("基站类型");
            return dt;
        }

        public static DataTable initWindLishiTable(string strTableName)
        {
            DataTable dt = new DataTable(strTableName);
            dt.Columns.Add("时间");
            dt.Columns.Add("风速");
            return dt;
        }

        public static DataTable initRainLishiTable(string strTableName)
        {
            DataTable dt = new DataTable(strTableName);
            dt.Columns.Add("时间");
            dt.Columns.Add("小时雨量");
            dt.Columns.Add("24小时雨量");
            dt.Columns.Add("连续雨量");
            return dt;
        }

    }

    class ConvertToChina
    {
        #region 公共翻译

        public static string getPanelState(string byteNum, string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(byteNum))
            {
                result.Append("主控板1," + utilPanel0To1(bitNum, stateNum));
            }
            else if ("1".Equals(byteNum))
            {
                result.Append("主控板2," + utilPanel0To1(bitNum, stateNum));
            }
            else if ("14".Equals(byteNum))
            {
                result.Append("专用电源1," + utilPanel14To15(bitNum, stateNum));
            }
            else if ("15".Equals(byteNum))
            {
                result.Append("专用电源2," + utilPanel14To15(bitNum, stateNum));
            }
            else
            {
                result.Append("  ,  ,  ");
            }

            return result.ToString();
        }

        public static string utilPanel0To1(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(bitNum))
            {
                result.Append("主/备状态," + isPrimary(stateNum));
            }
            else if ("1".Equals(bitNum))
            {
                result.Append("网络通讯状态," + isException(stateNum));
            }
            else if ("5".Equals(bitNum))
            {
                result.Append("备板状态," + isBreadDown(stateNum));
            }
            else if ("6".Equals(bitNum))
            {
                result.Append("电源1状态," + isBreadDown(stateNum));
            }
            else if ("7".Equals(bitNum))
            {
                result.Append("电源2状态," + isBreadDown(stateNum));
            }
            else
            {
                result.Append("  ,  ");
            }

            return result.ToString();
        }

        public static string utilPanel14To15(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(bitNum))
            {
                result.Append("设备状态," + isWarning(stateNum));
            }
            else if ("1".Equals(bitNum))
            {
                result.Append("设备通讯状态," + isException(stateNum));
            }
            else if ("2".Equals(bitNum))
            {
                result.Append("外电输入状态," + isInput(stateNum));
            }
            else if ("3".Equals(bitNum))
            {
                result.Append("电池状态," + isBattery(stateNum));
            }
            else if ("4".Equals(bitNum))
            {
                result.Append("检测状态," + isBreadDown(stateNum));
            }
            else if ("5".Equals(bitNum))
            {
                result.Append("通讯状态," + isException(stateNum));
            }
            else
            {
                result.Append("  ,  ");
            }

            return result.ToString();
        }

        #endregion

        #region 风/雨翻译

        public static string getWindStationOnOffState(string byteNum, string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(byteNum) || "1".Equals(byteNum) || "14".Equals(byteNum) || "15".Equals(byteNum))
            {
                return getPanelState(byteNum, bitNum, stateNum);
            }

            if ("2".Equals(byteNum))
            {
                result.Append("气象板1A," + utilWindStationOnOff2To9(bitNum, stateNum));
            }
            else if ("3".Equals(byteNum))
            {
                result.Append("气象板1B," + utilWindStationOnOff2To9(bitNum, stateNum));
            }
            else if ("4".Equals(byteNum))
            {
                result.Append("气象板2A," + utilWindStationOnOff2To9(bitNum, stateNum));
            }
            else if ("5".Equals(byteNum))
            {
                result.Append("气象板2B," + utilWindStationOnOff2To9(bitNum, stateNum));
            }
            else if ("6".Equals(byteNum))
            {
                result.Append("气象板3A," + utilWindStationOnOff2To9(bitNum, stateNum));
            }
            else if ("7".Equals(byteNum))
            {
                result.Append("气象板3B," + utilWindStationOnOff2To9(bitNum, stateNum));
            }
            else if ("8".Equals(byteNum))
            {
                result.Append("气象板4A," + utilWindStationOnOff2To9(bitNum, stateNum));
            }
            else if ("9".Equals(byteNum))
            {
                result.Append("气象板4B," + utilWindStationOnOff2To9(bitNum, stateNum));
            }
            else if ("10".Equals(byteNum))
            {
                result.Append("气象传感器状态," + utilWindStationOnOff10(bitNum, stateNum));
            }
            else
            {
                result.Append("  ,  , ");
            }

            return result.ToString();
        }

        public static string utilWindStationOnOff2To9(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("1".Equals(bitNum))
            {
                result.Append("设备通讯状态," + isException(stateNum));
            }
            else if ("2".Equals(bitNum))
            {
                result.Append("传输通讯状态," + isException(stateNum));
            }
            else if ("3".Equals(bitNum))
            {
                result.Append("传输数据状态," + isEfficacious(stateNum));
            }
            else if ("4".Equals(bitNum))
            {
                result.Append("数据状态," + isEfficacious(stateNum));
            }
            else if ("5".Equals(bitNum))
            {
                result.Append("传感器通讯状态," + isException(stateNum));
            }
            else if ("6".Equals(bitNum))
            {
                result.Append("电源1状态," + isBreadDown(stateNum));
            }
            else
            {
                result.Append("  ,  ");
            }

            return result.ToString();
        }

        public static string utilWindStationOnOff10(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(bitNum))
            {
                result.Append("数据1组状态," + isEfficacious(stateNum));
            }
            else if ("1".Equals(bitNum))
            {
                result.Append("数据2组状态," + isEfficacious(stateNum));
            }
            else if ("2".Equals(bitNum))
            {
                result.Append("数据3组状态," + isEfficacious(stateNum));
            }
            else if ("3".Equals(bitNum))
            {
                result.Append("数据4组状态," + isEfficacious(stateNum));
            }
            else
            {
                result.Append("  ,  ");
            }

            return result.ToString();
        }

        #endregion

        #region 异物翻译

        public static string getDropStationOnOffState(string byteNum, string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(byteNum) || "1".Equals(byteNum) || "14".Equals(byteNum) || "15".Equals(byteNum))
            {
                return getPanelState(byteNum, bitNum, stateNum);
            }

            if ("2".Equals(byteNum))
            {
                result.Append("异物1电网板" + utilDropStationOnOff2To5(bitNum, stateNum));
            }
            else if ("3".Equals(byteNum))
            {
                result.Append("异物2电网板" + utilDropStationOnOff2To5(bitNum, stateNum));
            }
            else if ("4".Equals(byteNum))
            {
                result.Append("异物3电网板" + utilDropStationOnOff2To5(bitNum, stateNum));
            }
            else if ("5".Equals(byteNum))
            {
                result.Append("异物4电网板" + utilDropStationOnOff2To5(bitNum, stateNum));
            }
            else if ("6".Equals(byteNum))
            {
                result.Append("异物调度板," + utilDropStationOnOff6(bitNum, stateNum));
            }
            else if ("7".Equals(byteNum))
            {
                result.Append("异物电源," + utilDropStationOnOff7(bitNum, stateNum));
            }
            else if ("8".Equals(byteNum))
            {
                result.Append("异物1电网," + utilDropStationOnOff8To11(bitNum, stateNum));
            }
            else if ("9".Equals(byteNum))
            {
                result.Append("异物2电网," + utilDropStationOnOff8To11(bitNum, stateNum));
            }
            else if ("10".Equals(byteNum))
            {
                result.Append("异物3电网," + utilDropStationOnOff8To11(bitNum, stateNum));
            }
            else if ("11".Equals(byteNum))
            {
                result.Append("异物4电网," + utilDropStationOnOff8To11(bitNum, stateNum));
            }
            else if ("12".Equals(byteNum))
            {
                result.Append("异物列控," + utilDropStationOnOff12(bitNum, stateNum));
            }
            else if ("13".Equals(byteNum))
            {
                result.Append("异物临时通车," + utilDropStationOnOff13(bitNum, stateNum));
            }
            else
            {
                result.Append("  ,  ,  ");
            }

            return result.ToString();
        }

        public static string utilDropStationOnOff2To5(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("1".Equals(bitNum))
            {
                result.Append("A,设备通讯状态," + isException(stateNum));
            }
            else if ("2".Equals(bitNum))
            {
                result.Append("A,电网检测状态," + isBreadDown(stateNum));
            }
            else if ("3".Equals(bitNum))
            {
                result.Append("A,输出接口状态," + isBreadDown(stateNum));
            }
            else if ("5".Equals(bitNum))
            {
                result.Append("B,设备通讯状态," + isException(stateNum));
            }
            else if ("6".Equals(bitNum))
            {
                result.Append("B,电网检测状态," + isBreadDown(stateNum));
            }
            else if ("7".Equals(bitNum))
            {
                result.Append("B,输出接口状态," + isBreadDown(stateNum));
            }
            else
            {
                result.Append("  ,  ");
            }

            return result.ToString();
        }

        public static string utilDropStationOnOff6(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("1".Equals(bitNum))
            {
                result.Append("A,设备通讯状态," + isException(stateNum));
            }
            else if ("3".Equals(bitNum))
            {
                result.Append("A,输出接口状态," + isBreadDown(stateNum));
            }
            else if ("5".Equals(bitNum))
            {
                result.Append("B,设备通讯状态," + isException(stateNum));
            }
            else if ("7".Equals(bitNum))
            {
                result.Append("B,输出接口状态," + isBreadDown(stateNum));
            }
            else
            {
                result.Append("  ,  ");
            }

            return result.ToString();
        }

        public static string utilDropStationOnOff7(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("4".Equals(bitNum))
            {
                result.Append("异物电源1状态," + isBreadDown(stateNum));
            }
            else if ("5".Equals(bitNum))
            {
                result.Append("异物电源2状态," + isBreadDown(stateNum));
            }
            else if ("6".Equals(bitNum))
            {
                result.Append("异物电源3状态," + isBreadDown(stateNum));
            }
            else if ("7".Equals(bitNum))
            {
                result.Append("异物电源4状态," + isBreadDown(stateNum));
            }
            else
            {
                result.Append("  ,  ");
            }

            return result.ToString();
        }

        public static string utilDropStationOnOff8To11(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(bitNum))
            {
                result.Append("电网1状态," + isCut(stateNum));
            }
            else if ("1".Equals(bitNum))
            {
                result.Append("电网2状态," + isCut(stateNum));
            }
            else if ("3".Equals(bitNum))
            {
                result.Append("电网混电状态," + isChaos(stateNum));
            }
            else if ("4".Equals(bitNum))
            {
                result.Append("实验状态," + isExperiment(stateNum));
            }
            else if ("5".Equals(bitNum))
            {
                result.Append("调度恢复状态," + isRestore(stateNum));
            }
            else if ("6".Equals(bitNum))
            {
                result.Append("现场恢复状态," + isRestore(stateNum));
            }
            else if ("7".Equals(bitNum))
            {
                result.Append("行车状态," + isStop(stateNum));
            }
            else
            {
                result.Append("  ,  ");
            }

            return result.ToString();
        }

        public static string utilDropStationOnOff12(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(bitNum))
            {
                result.Append("列控1上行状态," + isDrop(stateNum));
            }
            else if ("1".Equals(bitNum))
            {
                result.Append("列控1下行状态," + isDrop(stateNum));
            }
            else if ("2".Equals(bitNum))
            {
                result.Append("列控2上行状态," + isDrop(stateNum));
            }
            else if ("3".Equals(bitNum))
            {
                result.Append("列控2下行状态," + isDrop(stateNum));
            }
            else if ("4".Equals(bitNum))
            {
                result.Append("电网1行车状态," + isStop(stateNum));
            }
            else if ("5".Equals(bitNum))
            {
                result.Append("电网2行车状态," + isStop(stateNum));
            }
            else if ("6".Equals(bitNum))
            {
                result.Append("列控1状态," + isEfficacious(stateNum));
            }
            else if ("7".Equals(bitNum))
            {
                result.Append("列控2状态," + isEfficacious(stateNum));
            }

            return result.ToString();
        }

        public static string utilDropStationOnOff13(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(bitNum))
            {
                result.Append("控1上行临时通车," + isTemporary(stateNum));
            }
            else if ("1".Equals(bitNum))
            {
                result.Append("控1下行临时通车," + isTemporary(stateNum));
            }
            else if ("2".Equals(bitNum))
            {
                result.Append("控2上行临时通车," + isTemporary(stateNum));
            }
            else if ("3".Equals(bitNum))
            {
                result.Append("控2下行临时通车," + isTemporary(stateNum));
            }

            return result.ToString();
        }

        public static string getDropAlarmState1(string byteNum, string bitNum, string stateNum, int inputType)
        {
            StringBuilder result = new StringBuilder();

            if ("8".Equals(byteNum))
            {
                result.Append("异物1电网," + utilDropStationOnOff8To11(bitNum, stateNum));
            }

            if (inputType == 1)
            {
                if ("12".Equals(byteNum))
                {
                    result.Append("异物列控," + utilDropStationOnOff12For1(bitNum, stateNum));
                }
                else if ("13".Equals(byteNum))
                {
                    result.Append("异物临时通车," + utilDropStationOnOff13For1(bitNum, stateNum));
                }
            }
            else if (inputType == 2)
            {
                if ("12".Equals(byteNum))
                {
                    result.Append("异物列控," + utilDropStationOnOff12For2(bitNum, stateNum));
                }
                else if ("13".Equals(byteNum))
                {
                    result.Append("异物临时通车," + utilDropStationOnOff13For2(bitNum, stateNum));
                }
            }
            else
            {
                return null;
            }

            return result.ToString();
        }

        public static string getDropAlarmState2(string byteNum, string bitNum, string stateNum, int inputType)
        {
            StringBuilder result = new StringBuilder();

            if ("9".Equals(byteNum))
            {
                result.Append("异物2电网," + utilDropStationOnOff8To11(bitNum, stateNum));
            }

            if (inputType == 1)
            {
                if ("12".Equals(byteNum))
                {
                    result.Append("异物列控," + utilDropStationOnOff12For1(bitNum, stateNum));
                }
                else if ("13".Equals(byteNum))
                {
                    result.Append("异物临时通车," + utilDropStationOnOff13For1(bitNum, stateNum));
                }
            }
            else if (inputType == 2)
            {
                if ("12".Equals(byteNum))
                {
                    result.Append("异物列控," + utilDropStationOnOff12For2(bitNum, stateNum));
                }
                else if ("13".Equals(byteNum))
                {
                    result.Append("异物临时通车," + utilDropStationOnOff13For2(bitNum, stateNum));
                }
            }
            else
            {
                return null;
            }

            return result.ToString();
        }

        public static string getDropAlarmState3(string byteNum, string bitNum, string stateNum, int inputType)
        {
            StringBuilder result = new StringBuilder();

            if ("10".Equals(byteNum))
            {
                result.Append("异物3电网," + utilDropStationOnOff8To11(bitNum, stateNum));
            }

            if (inputType == 1)
            {
                if ("12".Equals(byteNum))
                {
                    result.Append("异物列控," + utilDropStationOnOff12For1(bitNum, stateNum));
                }
                else if ("13".Equals(byteNum))
                {
                    result.Append("异物临时通车," + utilDropStationOnOff13For1(bitNum, stateNum));
                }
            }
            else if (inputType == 2)
            {
                if ("12".Equals(byteNum))
                {
                    result.Append("异物列控," + utilDropStationOnOff12For2(bitNum, stateNum));
                }
                else if ("13".Equals(byteNum))
                {
                    result.Append("异物临时通车," + utilDropStationOnOff13For2(bitNum, stateNum));
                }
            }
            else
            {
                return null;
            }

            return result.ToString();
        }

        public static string getDropAlarmState4(string byteNum, string bitNum, string stateNum, int inputType)
        {
            StringBuilder result = new StringBuilder();

            if ("11".Equals(byteNum))
            {
                result.Append("异物4电网," + utilDropStationOnOff8To11(bitNum, stateNum));
            }

            if (inputType == 1)
            {
                if ("12".Equals(byteNum))
                {
                    result.Append("异物列控," + utilDropStationOnOff12For1(bitNum, stateNum));
                }
                else if ("13".Equals(byteNum))
                {
                    result.Append("异物临时通车," + utilDropStationOnOff13For1(bitNum, stateNum));
                }
            }
            else if (inputType == 2)
            {
                if ("12".Equals(byteNum))
                {
                    result.Append("异物列控," + utilDropStationOnOff12For2(bitNum, stateNum));
                }
                else if ("13".Equals(byteNum))
                {
                    result.Append("异物临时通车," + utilDropStationOnOff13For2(bitNum, stateNum));
                }
            }
            else
            {
                return null;
            }

            return result.ToString();
        }

        public static string getDropAlarmState(string byteNum, string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("8".Equals(byteNum))
            {
                result.Append("异物1电网," + utilDropStationOnOff8To11(bitNum, stateNum));
            }
            else if ("9".Equals(byteNum))
            {
                result.Append("异物2电网," + utilDropStationOnOff8To11(bitNum, stateNum));
            }
            else if ("10".Equals(byteNum))
            {
                result.Append("异物3电网," + utilDropStationOnOff8To11(bitNum, stateNum));
            }
            else if ("11".Equals(byteNum))
            {
                result.Append("异物4电网," + utilDropStationOnOff8To11(bitNum, stateNum));
            }
            else if ("12".Equals(byteNum))
            {
                result.Append("异物列控," + utilDropStationOnOff12(bitNum, stateNum));
            }
            else if ("13".Equals(byteNum))
            {
                result.Append("异物临时通车," + utilDropStationOnOff13(bitNum, stateNum));
            }
            else
            {
                return null;
            }

            return result.ToString();
        }

        public static string utilDropStationOnOff12For1(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(bitNum))
            {
                result.Append("列控1上行状态," + isDrop(stateNum));
            }
            else if ("1".Equals(bitNum))
            {
                result.Append("列控1下行状态," + isDrop(stateNum));
            }
            else if ("4".Equals(bitNum))
            {
                result.Append("电网1行车状态," + isStop(stateNum));
            }
            else if ("6".Equals(bitNum))
            {
                result.Append("列控1状态," + isEfficacious(stateNum));
            }

            return result.ToString();
        }

        public static string utilDropStationOnOff12For2(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("2".Equals(bitNum))
            {
                result.Append("列控2上行状态," + isDrop(stateNum));
            }
            else if ("3".Equals(bitNum))
            {
                result.Append("列控2下行状态," + isDrop(stateNum));
            }
            else if ("5".Equals(bitNum))
            {
                result.Append("电网2行车状态," + isStop(stateNum));
            }
            else if ("7".Equals(bitNum))
            {
                result.Append("列控2状态," + isEfficacious(stateNum));
            }

            return result.ToString();
        }

        public static string utilDropStationOnOff13For1(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(bitNum))
            {
                result.Append("控1上行临时通车," + isTemporary(stateNum));
            }
            else if ("1".Equals(bitNum))
            {
                result.Append("控1下行临时通车," + isTemporary(stateNum));
            }

            return result.ToString();
        }

        public static string utilDropStationOnOff13For2(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("2".Equals(bitNum))
            {
                result.Append("控2上行临时通车," + isTemporary(stateNum));
            }
            else if ("3".Equals(bitNum))
            {
                result.Append("控2下行临时通车," + isTemporary(stateNum));
            }

            return result.ToString();
        }

        public static string getDropOutputState1(string byteNum, string bitNum, string stateNum, int inputType)
        {
            StringBuilder result = new StringBuilder();
            result.Append("异物调度输出,");

            if ("0".Equals(byteNum) && "0".Equals(bitNum))
            {
                result.Append("列控1上行临时," + isTemporary(stateNum));
            }
            else if ("0".Equals(byteNum) && "1".Equals(bitNum))
            {
                result.Append("列控1下行临时," + isTemporary(stateNum));
            }
            else if (inputType == 1)
            {
                result.Append(utilDropStationOnOffOutput1(byteNum, bitNum, stateNum));
            }
            else if (inputType == 2)
            {
                result.Append(utilDropStationOnOffOutput2(byteNum, bitNum, stateNum));
            }
            else if (inputType == 3)
            {
                result.Append(utilDropStationOnOffOutput3(byteNum, bitNum, stateNum));
            }
            else if (inputType == 4)
            {
                result.Append(utilDropStationOnOffOutput4(byteNum, bitNum, stateNum));
            }
            else
            {
                return null;
            }

            return result.ToString();
        }

        public static string getDropOutputState2(string byteNum, string bitNum, string stateNum, int inputType)
        {
            StringBuilder result = new StringBuilder();
            result.Append("异物调度输出,");

            if ("0".Equals(byteNum) && "2".Equals(bitNum))
            {
                result.Append("列控2上行临时," + isTemporary(stateNum));
            }
            else if ("0".Equals(byteNum) && "3".Equals(bitNum))
            {
                result.Append("列控2下行临时," + isTemporary(stateNum));
            }
            else if (inputType == 1)
            {
                result.Append(utilDropStationOnOffOutput1(byteNum, bitNum, stateNum));
            }
            else if (inputType == 2)
            {
                result.Append(utilDropStationOnOffOutput2(byteNum, bitNum, stateNum));
            }
            else if (inputType == 3)
            {
                result.Append(utilDropStationOnOffOutput3(byteNum, bitNum, stateNum));
            }
            else if (inputType == 4)
            {
                result.Append(utilDropStationOnOffOutput4(byteNum, bitNum, stateNum));
            }
            else
            {
                return null;
            }

            return result.ToString();
        }

        public static string getDropOutputState(string byteNum, string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();
            result.Append("异物调度输出,");

            if ("0".Equals(byteNum))
            {
                result.Append(utilDropStationOnOffOutputByte1(bitNum, stateNum));
            }
            else if ("1".Equals(byteNum))
            {
                result.Append(utilDropStationOnOffOutputByte2(bitNum, stateNum));
            }
            else
            {
                return null;
            }

            return result.ToString();
        }

        public static string utilDropStationOnOffOutputByte1(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(bitNum))
            {
                result.Append("列控1上行临时," + isTemporary(stateNum));
            }
            else if ("1".Equals(bitNum))
            {
                result.Append("列控1下行临时," + isTemporary(stateNum));
            }
            if ("2".Equals(bitNum))
            {
                result.Append("列控2上行临时," + isTemporary(stateNum));
            }
            else if ("3".Equals(bitNum))
            {
                result.Append("列控2下行临时," + isTemporary(stateNum));
            }
            if ("4".Equals(bitNum))
            {
                result.Append("电网1实验输出," + isExperiment(stateNum));
            }
            else if ("5".Equals(bitNum))
            {
                result.Append("电网1调度恢复," + isRestore(stateNum));
            }
            else if ("6".Equals(bitNum))
            {
                result.Append("电网1远程恢复," + isRestore(stateNum));
            }
            else if ("7".Equals(bitNum))
            {
                result.Append("电网2实验输出," + isExperiment(stateNum));
            }
            else
            {
                result.Append("  ");
            }

            return result.ToString();
        }

        public static string utilDropStationOnOffOutputByte2(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(bitNum))
            {
                result.Append("电网2调度恢复," + isRestore(stateNum));
            }
            else if ("1".Equals(bitNum))
            {
                result.Append("电网2远程恢复," + isRestore(stateNum));
            }
            else if ("2".Equals(bitNum))
            {
                result.Append("电网3实验输出," + isExperiment(stateNum));
            }
            else if ("3".Equals(bitNum))
            {
                result.Append("电网3调度恢复," + isRestore(stateNum));
            }
            else if ("4".Equals(bitNum))
            {
                result.Append("电网3远程恢复," + isRestore(stateNum));
            }
            else if ("5".Equals(bitNum))
            {
                result.Append("电网4实验输出," + isExperiment(stateNum));
            }
            else if ("6".Equals(bitNum))
            {
                result.Append("电网4调度恢复," + isRestore(stateNum));
            }
            else if ("7".Equals(bitNum))
            {
                result.Append("电网4远程恢复," + isRestore(stateNum));
            }
            else
            {
                result.Append("  ");
            }

            return result.ToString();
        }

        public static string utilDropStationOnOffOutput1(string byteNum, string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(byteNum) && "4".Equals(bitNum))
            {
                result.Append("电网1实验输出," + isExperiment(stateNum));
            }
            else if ("0".Equals(byteNum) && "5".Equals(bitNum))
            {
                result.Append("电网1调度恢复," + isRestore(stateNum));
            }
            else if ("0".Equals(byteNum) && "6".Equals(bitNum))
            {
                result.Append("电网1远程恢复," + isRestore(stateNum));
            }
            else
            {
                result.Append("  ");
            }

            return result.ToString();
        }

        public static string utilDropStationOnOffOutput2(string byteNum, string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(byteNum) && "7".Equals(bitNum))
            {
                result.Append("电网2实验输出," + isExperiment(stateNum));
            }
            else if ("1".Equals(byteNum) && "0".Equals(bitNum))
            {
                result.Append("电网2调度恢复," + isRestore(stateNum));
            }
            else if ("1".Equals(byteNum) && "1".Equals(bitNum))
            {
                result.Append("电网2远程恢复," + isRestore(stateNum));
            }
            else
            {
                result.Append(" ");
            }

            return result.ToString();
        }

        public static string utilDropStationOnOffOutput3(string byteNum, string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("1".Equals(byteNum) && "2".Equals(bitNum))
            {
                result.Append("电网3实验输出," + isExperiment(stateNum));
            }
            else if ("1".Equals(byteNum) && "3".Equals(bitNum))
            {
                result.Append("电网3调度恢复," + isRestore(stateNum));
            }
            else if ("1".Equals(byteNum) && "4".Equals(bitNum))
            {
                result.Append("电网3远程恢复," + isRestore(stateNum));
            }
            else
            {
                result.Append(" ");
            }

            return result.ToString();
        }

        public static string utilDropStationOnOffOutput4(string byteNum, string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("1".Equals(byteNum) && "5".Equals(bitNum))
            {
                result.Append("电网4实验输出," + isExperiment(stateNum));
            }
            else if ("1".Equals(byteNum) && "6".Equals(bitNum))
            {
                result.Append("电网4调度恢复," + isRestore(stateNum));
            }
            else if ("1".Equals(byteNum) && "7".Equals(bitNum))
            {
                result.Append("电网4远程恢复," + isRestore(stateNum));
            }
            else
            {
                result.Append(" ");
            }

            return result.ToString();
        }

        //public static string utilDropStationOnOffOutput(string bitNum, string stateNum)
        //{
        //    StringBuilder result = new StringBuilder();

        //    if ("0".Equals(bitNum))
        //    {
        //        result.Append("现场恢复状态," + isRestore(stateNum));
        //    }
        //    else if ("1".Equals(bitNum))
        //    {
        //        result.Append("调度恢复状态," + isRestore(stateNum));
        //    }
        //    else if ("2".Equals(bitNum))
        //    {
        //        result.Append("上行临时通车状态," + isTemporary(stateNum));
        //    }
        //    else if ("3".Equals(bitNum))
        //    {
        //        result.Append("下行临时通车状态," + isTemporary(stateNum));
        //    }
        //    else if ("4".Equals(bitNum))
        //    {
        //        result.Append("试验输出," + isOutput(stateNum));
        //    }
        //    else
        //    {
        //        result.Append("  ,  ");
        //    }

        //    return result.ToString();
        //}

        #endregion

        #region 地震翻译

        public static string getEarthQuakeStationOnOffState(string byteNum, string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(byteNum) || "1".Equals(byteNum) || "14".Equals(byteNum) || "15".Equals(byteNum))
            {
                return getPanelState(byteNum, bitNum, stateNum);
            }

            if ("2".Equals(byteNum))
            {
                result.Append("地震A板," + utilEarthQuakeStationOnOff2_5_1(bitNum, stateNum));
            }
            else if ("3".Equals(byteNum))
            {
                result.Append("地震A板," + utilEarthQuakeStationOnOff2_5_2(bitNum, stateNum));
            }
            else if ("4".Equals(byteNum))
            {
                result.Append("地震B板," + utilEarthQuakeStationOnOff2_5_1(bitNum, stateNum));
            }
            else if ("5".Equals(byteNum))
            {
                result.Append("地震B板," + utilEarthQuakeStationOnOff2_5_2(bitNum, stateNum));
            }
            else if ("6".Equals(byteNum))
            {
                result.Append("主控板1," + utilEarthQuakeStationOnOff6_7(bitNum, stateNum));
            }
            else if ("7".Equals(byteNum))
            {
                result.Append("主控板2," + utilEarthQuakeStationOnOff6_7(bitNum, stateNum));
            }
            else if ("9".Equals(byteNum))
            {
                result.Append("地震电源," + utilEarthQuakeStationOnOff9(bitNum, stateNum));
            }
            else if ("12".Equals(byteNum))
            {
                result.Append("地震控制," + utilEarthQuakeStationOnOff12(bitNum, stateNum));
            }
            else if ("13".Equals(byteNum))
            {
                result.Append("地震控制," + utilEarthQuakeStationOnOff13(bitNum, stateNum));
            }
            else
            {
                result.Append("  ,  ,  ");
            }

            return result.ToString();
        }

        public static string utilEarthQuakeStationOnOff2_5_1(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(bitNum))
            {
                result.Append("主/备状态," + isPrimary(stateNum));
            }
            else if ("1".Equals(bitNum))
            {
                result.Append("设备通讯状态," + isException(stateNum));
            }
            else if ("3".Equals(bitNum))
            {
                result.Append("输出接口状态," + isBreadDown(stateNum));
            }
            else
            {
                result.Append("  ,  ");
            }

            return result.ToString();
        }

        public static string utilEarthQuakeStationOnOff2_5_2(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("3".Equals(bitNum))
            {
                result.Append("报警状态," + isAlarm(stateNum));
            }
            else if ("4".Equals(bitNum))
            {
                result.Append("传感器状态," + isBreadDown2(stateNum));
            }
            else
            {
                result.Append("  ,  ");
            }

            return result.ToString();
        }

        public static string utilEarthQuakeStationOnOff6_7(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(bitNum))
            {
                result.Append("COM1," + isCom1(stateNum));
            }
            else if ("4".Equals(bitNum))
            {
                result.Append("COM1," + isCom2(stateNum));
            }
            else
            {
                result.Append("  ,  ");
            }

            return result.ToString();
        }

        public static string utilEarthQuakeStationOnOff9(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("2".Equals(bitNum))
            {
                result.Append("电源1状态," + isBreadDown(stateNum));
            }
            else if ("3".Equals(bitNum))
            {
                result.Append("电源2状态," + isBreadDown(stateNum));
            }
            else if ("4".Equals(bitNum))
            {
                result.Append("电源3状态," + isBreadDown(stateNum));
            }
            else if ("5".Equals(bitNum))
            {
                result.Append("电源4状态," + isBreadDown(stateNum));
            }
            else if ("6".Equals(bitNum))
            {
                result.Append("电源5状态," + isBreadDown(stateNum));
            }
            else if ("7".Equals(bitNum))
            {
                result.Append("电源6状态," + isBreadDown(stateNum));
            }
            else
            {
                result.Append("  ,  ");
            }

            return result.ToString();
        }

        public static string utilEarthQuakeStationOnOff12(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(bitNum))
            {
                result.Append("停车回采状态," + isStop3(stateNum));
            }
            else if ("1".Equals(bitNum))
            {
                result.Append("停电回采状态," + isStop2(stateNum));
            }
            else
            {
                result.Append("  ,  ");
            }

            return result.ToString();
        }

        public static string utilEarthQuakeStationOnOff13(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("6".Equals(bitNum))
            {
                result.Append("控车状态," + isEfficacious(stateNum));
            }
            else if ("7".Equals(bitNum))
            {
                result.Append("控电状态," + isEfficacious(stateNum));
            }
            else
            {
                result.Append("  ,  ");
            }

            return result.ToString();
        }

        public static string getEarthQuakeAlarmState(string byteNum, string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("12".Equals(byteNum))
            {
                result.Append("地震控制," + utilEarthQuakeStationOnOff12(bitNum, stateNum));
            }
            else if ("3".Equals(byteNum))
            {
                result.Append("地震A板," + utilEarthQuakeStationOnOffAlarm(bitNum, stateNum));
            }
            else if ("5".Equals(byteNum))
            {
                result.Append("地震B板," + utilEarthQuakeStationOnOffAlarm(bitNum, stateNum));
            }
            else
            {
                return null;
            }

            return result.ToString();
        }

        public static string utilEarthQuakeStationOnOffAlarm(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("3".Equals(bitNum))
            {
                result.Append("报警状态," + isAlarm(stateNum));
            }
            else
            {
                result.Append("  ,  ");
            }

            return result.ToString();
        }

        public static string getEarthQuakeOutputState(string byteNum, string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(byteNum))
            {
                result.Append("地震调度输出," + utilEarthQuakeStationOnOffOutput(bitNum, stateNum));
            }
            else
            {
                return null;
            }

            return result.ToString();
        }

        public static string utilEarthQuakeStationOnOffOutput(string bitNum, string stateNum)
        {
            StringBuilder result = new StringBuilder();

            if ("0".Equals(bitNum))
            {
                result.Append("控车状态," + isTestStop(stateNum));
            }
            else if ("1".Equals(bitNum))
            {
                result.Append("控电状态," + isTestStop2(stateNum));
            }
            else
            {
                result.Append("  ,  ");
            }

            return result.ToString();
        }

        #endregion

        #region 状态翻译

        public static string isPrimary(string msg)
        {
            if ("0".Equals(msg))
            {
                return "备用";
            }
            else if ("1".Equals(msg))
            {
                return "主用";
            }
            else
            {
                return "  ";
            }
        }

        public static string isException(string msg)
        {
            if ("0".Equals(msg))
            {
                return "正常";
            }
            else if ("1".Equals(msg))
            {
                return "异常";
            }
            else
            {
                return "  ";
            }
        }

        public static string isBreadDown(string msg)
        {
            if ("0".Equals(msg))
            {
                return "正常";
            }
            else if ("1".Equals(msg))
            {
                return "故障";
            }
            else
            {
                return "  ";
            }
        }

        public static string isBreadDown2(string msg)
        {
            if ("1".Equals(msg))
            {
                return "正常";
            }
            else if ("0".Equals(msg))
            {
                return "故障";
            }
            else
            {
                return "  ";
            }
        }

        public static string isEfficacious(string msg)
        {
            if ("0".Equals(msg))
            {
                return "正常";
            }
            else if ("1".Equals(msg))
            {
                return "无效";
            }
            else
            {
                return "  ";
            }
        }

        public static string isWarning(string msg)
        {
            if ("0".Equals(msg))
            {
                return "正常";
            }
            else if ("1".Equals(msg))
            {
                return "故障报警";
            }
            else
            {
                return "  ";
            }
        }

        public static string isBattery(string msg)
        {
            if ("0".Equals(msg))
            {
                return "正常";
            }
            else if ("1".Equals(msg))
            {
                return "欠压";
            }
            else
            {
                return "  ";
            }
        }

        public static string isRestore(string msg)
        {
            if ("0".Equals(msg))
            {
                return "正常";
            }
            else if ("1".Equals(msg))
            {
                return "恢复";
            }
            else
            {
                return "  ";
            }
        }

        public static string isTemporary(string msg)
        {
            if ("0".Equals(msg))
            {
                return "正常";
            }
            else if ("1".Equals(msg))
            {
                return "临时通车";
            }
            else
            {
                return "  ";
            }
        }

        public static string isStop(string msg)
        {
            if ("0".Equals(msg))
            {
                return "停车";
            }
            else if ("1".Equals(msg))
            {
                return "正常";
            }
            else
            {
                return "  ";
            }
        }

        public static string isCut(string msg)
        {
            if ("0".Equals(msg))
            {
                return "正常";
            }
            else if ("1".Equals(msg))
            {
                return "断线";
            }
            else
            {
                return "  ";
            }
        }

        public static string isWork(string msg)
        {
            if ("online".Equals(msg.ToLower()))
            {
                return "工作";
            }
            else if ("offline".Equals(msg.ToLower()))
            {
                return "不工作";
            }
            else
            {
                return "  ";
            }
        }

        public static string isPort(string msg)
        {
            if ("e1000g1".Equals(msg.ToLower()))
            {
                return "端口1";
            }
            else if ("e1000g0".Equals(msg.ToLower()))
            {
                return "端口0";
            }
            else
            {
                return "  ";
            }
        }

        public static string isInput(string msg)
        {
            if ("0".Equals(msg))
            {
                return "正常";
            }
            else if ("1".Equals(msg))
            {
                return "无输入";
            }
            else
            {
                return "  ";
            }
        }

        public static string isAlarm(string msg)
        {
            if ("0".Equals(msg))
            {
                return "正常";
            }
            else if ("1".Equals(msg))
            {
                return "报警";
            }
            else
            {
                return "  ";
            }
        }

        public static string isCom1(string msg)
        {
            if ("1".Equals(msg))
            {
                return "使用";
            }
            else if ("0".Equals(msg))
            {
                return "未使用";
            }
            else
            {
                return "  ";
            }
        }

        public static string isCom2(string msg)
        {
            if ("1".Equals(msg))
            {
                return "启用";
            }
            else if ("0".Equals(msg))
            {
                return "未启用";
            }
            else
            {
                return "  ";
            }
        }

        public static string isStop2(string msg)
        {
            if ("1".Equals(msg))
            {
                return "停电";
            }
            else if ("0".Equals(msg))
            {
                return "正常";
            }
            else
            {
                return "  ";
            }
        }

        public static string isStop3(string msg)
        {
            if ("1".Equals(msg))
            {
                return "停车";
            }
            else if ("0".Equals(msg))
            {
                return "正常";
            }
            else
            {
                return "  ";
            }
        }

        public static string isTestStop(string msg)
        {
            if ("5".Equals(msg))
            {
                return "停车";
            }
            else if ("0".Equals(msg))
            {
                return "正常";
            }
            else
            {
                return "无效";
            }
        }

        public static string isTestStop2(string msg)
        {
            if ("5".Equals(msg))
            {
                return "停电";
            }
            else if ("0".Equals(msg))
            {
                return "正常";
            }
            else
            {
                return "无效";
            }
        }

        public static string isChaos(string msg)
        {
            if ("0".Equals(msg))
            {
                return "正常";
            }
            else if ("1".Equals(msg))
            {
                return "混电";
            }
            else
            {
                return "  ";
            }
        }

        public static string isExperiment(string msg)
        {
            if ("0".Equals(msg))
            {
                return "正常";
            }
            else if ("1".Equals(msg))
            {
                return "实验";
            }
            else
            {
                return "  ";
            }
        }

        public static string isDrop(string msg)
        {
            if ("0".Equals(msg))
            {
                return "落下";
            }
            else if ("1".Equals(msg))
            {
                return "吸起";
            }
            else
            {
                return "  ";
            }
        }

        #endregion
    }
}
