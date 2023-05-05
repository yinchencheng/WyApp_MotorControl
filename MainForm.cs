using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HslCommunication;
using HslCommunication.BasicFramework;
using log4net;
using WY_App.Utility;

namespace WY_App
{
    public partial class MainForm : Form
    {
        //static ObservableCollection<double> _wetSlope = new ObservableCollection<double> { };
        HslCommunication hslCommunication;
        public static bool plc_connect_result;
        public static string[] point_Location = new string[3] { "0", "0", "0" };
        public static string Alarm = "";
        Thread myThread;

        public MainForm()
        {
            InitializeComponent();

            try
            {
                Parameter.commministion = XMLHelper.BackSerialize<Parameter.Commministion>("Commministion.xml");
            }
            catch
            {
                Parameter.commministion = new Parameter.Commministion();
                XMLHelper.serialize<Parameter.Commministion>(Parameter.commministion, "Commministion.xml");
            }
            if (!EnumDivice(Parameter.commministion.DeviceID))
            {
                注册机器 flg = new 注册机器();
                flg.TransfEvent += DeviceID_TransfEvent;
                flg.ShowDialog();
                if (!EnumDivice(DeviceID))
                {
                    this.Close();
                    return;
                }
            }
            myThread = new Thread(initAll);           
            myThread.Start();
            //string str = TcpClient.tcpClientSend("Tcp接入");
            //this.SizeChanged += new EventHandler(Form1_SizeChanged);
        }
        private bool EnumDivice(string DiviceSn)
        {
            SoftAuthorize softAuthorize = new SoftAuthorize();
            if (!softAuthorize.CheckAuthorize(DiviceSn, AuthorizeEncrypted))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private string AuthorizeEncrypted(string origin)
        {
            return SoftSecurity.MD5Encrypt(origin, "12345678");
        }

        public static string DeviceID = "";
        void DeviceID_TransfEvent(string value)
        {
            DeviceID = value;
        }
        private void initAll()
        {
            while(true)
            {
                Thread.Sleep(1);
                Task task = new Task(() =>
                {
                    MethodInvoker start = new MethodInvoker(() =>
                    {
                        lab_X.Text = point_Location[0];
                        lab_Y.Text = point_Location[1];
                        lab_Z.Text = point_Location[2];
                        if(Alarm.Equals("error"))
                        {
                            lab_status.Text = Alarm;
                            lab_status.BackColor = Color.Red;
                        }
                        else
                        {
                            lab_status.Text = Alarm;
                            lab_status.BackColor = Color.Black;
                        }
                        if (Parameter.commministion.PlcEnable)
                        {
                            if (plc_connect_result)
                            {
                                lab_PLCStatus.Text = "在线";
                                lab_PLCStatus.BackColor = Color.Green;
                            }
                            else
                            {
                                lab_PLCStatus.Text = "离线";
                                lab_PLCStatus.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            lab_PLCStatus.Text = "禁用";
                            lab_PLCStatus.BackColor = Color.Gray;
                        }

                        if (Parameter.commministion.TcpServerEnable)
                        {
                            TcpClient tcpClient = new TcpClient();
                        }
                        else
                        {

                        }

                        if (Parameter.commministion.TcpServerEnable)
                        {
                            TcpServer tcpServer = new TcpServer();
                        }
                        else
                        {

                        }
                    });
                    this.BeginInvoke(start);
                });
                task.Start();                
            }
            
        }


        private void btn_Close_System_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定关闭程序吗？", "软件关闭提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                myThread.Abort();
                LogHelper.Info("软件关闭。");
                this.Close();
            }
        }

        private void btn_Minimizid_System_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            LogHelper.Info("窗体最小化。");

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();//隐藏主窗体  
                LogHelper.Info("主窗体隐藏。");                
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//当鼠标点击为左键时  
            {
                this.Show();//显示主窗体  
                LogHelper.Info("主窗体恢复。");
                this.WindowState = FormWindowState.Normal;//主窗体的大小为默认  
            }
        }

        private void parameterSetting_Click(object sender, EventArgs e)
        {


            //string tcpReciveStr = TcpServer.tcp_Server_Send("S1");
            //string[] a = tcpReciveStr.Split('+');
            //var files = Directory.GetFiles(@"D:\SGVision\InspectImage", "*.*", SearchOption.AllDirectories); // 遍历所有文件
            //var dirs = Directory.GetDirectories(@"D:\SGVision\InspectImage", "*", SearchOption.AllDirectories); //遍历所有文件夹
            //var list = files.Union(dirs).OrderBy(s => s);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            if (Parameter.commministion.PlcEnable)
            {
                hslCommunication = new HslCommunication();
                Thread.Sleep(1000);
                if (plc_connect_result)
                {
                    lab_PLCStatus.Text = "在线";
                    lab_PLCStatus.BackColor = Color.Green;
                }
                else
                {
                    lab_PLCStatus.Text = "离线";
                    lab_PLCStatus.BackColor = Color.Red;
                }
            }
            else
            {
                lab_PLCStatus.Text = "禁用";
                lab_PLCStatus.BackColor = Color.Gray;
            }
            if (Parameter.commministion.TcpServerEnable)
            {
                TcpClient tcpClient = new TcpClient();
            }
            else
            {

            }

            if (Parameter.commministion.TcpServerEnable)
            {
                TcpServer tcpServer = new TcpServer();
            }
            else
            {

            }
            num_X_JOG_Speed.Value = Parameter.plcParams.X_JOG_Move_Speed;
            num_Y_JOG_Speed.Value = Parameter.plcParams.Y_JOG_Move_Speed;
            num_Z_JOG_Speed.Value = Parameter.plcParams.Z_JOG_Move_Speed;
            num_JOG_Step.Value = Parameter.plcParams.JOG_Step;

            num_X_Run_Speed.Value = Parameter.plcParams.X_Run_Move_Speed;
            num_Y_Run_Speed.Value = Parameter.plcParams.Y_Run_Move_Speed;
            num_Z_Run_Speed.Value = Parameter.plcParams.Z_Run_Move_Speed;
            LogHelper.Info("初始化完成");
        }

