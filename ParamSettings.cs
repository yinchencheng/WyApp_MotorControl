using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WY_App.Utility;
using Parameter = WY_App.Utility.Parameter;

namespace WY_App
{
    public partial class ParamSettings : Form
    {
        public ParamSettings()
        {
            InitializeComponent();
        }

        private void btn_Close_System_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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

        private void btn_Change_Click(object sender, EventArgs e)
        {
            txt_AlarmAdd.Enabled = true;
            txt_BackHomeAdd.Enabled = true;
            txt_HeartBeatAdd.Enabled = true;
            txt_PointMoveAdd.Enabled = true;
            txt_PointMoveStepAdd.Enabled = true;
            txt_ResetAdd.Enabled = true;
            txt_StartAdd.Enabled = true;
            txt_StopAdd.Enabled = true;
            txt_X_JogMoveAdd.Enabled = true;
            txt_X_JogMoveRed.Enabled = true;
            txt_X_JogMoveSpeedAdd.Enabled = true;
            txt_X_MoveLimitAdd.Enabled = true;
            txt_X_PointMoveAdd.Enabled = true;
            txt_X_Read_Add.Enabled = true;
            txt_X_RunMoveSpeedAdd.Enabled = true;
            txt_Y_JogMoveAdd.Enabled = true;
            txt_Y_JogMoveRed.Enabled = true;
            txt_Y_JogMoveSpeedAdd.Enabled = true;
            txt_Y_MoveLimitAdd.Enabled = true;
            txt_Y_PointMoveAdd.Enabled = true;
            txt_Y_Read_Add.Enabled = true;
            txt_Y_RunMoveSpeedAdd.Enabled = true;
            txt_Z_JogMoveAdd.Enabled = true;
            txt_Z_JogMoveRed.Enabled = true;
            txt_Z_JogMoveSpeedAdd.Enabled = true;
            txt_Z_MoveLimitAdd.Enabled = true;
            txt_Z_PointMoveAdd.Enabled = true;
            txt_Z_Read_Add.Enabled = true;
            txt_Z_RunMoveSpeedAdd.Enabled = true;
            btn_Save.Enabled = true;
        }

