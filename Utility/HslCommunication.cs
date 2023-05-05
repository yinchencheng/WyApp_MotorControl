using System;
using System.Threading;
using HslCommunication;
using HslCommunication.Core.Net;
using HslCommunication.Profinet.Melsec;
using HslCommunication.Profinet.Omron;
using HslCommunication.Profinet.Siemens;
using HslCommunication.Profinet.Inovance;
using WY_App.Utility;
using HslCommunication.Core;
using System.IO;
using HslCommunication.ModBus;
//power pmac配置
using ODT.PowerPmacComLib;
using ODT.Common.Services;
using ODT.Common.Core;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WY_App
{
    internal class HslCommunication
    {
        public static OperateResult plc_connect_result;
        public static NetworkDeviceBase _NetworkTcpDevice;
        static ISyncGpasciiCommunicationInterface communication = null;
        deviceProperties currentDeviceProp = new deviceProperties();
        deviceProperties currentDevProp = new deviceProperties();
        string commands = String.Empty;
        public static string response = String.Empty;

        bool _connected =false;


        public HslCommunication()
        {
            try
            {
                Parameter.plcParams = XMLHelper.BackSerialize<Parameter.PLCParams>("PLCParams.xml");
            }
            catch
            {
                Parameter.plcParams = new Parameter.PLCParams();
                XMLHelper.serialize<Parameter.PLCParams>(Parameter.plcParams, "PLCParams.xml");
            }
           
            Thread th = new Thread(ini_PLC_Connect);
            th.IsBackground = true;
            th.Start();

            Thread PLC_Read = new Thread(ini_PLC_Read);
            PLC_Read.IsBackground = true;
            PLC_Read.Start();
        }
        public void ini_PLC_Connect()
        {
            if (!Authorization.SetAuthorizationCode("f562cc4c-4772-4b32-bdcd-f3e122c534e3"))
            {
                LogHelper.Error("HslCommunication 组件认证失败，组件只能使用8小时!");

            }           
            while (!_connected)
            {
                Thread.Sleep(1000);
                try
                {
                    if ("Omron.PMAC.CK3M".Equals(Parameter.commministion.PlcType))
                    {

                       
                        currentDevProp.IPAddress = "192.168.0.200";
                        currentDevProp.Password = "deltatau";
                        currentDevProp.PortNumber = Convert.ToInt16(22);
                        currentDevProp.User = "root";
                        currentDevProp.Protocol = CommunicationGlobals.ConnectionTypes.SSH;
                        communication = Connect.CreateSyncGpascii(currentDevProp.Protocol, communication);
                        _connected = communication.ConnectGpAscii(currentDevProp.IPAddress, currentDevProp.PortNumber, currentDevProp.User, currentDevProp.Password);
                        MainForm.plc_connect_result = _connected;
                        //ModbusTcpNet Client = new ModbusTcpNet();
                        //Client.IpAddress = Parameter.commministion.PlcIpAddress;
                        //Client.Port = Parameter.commministion.PlcIpPort;
                        //Client.DataFormat = DataFormat.ABCD;
                        //_NetworkTcpDevice = Client;
                        //plc_connect_result = _NetworkTcpDevice.ConnectServer();
                    }
                    else
                    {
                        //欧姆龙PLC OmronFinsNet通讯
                        if ("Omron.OmronFinsNet".Equals(Parameter.commministion.PlcType))
                        {
                            OmronFinsNet Client = new OmronFinsNet();
                            Client.IpAddress = Parameter.commministion.PlcIpAddress;
                            Client.Port = Parameter.commministion.PlcIpPort;
                            Client.SA1 = Convert.ToByte(Parameter.commministion.PlcDevice);
                            _NetworkTcpDevice = Client;
                            plc_connect_result = _NetworkTcpDevice.ConnectServer();
                        }
                        //三菱PLC Melsec.MelsecMcNet通讯
                        else if ("Melsec.MelsecMcNet".Equals(Parameter.commministion.PlcType))
                        {
                            MelsecMcNet Client = new MelsecMcNet();
                            Client.IpAddress = Parameter.commministion.PlcIpAddress;
                            Client.Port = Parameter.commministion.PlcIpPort;
                            _NetworkTcpDevice = Client;
                            plc_connect_result = _NetworkTcpDevice.ConnectServer();
                        }
                        //西门子PLC Siemens.SiemensS7Net通讯
                        else if ("Siemens.SiemensS7Net".Equals(Parameter.commministion.PlcType))
                        {
                            SiemensS7Net Client = new SiemensS7Net((SiemensPLCS)Parameter.commministion.PlcDevice, Parameter.commministion.PlcIpAddress);
                            Client.IpAddress = Parameter.commministion.PlcIpAddress;
                            Client.Port = Parameter.commministion.PlcIpPort;
                            _NetworkTcpDevice = Client;
                            plc_connect_result = _NetworkTcpDevice.ConnectServer();
                        }
                        //汇川PLC Inovance.InovanceSerialOverTcp通讯
                        else if ("Inovance.InovanceSerialOverTcp".Equals(Parameter.commministion.PlcType))
                        {
                            InovanceSerialOverTcp Client = new InovanceSerialOverTcp();
                            Client.IpAddress = Parameter.commministion.PlcIpAddress;
                            Client.Port = Parameter.commministion.PlcIpPort;
                            Client.DataFormat = DataFormat.ABCD;
                            _NetworkTcpDevice = Client;
                            plc_connect_result = _NetworkTcpDevice.ConnectServer();
                        }
                        //ModbusTcp通讯
                        else if ("ModbusTcpNet".Equals(Parameter.commministion.PlcType))
                        {
                            ModbusTcpNet Client = new ModbusTcpNet();
                            Client.IpAddress = Parameter.commministion.PlcIpAddress;
                            Client.Port = Parameter.commministion.PlcIpPort;
                            Client.DataFormat = DataFormat.ABCD;
                            _NetworkTcpDevice = Client;
                            plc_connect_result = _NetworkTcpDevice.ConnectServer();
                        }
                        //ModbusTcp通讯

                        //新增通讯添加else if判断创建连接

                        //Parameter.PlcType字符错误或未定义
                        else
                        {
                            LogHelper.Error("plc类型未定义：" + Parameter.commministion.PlcType);
                            _connected = false;
                        }

                        if (plc_connect_result.IsSuccess)
                        {
                            LogHelper.Info("plc连接成功:" + "IP" + Parameter.commministion.PlcIpAddress + "  Port:" + Parameter.commministion.PlcIpPort);
                            _connected = true;
                        }
                        else
                        {
                            LogHelper.Warn("plc连接失败:" + "IP" + Parameter.commministion.PlcIpAddress + "  Port:" + Parameter.commministion.PlcIpPort);
                            _connected = false;
                        }
                        MainForm.plc_connect_result = _connected;
                    }
                   
                }
                catch (Exception ex)
                {
                    LogHelper.Error("plc初始化失败：", ex);
                    _connected = false;
                    MainForm.plc_connect_result = _connected;
                }
                if (_connected)
                {
                    LogHelper.Info("plc连接成功:" + "IP" + Parameter.commministion.PlcIpAddress + "  Port:" + Parameter.commministion.PlcIpPort);
                    _connected = true;
                }
                else
                {
                    LogHelper.Warn("plc连接失败:" + "IP" + Parameter.commministion.PlcIpAddress + "  Port:" + Parameter.commministion.PlcIpPort);
                    _connected = false;
                }

            }
            while (_connected)
            {

                ////心跳读写，判断PLC是否掉线，不建议线程对plc链接释放重连
                if ("Omron.PMAC.CK3M".Equals(Parameter.commministion.PlcType))
                {
                    _connected = ReadWritePmacVariables(Parameter.plcParams.HeartBeatAdd);
                    Thread.Sleep(3000);
                }
                else
                {
                    try
                    {
                        plc_connect_result = _NetworkTcpDevice.Write(Parameter.plcParams.HeartBeatAdd, true);
                        Thread.Sleep(3000);
                        plc_connect_result = _NetworkTcpDevice.Write(Parameter.plcParams.HeartBeatAdd, false);
                        Thread.Sleep(000);
                        _connected = true;
                        MainForm.plc_connect_result = _connected;
                    }
                    catch
                    {
                        _NetworkTcpDevice.Dispose();
                        plc_connect_result.IsSuccess = false;
                        _connected = false;
                        MainForm.plc_connect_result = _connected;
                    }
                }
            }             
        }
        public void ini_PLC_Read()
        { 
            while(true)
            {
                if(_connected)
                {
                    if ("Omron.PMAC.CK3M".Equals(Parameter.commministion.PlcType))
                    {
                        Thread.Sleep(1);
                        ReadWritePmacVariables("Motor[1].ActPos,3");
                        string JogSpeed0 = response;
                        MainForm.point_Location = JogSpeed0.Split(',');
                        Thread.Sleep(1);
                        ReadWritePmacVariables(Parameter.plcParams.AlarmAdd);
                        MainForm.Alarm = response;

                    }
                    else
                    {
                        Thread.Sleep(1);
                        MainForm.point_Location[0] = _NetworkTcpDevice.ReadDouble(Parameter.plcParams.X_Read_Add).Content.ToString(); // 读取寄存器100-101的float值
                        MainForm.point_Location[1] = _NetworkTcpDevice.ReadDouble(Parameter.plcParams.Y_Read_Add).Content.ToString(); // 读取寄存器100-101的float值
                        MainForm.point_Location[2] = _NetworkTcpDevice.ReadDouble(Parameter.plcParams.Z_Read_Add).Content.ToString(); // 读取寄存器100-101的float值
                    }
                }
                else
                {
                    Thread.Sleep(1000);
                    MainForm.point_Location[0] = "-1";
                    MainForm.point_Location[1] = "-1";
                    MainForm.point_Location[2] = "-1";
                }                
            }
        }


        //对终端操作的通用方法/
        public static bool ReadWritePmacVariables(string command)
        {
            var commads = new List<string>();
            List<string> responses;
            commads.Add(command.ToString());
            var communicationStatus = communication.GetResponse(commads, out responses, 3);
            if (communicationStatus == Status.Ok)
            {
                response = string.Join("", responses.ToArray());
                command = null;
                return  true;
            }
            else
            {
                return  false;
            }
        }


        public static  double plc_Readdouble(string ReadAddress)
        {
            return -1;
        }
        public static void plc_WriteDouble()
        {

        }

        public static void plc_WriteBool()
        {
           
        }
    }
}
