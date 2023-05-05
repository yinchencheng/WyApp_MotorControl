using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WY_App.Utility
{
    internal class TcpClient
    {
        static Socket socketSend;
        static string reciveStr;
        public static bool TcpClientConnectResult = false;
        public TcpClient()
        {
            Thread th = new Thread(ini_Tcp_Client);
            th.IsBackground = true;
            th.Start();
        }
        public static void ini_Tcp_Client()
        {
            while(!TcpClientConnectResult)
            {
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(Parameter.commministion.TcpClientIpAddress);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(Parameter.commministion.TcpClientIpPort));
                socketSend.SendTimeout = 3000;
                socketSend.ReceiveTimeout = 5000;
                try
                {
                    socketSend.Connect(point);
                    LogHelper.Info("链接成功");
                    TcpClientConnectResult = true;

                }
                catch (Exception ex)
                {
                    LogHelper.Error("链接失败：", ex);
                    TcpClientConnectResult = false;
                }
            }          
        }

        public static string tcpClientSend(string sendstr)
        {
            //Task.Run(() => { });
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(sendstr);
            socketSend.Send(buffer);
            LogHelper.Info(socketSend.RemoteEndPoint + ":" + sendstr);
            reciveStr = Recive();
            LogHelper.Info(socketSend.RemoteEndPoint + ":" + reciveStr);
            return reciveStr;

        }
        static string Recive()
        {
            try
            {
                byte[] buffer = new byte[1024 * 1024 * 3];
                int r = socketSend.Receive(buffer);
                if (r == 0)
                {
                    reciveStr = "";
                }
                return Encoding.UTF8.GetString(buffer, 0, r);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