        #region 点击panel控件移动窗口
        Point downPoint;
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);
        }
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X,
                    this.Location.Y + e.Y - downPoint.Y);
            }
        }
        #endregion

        private void btn_SettingMean_Click(object sender, EventArgs e)
        {
            FormLogin flg=new FormLogin();
            flg.ShowDialog();
          
        }

        private void btn_JOG_Change_Click(object sender, EventArgs e)
        {
            try
            {
                Parameter.plcParams.X_JOG_Move_Speed = num_X_JOG_Speed.Value;
                Parameter.plcParams.Y_JOG_Move_Speed = num_Y_JOG_Speed.Value;
                Parameter.plcParams.Z_JOG_Move_Speed = num_Z_JOG_Speed.Value;
                Parameter.plcParams.JOG_Step = num_JOG_Step.Value;

                if (plc_connect_result && Parameter.plcParams.X_JogMoveSpeedAdd != null && Parameter.plcParams.X_JogMoveSpeedAdd != "")
                {
                    HslCommunication.ReadWritePmacVariables(Parameter.plcParams.X_JogMoveSpeedAdd + Parameter.plcParams.X_JOG_Move_Speed);
                }
                else
                {
                    LogHelper.Info(Parameter.plcParams.X_JogMoveSpeedAdd + "参数地址为空");
                }               

                if (plc_connect_result && Parameter.plcParams.Y_JogMoveSpeedAdd != null && Parameter.plcParams.Y_JogMoveSpeedAdd != "")
                {
                    HslCommunication.ReadWritePmacVariables(Parameter.plcParams.Y_JogMoveSpeedAdd + Parameter.plcParams.Y_JOG_Move_Speed);
                }
                else
                {
                    LogHelper.Info(Parameter.plcParams.Y_JogMoveSpeedAdd + "参数地址为空");
                }
                if (plc_connect_result && Parameter.plcParams.Z_JogMoveSpeedAdd != null && Parameter.plcParams.Z_JogMoveSpeedAdd != "")
                {
                    HslCommunication.ReadWritePmacVariables(Parameter.plcParams.Z_JogMoveSpeedAdd + Parameter.plcParams.Z_JOG_Move_Speed);
                }
                else
                {
                    LogHelper.Info(Parameter.plcParams.Z_JogMoveSpeedAdd + "参数地址为空");
                }

                if (plc_connect_result && Parameter.plcParams.JOGMoveStepAdd != null && Parameter.plcParams.JOGMoveStepAdd != "")
                {
                    HslCommunication.ReadWritePmacVariables(Parameter.plcParams.JOGMoveStepAdd + Parameter.plcParams.JOG_Step);
                }
                else
                {
                    LogHelper.Info(Parameter.plcParams.JOGMoveStepAdd + "参数地址为空");
                }

                LogHelper.Info("参数保存");
                XMLHelper.serialize<Parameter.PLCParams>(Parameter.plcParams, "PLCParams.xml");
            }
            catch
            {
                LogHelper.Info("参数保存失败");
                MessageBox.Show("参数保存失败");
            }
           
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if(plc_connect_result && Parameter.plcParams.StartAdd != null && Parameter.plcParams.StartAdd !="")
            {
                HslCommunication.ReadWritePmacVariables(Parameter.plcParams.StartAdd);
                btn_Start.FillColor = Color.LightGreen;
                btn_Stop.FillColor = Color.Black;
            }
            
        }
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (plc_connect_result && Parameter.plcParams.StopAdd != null && Parameter.plcParams.StopAdd != "")
            {
                HslCommunication.ReadWritePmacVariables(Parameter.plcParams.StopAdd);               
                btn_Stop.FillColor = Color.Red;
                btn_Start.FillColor = Color.Black;
            }
                
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            if (plc_connect_result && Parameter.plcParams.ResetAdd != null && Parameter.plcParams.ResetAdd != "")
            {
                HslCommunication.ReadWritePmacVariables(Parameter.plcParams.ResetAdd);
                btn_Stop.FillColor = Color.Black;
                btn_Start.FillColor = Color.Black;
            }
        }

        private void btn_JOG_Xadd_Click(object sender, EventArgs e)
        {
            if (plc_connect_result && Parameter.plcParams.X_JogMoveAdd != null && Parameter.plcParams.X_JogMoveAdd != "")
            {
               bool result = HslCommunication.ReadWritePmacVariables(Parameter.plcParams.X_JogMoveAdd);
                result = HslCommunication.ReadWritePmacVariables("#1jog/");
            }
        }

        private void btn_JOG_Xred_Click(object sender, EventArgs e)
        {
            if (plc_connect_result && Parameter.plcParams.X_JogMoveRed != null && Parameter.plcParams.X_JogMoveRed != "")
            {
                bool result = HslCommunication.ReadWritePmacVariables(Parameter.plcParams.X_JogMoveRed);
                result = HslCommunication.ReadWritePmacVariables("#1jog/");
            }
            
        }

        private void btn_JOG_Yadd_Click(object sender, EventArgs e)
        {
            if (plc_connect_result && Parameter.plcParams.Y_JogMoveAdd != null && Parameter.plcParams.Y_JogMoveAdd != "")
            {
                bool result = HslCommunication.ReadWritePmacVariables(Parameter.plcParams.Y_JogMoveAdd);
                result = HslCommunication.ReadWritePmacVariables("#2jog/");
            }           
        }

        private void btn_JOG_Yred_Click(object sender, EventArgs e)
        {
            if (plc_connect_result && Parameter.plcParams.Y_JogMoveRed != null && Parameter.plcParams.Y_JogMoveRed != "")
            {
                bool result = HslCommunication.ReadWritePmacVariables(Parameter.plcParams.Y_JogMoveRed);
                result = HslCommunication.ReadWritePmacVariables("#2jog/");
            }
                
        }

        private void btn_JOG_Zadd_Click(object sender, EventArgs e)
        {
            if (plc_connect_result && Parameter.plcParams.Z_JogMoveAdd != null && Parameter.plcParams.Z_JogMoveAdd != "")
            {
                bool result = HslCommunication.ReadWritePmacVariables(Parameter.plcParams.Z_JogMoveAdd);
                result = HslCommunication.ReadWritePmacVariables("#3jog/");
            }
                
        }

        private void btn_JOG_Zred_Click(object sender, EventArgs e)
        {
            if (plc_connect_result && Parameter.plcParams.Z_JogMoveRed != null && Parameter.plcParams.Z_JogMoveRed != "")
            {
                bool result = HslCommunication.ReadWritePmacVariables(Parameter.plcParams.Z_JogMoveRed);
                result = HslCommunication.ReadWritePmacVariables("#3jog/");
            }
                
        }

        private void btn_JOG_Home_Click(object sender, EventArgs e)
        {
            if (plc_connect_result && Parameter.plcParams.BackHomeAdd != null && Parameter.plcParams.BackHomeAdd != "")
            {
                bool result = HslCommunication.ReadWritePmacVariables(Parameter.plcParams.BackHomeAdd);
            }               
        }

        private void btn_Run_Change_Click(object sender, EventArgs e)
        {
            try
            {
                Parameter.plcParams.X_Run_Move_Speed = num_X_Run_Speed.Value;
                Parameter.plcParams.Y_Run_Move_Speed = num_Y_Run_Speed.Value;
                Parameter.plcParams.Z_Run_Move_Speed = num_Z_Run_Speed.Value;

                if (plc_connect_result && Parameter.plcParams.X_RunMoveSpeedAdd != null && Parameter.plcParams.X_RunMoveSpeedAdd != "")
                {
                    HslCommunication.ReadWritePmacVariables(Parameter.plcParams.X_RunMoveSpeedAdd + Parameter.plcParams.X_Run_Move_Speed);
                }
                else
                {
                    LogHelper.Info(Parameter.plcParams.X_RunMoveSpeedAdd + "参数地址为空");
                }

                if (plc_connect_result && Parameter.plcParams.Y_RunMoveSpeedAdd != null && Parameter.plcParams.Y_RunMoveSpeedAdd != "")
                {
                    HslCommunication.ReadWritePmacVariables(Parameter.plcParams.Y_RunMoveSpeedAdd + Parameter.plcParams.Y_Run_Move_Speed);
                }
                else
                {
                    LogHelper.Info(Parameter.plcParams.Y_RunMoveSpeedAdd + "参数地址为空");
                }
                if (plc_connect_result && Parameter.plcParams.Z_RunMoveSpeedAdd != null && Parameter.plcParams.Z_RunMoveSpeedAdd != "")
                {
                    HslCommunication.ReadWritePmacVariables(Parameter.plcParams.Z_RunMoveSpeedAdd +  Parameter.plcParams.Z_Run_Move_Speed);
                }
                else
                {
                    LogHelper.Info(Parameter.plcParams.Z_RunMoveSpeedAdd + "参数地址为空");
                }

                LogHelper.Info("参数保存");
                XMLHelper.serialize<Parameter.PLCParams>(Parameter.plcParams, "PLCParams.xml");
            }
            catch
            {
                LogHelper.Info("参数保存失败");
                MessageBox.Show("参数保存失败");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