        private void ParamSettings_Load(object sender, EventArgs e)
        {
            txt_AlarmAdd.Text = Parameter.plcParams.AlarmAdd;
            txt_BackHomeAdd.Text = Parameter.plcParams.BackHomeAdd;
            txt_HeartBeatAdd.Text = Parameter.plcParams.HeartBeatAdd;
            txt_PointMoveAdd.Text = Parameter.plcParams.PointMoveAdd;
            txt_PointMoveStepAdd.Text = Parameter.plcParams.JOGMoveStepAdd;
            txt_ResetAdd.Text = Parameter.plcParams.ResetAdd;
            txt_StartAdd.Text = Parameter.plcParams.StartAdd;
            txt_StopAdd.Text = Parameter.plcParams.StopAdd;
            txt_X_JogMoveAdd.Text = Parameter.plcParams.X_JogMoveAdd;
            txt_X_JogMoveRed.Text = Parameter.plcParams.X_JogMoveRed;
            txt_X_JogMoveSpeedAdd.Text = Parameter.plcParams.X_JogMoveSpeedAdd;
            txt_X_MoveLimitAdd.Text = Parameter.plcParams.X_MoveLimitAdd;
            txt_X_PointMoveAdd.Text = Parameter.plcParams.X_PointMoveAdd;
            txt_X_Read_Add.Text = Parameter.plcParams.X_Read_Add;
            txt_X_RunMoveSpeedAdd.Text = Parameter.plcParams.Y_JogMoveSpeedAdd;
            txt_Y_JogMoveAdd.Text = Parameter.plcParams.Y_JogMoveAdd;
            txt_Y_JogMoveRed.Text = Parameter.plcParams.Y_JogMoveRed;
            txt_Y_JogMoveSpeedAdd.Text = Parameter.plcParams.Y_JogMoveSpeedAdd;
            txt_Y_MoveLimitAdd.Text = Parameter.plcParams.Y_MoveLimitAdd;
            txt_Y_PointMoveAdd.Text = Parameter.plcParams.Y_PointMoveAdd;
            txt_Y_Read_Add.Text = Parameter.plcParams.Y_Read_Add;
            txt_Y_RunMoveSpeedAdd.Text = Parameter.plcParams.Y_RunMoveSpeedAdd;
            txt_Z_JogMoveAdd.Text = Parameter.plcParams.Z_JogMoveAdd;
            txt_Z_JogMoveRed.Text = Parameter.plcParams.Z_JogMoveRed;
            txt_Z_JogMoveSpeedAdd.Text = Parameter.plcParams.Z_JogMoveSpeedAdd;
            txt_Z_MoveLimitAdd.Text = Parameter.plcParams.Z_MoveLimitAdd;
            txt_Z_PointMoveAdd.Text = Parameter.plcParams.Z_PointMoveAdd;
            txt_Z_Read_Add.Text = Parameter.plcParams.Z_Read_Add;
            txt_Z_RunMoveSpeedAdd.Text = Parameter.plcParams.Z_RunMoveSpeedAdd;

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Parameter.plcParams.AlarmAdd= txt_AlarmAdd.Text;
            Parameter.plcParams.BackHomeAdd = txt_BackHomeAdd.Text;
            Parameter.plcParams.HeartBeatAdd = txt_HeartBeatAdd.Text;
            Parameter.plcParams.PointMoveAdd = txt_PointMoveAdd.Text;
            Parameter.plcParams.JOGMoveStepAdd=txt_PointMoveStepAdd.Text;
            Parameter.plcParams.ResetAdd = txt_ResetAdd.Text;
            Parameter.plcParams.StartAdd = txt_StartAdd.Text;
            Parameter.plcParams.StopAdd = txt_StopAdd.Text;
            Parameter.plcParams.X_JogMoveAdd = txt_X_JogMoveAdd.Text;
            Parameter.plcParams.X_JogMoveRed = txt_X_JogMoveRed.Text;
            Parameter.plcParams.X_JogMoveSpeedAdd = txt_X_JogMoveSpeedAdd.Text;
            Parameter.plcParams.X_MoveLimitAdd = txt_X_MoveLimitAdd.Text;
            Parameter.plcParams.X_PointMoveAdd = txt_X_PointMoveAdd.Text;
            Parameter.plcParams.X_Read_Add = txt_X_Read_Add.Text;
            Parameter.plcParams.Y_JogMoveSpeedAdd = txt_X_RunMoveSpeedAdd.Text;
            Parameter.plcParams.Y_JogMoveAdd = txt_Y_JogMoveAdd.Text;
            Parameter.plcParams.Y_JogMoveRed = txt_Y_JogMoveRed.Text;
            Parameter.plcParams.Y_JogMoveSpeedAdd = txt_Y_JogMoveSpeedAdd.Text;
            Parameter.plcParams.Y_MoveLimitAdd = txt_Y_MoveLimitAdd.Text;
            Parameter.plcParams.Y_PointMoveAdd = txt_Y_PointMoveAdd.Text;
            Parameter.plcParams.Y_Read_Add = txt_Y_Read_Add.Text;
            Parameter.plcParams.Y_RunMoveSpeedAdd = txt_Y_RunMoveSpeedAdd.Text;
            Parameter.plcParams.Z_JogMoveAdd = txt_Z_JogMoveAdd.Text;
            Parameter.plcParams.Z_JogMoveRed = txt_Z_JogMoveRed.Text;
            Parameter.plcParams.Z_JogMoveSpeedAdd = txt_Z_JogMoveSpeedAdd.Text;
            Parameter.plcParams.Z_MoveLimitAdd = txt_Z_MoveLimitAdd.Text;
            Parameter.plcParams.Z_PointMoveAdd = txt_Z_PointMoveAdd.Text;
            Parameter.plcParams.Z_Read_Add = txt_Z_Read_Add.Text;
            Parameter.plcParams.Z_RunMoveSpeedAdd = txt_Z_RunMoveSpeedAdd.Text;
            XMLHelper.serialize<Parameter.PLCParams>(Parameter.plcParams, "PLCParams.xml");
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
