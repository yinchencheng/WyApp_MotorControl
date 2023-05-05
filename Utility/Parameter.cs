using HslCommunication.Profinet.Keyence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WY_App.Utility
{
    public class Parameter
    {
        /// <summary>
        /// 日志等级
        /// </summary>
        public enum LogLevelEnum
        {
            Debug = 0,
            Info = 1,
            Warn = 2,
            Error = 3,
            Fatal = 4
        }
     
        public class Commministion
        {
            /// <summary>
            /// 当前保存日志等级
            /// </summary>
            public LogLevelEnum LogLevel;

            /// <summary>
            /// 日志存放路径
            /// </summary>
            public string LogFilePath;

            /// <summary>
            /// 日志存放天数
            /// </summary>
            public int LogFileExistDay;

            /// <summary>
            /// plc启用标志
            /// </summary>
            public bool PlcEnable;

            /// <summary>
            /// plc型号
            /// </summary>
            public string PlcType;

            /// <summary>
            /// plc ip地址
            /// </summary>
            public string PlcIpAddress;

            /// <summary>
            /// plc ip端口号
            /// </summary>
            public int PlcIpPort;

            /// <summary>
            /// plc 站号/型号
            /// </summary>
            public int PlcDevice;

            /// <summary>
            /// Tcp客户端启用标志
            /// </summary>
            public bool TcpClientEnable;

            /// <summary>
            /// tcp ip地址
            /// </summary>
            public string TcpClientIpAddress;

            /// <summary>
            /// tcp ip端口号
            /// </summary>
            public int TcpClientIpPort;

            /// <summary>
            /// Tcp服务端启用标志
            /// </summary>
            public bool TcpServerEnable;

            /// <summary>
            /// tcp服务器 ip地址
            /// </summary>
            public string TcpServerIpAddress;

            /// <summary>
            /// tcp服务器 ip端口号
            /// </summary>
            public int TcpServerIpPort;
            public string DeviceID;
            /// <summary>
            /// 联机参数设置
            /// </summary>
            public Commministion()
            {
                //PLC启用标志
                PlcEnable = false;
                //--PLC参数设置--
                //--欧姆龙Omron.OmronFinsNet--
                //--西门子Siemens.SiemensS7Net--
                //--三菱Melsec.MelsecMcNet--
                //--汇川Inovance.InovanceSerialOverTcp--
                //--ModbusTcp

                //PLC 类型
                PlcType = "Omron.OmronFinsNet";
                //PLC 地址
                PlcIpAddress = "127.0.0.1";
                //PLC站号/型号
                PlcDevice = 200;
                //PLC 端口号
                PlcIpPort = 9600;

                //--TCP客户端参数设置--
                //Tcp客户端启用标志
                TcpClientEnable = false;
                //TCP 客户端 地址
                TcpClientIpAddress = "127.0.0.1";
                //TCP 客户端 端口号
                TcpClientIpPort = 9600;

                //--TCP服务器参数设置--
                //Tcp服务器启用标志
                TcpServerEnable = false;
                //TCP服务器 地址
                TcpServerIpAddress = "127.0.0.1";
                //TCP服务器 端口号
                TcpServerIpPort = 9600;
                DeviceID = "";
            }
        }

        public static Commministion commministion = new Commministion();

        public class PLCParams
        {
            public string AlarmAdd;
            public string BackHomeAdd;
            public string HeartBeatAdd;
            public string PointMoveAdd;
            public string JOGMoveStepAdd;
            public string ResetAdd;
            public string StartAdd;
            public string StopAdd;
            public string X_JogMoveAdd;
            public string X_JogMoveRed;
            public string X_JogMoveSpeedAdd;
            public string X_MoveLimitAdd;
            public string X_PointMoveAdd;
            public string X_Read_Add;
            public string X_RunMoveSpeedAdd;
            public string Y_JogMoveAdd;
            public string Y_JogMoveRed;
            public string Y_JogMoveSpeedAdd;
            public string Y_MoveLimitAdd;
            public string Y_PointMoveAdd;
            public string Y_Read_Add;
            public string Y_RunMoveSpeedAdd;
            public string Z_JogMoveAdd;
            public string Z_JogMoveRed;
            public string Z_JogMoveSpeedAdd;
            public string Z_MoveLimitAdd;
            public string Z_PointMoveAdd;
            public string Z_Read_Add;
            public string Z_RunMoveSpeedAdd;

            public double X_JOG_Move_Speed;
            public double Y_JOG_Move_Speed;
            public double Z_JOG_Move_Speed;
            public double JOG_Step;
            public double X_Run_Move_Speed;
            public double Y_Run_Move_Speed;
            public double Z_Run_Move_Speed;

            public PLCParams()
            {
                AlarmAdd = "D100";
                BackHomeAdd = "D100";
                HeartBeatAdd = "D102";
                PointMoveAdd = "D104";
                ResetAdd = "D106";
                StartAdd = "D108";
                StopAdd = "D108";
                X_JogMoveAdd = "D110";
                X_JogMoveRed = "D112";
                X_JogMoveSpeedAdd = "D114";
                X_MoveLimitAdd = "D116";
                X_PointMoveAdd = "D118";
                X_Read_Add = "D120";
                X_RunMoveSpeedAdd = "D122";
                Y_JogMoveAdd = "D124";
                Y_JogMoveRed = "D126";
                Y_JogMoveSpeedAdd = "D128";
                Y_MoveLimitAdd = "D130";
                Y_PointMoveAdd = "D132";
                Y_Read_Add = "D134";
                Y_RunMoveSpeedAdd = "D136";
                Z_JogMoveAdd = "D138";
                Z_JogMoveRed = "D140";
                Z_JogMoveSpeedAdd = "D142";
                Z_MoveLimitAdd = "D144";
                Z_PointMoveAdd = "D146";
                Z_Read_Add = "D148";
                Z_RunMoveSpeedAdd = "D150";  

                X_JOG_Move_Speed = 0;
                Y_JOG_Move_Speed = 0;
                Z_JOG_Move_Speed = 0;
                X_Run_Move_Speed = 0;
                Y_Run_Move_Speed = 0;
                Z_Run_Move_Speed = 0;
                JOG_Step = 10;               
            }
        }

        public static PLCParams plcParams = new PLCParams();
    }
}