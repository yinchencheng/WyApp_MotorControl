﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WY_App.Utility
{
    internal class TcpServer
    {
        public static bool TcpClientConnectResult = false;
        public TcpServer()
        {
            Thread th = new Thread(ini_Tcp_Server);
            th.IsBackground = true;
            th.Start();
        }
        static void ini_Tcp_Server()
        {
            while(!TcpClientConnectResult)
            {
                try
                {
                    //当点击开始监听的时候，在服务器端创建一个负责监听IP地址和端口号的socket
                    Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    //获取IP地址
                    //IPAddress ip = IPAddress.Any;
                    IPAddress ip = IPAddress.Parse(Parameter.commministion.TcpServerIpAddress);

                    //创建端口号
                    IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(Parameter.commministion.TcpServerIpPort));
                    //绑定IP地址和端口号
                    socketWatch.Bind(point);
                    socketWatch.SendTimeout = 5000;
                    socketWatch.ReceiveTimeout = 5000;
                    LogHelper.Info("监听成功");
                    //开始监听：设置最大可以同时连接多少个请求
                    socketWatch.Listen(10);

                    //创建监听线程，防止界面卡顿
                    Thread th = new Thread(Listen);
                    th.IsBackground = true;
                    th.Start(socketWatch);
                    TcpClientConnectResult = true;
                }
                catch (Exception ex)
                {
                    TcpClientConnectResult = false;
                    LogHelper.Error("tcp服务器创建失败！", ex);
                }
            }
                 
        }

        // 服务器端接收客服端发来的消息
        static string Recive()
        {
            try
            {
                byte[] buffer = new byte[1024 * 1024 * 2];
                int count = socketSend.Receive(buffer);
                if (count == 0)
                {
                    return "";
                }
                string str = Encoding.UTF8.GetString(buffer, 0, count);
                LogHelper.Info(socketSend.RemoteEndPoint + ":" + str);
                return str;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // 监听等待PC端的链接，创建通信用的Socket
        static Socket socketSend;
        static void Listen(object obj)
        {
            Socket socketWatch = obj as Socket;
            while (true)
            {
                try
                {
                    //等待客户端的链接，并且创建一个用于通信的Socket
                    socketSend = socketWatch.Accept();
                    LogHelper.Info(socketSend.RemoteEndPoint.ToString() + ":" + "连接成功");
                    Recive();                    
                }
                catch (Exception)
                {
                }
            }
        }
        //此处为发送事件
        public static  string tcp_Server_Send(string sendstr)
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(sendstr);
            socketSend.Send(buffer);
            string recivestr = Recive();
            return recivestr;
        }
        //防止线程间通讯报错
       
    }
}
