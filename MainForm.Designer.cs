namespace WY_App
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_JOG_Yred = new Sunny.UI.UIButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.num_JOG_Step = new Sunny.UI.UIDoubleUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.num_Z_JOG_Speed = new Sunny.UI.UIDoubleUpDown();
            this.num_Y_JOG_Speed = new Sunny.UI.UIDoubleUpDown();
            this.num_X_JOG_Speed = new Sunny.UI.UIDoubleUpDown();
            this.btn_JOG_Change = new Sunny.UI.UIButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_JOG_Zred = new Sunny.UI.UIButton();
            this.btn_JOG_Zadd = new Sunny.UI.UIButton();
            this.btn_JOG_Yadd = new Sunny.UI.UIButton();
            this.btn_JOG_Xadd = new Sunny.UI.UIButton();
            this.btn_JOG_Xred = new Sunny.UI.UIButton();
            this.btn_JOG_Home = new Sunny.UI.UIButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_Y_Run_Point = new Sunny.UI.UIDoubleUpDown();
            this.num_X_Run_Point = new Sunny.UI.UIDoubleUpDown();
            this.num_Z_Run_Point = new Sunny.UI.UIDoubleUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.num_Z_Run_Speed = new Sunny.UI.UIDoubleUpDown();
            this.num_Y_Run_Speed = new Sunny.UI.UIDoubleUpDown();
            this.num_X_Run_Speed = new Sunny.UI.UIDoubleUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_Run_Change = new Sunny.UI.UIButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_Point_Move = new Sunny.UI.UIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Start = new Sunny.UI.UIButton();
            this.btn_Close_System = new Sunny.UI.UIButton();
            this.btn_SettingMean = new Sunny.UI.UIButton();
            this.btn_Stop = new Sunny.UI.UIButton();
            this.btn_Minimizid_System = new Sunny.UI.UIButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Reset = new Sunny.UI.UIButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lab_PLCStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lab_X = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lab_Y = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lab_Z = new System.Windows.Forms.ToolStripStatusLabel();
            this.lab_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 70);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.24107F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.75893F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(837, 553);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(837, 299);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JOG控制";
            // 
            // btn_JOG_Yred
            // 
            this.btn_JOG_Yred.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_JOG_Yred.FillColor = System.Drawing.Color.Black;
            this.btn_JOG_Yred.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_JOG_Yred.Location = new System.Drawing.Point(143, 4);
            this.btn_JOG_Yred.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_JOG_Yred.Name = "btn_JOG_Yred";
            this.btn_JOG_Yred.Size = new System.Drawing.Size(111, 84);
            this.btn_JOG_Yred.Style = Sunny.UI.UIStyle.Custom;
            this.btn_JOG_Yred.TabIndex = 0;
            this.btn_JOG_Yred.Text = "Y-";
            this.btn_JOG_Yred.TipsFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_JOG_Yred.Click += new System.EventHandler(this.btn_JOG_Yred_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.num_JOG_Step);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.num_Z_JOG_Speed);
            this.panel2.Controls.Add(this.num_Y_JOG_Speed);
            this.panel2.Controls.Add(this.num_X_JOG_Speed);
            this.panel2.Controls.Add(this.btn_JOG_Change);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(422, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 273);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // num_JOG_Step
            // 
            this.num_JOG_Step.Decimal = 4;
            this.num_JOG_Step.DecimalPlaces = 4;
            this.num_JOG_Step.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_JOG_Step.Location = new System.Drawing.Point(156, 149);
            this.num_JOG_Step.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_JOG_Step.Maximum = 500D;
            this.num_JOG_Step.Minimum = 0D;
            this.num_JOG_Step.MinimumSize = new System.Drawing.Size(100, 0);
            this.num_JOG_Step.Name = "num_JOG_Step";
            this.num_JOG_Step.RectColor = System.Drawing.Color.Black;
            this.num_JOG_Step.ShowText = false;
            this.num_JOG_Step.Size = new System.Drawing.Size(200, 30);
            this.num_JOG_Step.Step = 0.0005D;
            this.num_JOG_Step.Style = Sunny.UI.UIStyle.Custom;
            this.num_JOG_Step.TabIndex = 24;
            this.num_JOG_Step.Text = "uiDoubleUpDown3";
            this.num_JOG_Step.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(33, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "点动步距";
            // 
            // num_Z_JOG_Speed
            // 
            this.num_Z_JOG_Speed.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_Z_JOG_Speed.Location = new System.Drawing.Point(156, 105);
            this.num_Z_JOG_Speed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_Z_JOG_Speed.Maximum = 999999D;
            this.num_Z_JOG_Speed.Minimum = 0D;
            this.num_Z_JOG_Speed.MinimumSize = new System.Drawing.Size(100, 0);
            this.num_Z_JOG_Speed.Name = "num_Z_JOG_Speed";
            this.num_Z_JOG_Speed.RectColor = System.Drawing.Color.Black;
            this.num_Z_JOG_Speed.ShowText = false;
            this.num_Z_JOG_Speed.Size = new System.Drawing.Size(200, 30);
            this.num_Z_JOG_Speed.Style = Sunny.UI.UIStyle.Custom;
            this.num_Z_JOG_Speed.TabIndex = 22;
            this.num_Z_JOG_Speed.Text = "uiDoubleUpDown3";
            this.num_Z_JOG_Speed.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_Y_JOG_Speed
            // 
            this.num_Y_JOG_Speed.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_Y_JOG_Speed.Location = new System.Drawing.Point(156, 60);
            this.num_Y_JOG_Speed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_Y_JOG_Speed.Maximum = 999999D;
            this.num_Y_JOG_Speed.Minimum = 0D;
            this.num_Y_JOG_Speed.MinimumSize = new System.Drawing.Size(100, 0);
            this.num_Y_JOG_Speed.Name = "num_Y_JOG_Speed";
            this.num_Y_JOG_Speed.RectColor = System.Drawing.Color.Black;
            this.num_Y_JOG_Speed.ShowText = false;
            this.num_Y_JOG_Speed.Size = new System.Drawing.Size(200, 30);
            this.num_Y_JOG_Speed.Style = Sunny.UI.UIStyle.Custom;
            this.num_Y_JOG_Speed.TabIndex = 22;
            this.num_Y_JOG_Speed.Text = "uiDoubleUpDown2";
            this.num_Y_JOG_Speed.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_X_JOG_Speed
            // 
            this.num_X_JOG_Speed.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_X_JOG_Speed.Location = new System.Drawing.Point(156, 19);
            this.num_X_JOG_Speed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_X_JOG_Speed.Maximum = 999999D;
            this.num_X_JOG_Speed.Minimum = 0D;
            this.num_X_JOG_Speed.MinimumSize = new System.Drawing.Size(100, 0);
            this.num_X_JOG_Speed.Name = "num_X_JOG_Speed";
            this.num_X_JOG_Speed.RectColor = System.Drawing.Color.Black;
            this.num_X_JOG_Speed.ShowText = false;
            this.num_X_JOG_Speed.Size = new System.Drawing.Size(200, 30);
            this.num_X_JOG_Speed.Style = Sunny.UI.UIStyle.Custom;
            this.num_X_JOG_Speed.TabIndex = 21;
            this.num_X_JOG_Speed.Text = "uiDoubleUpDown1";
            this.num_X_JOG_Speed.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_JOG_Change
            // 
            this.btn_JOG_Change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_JOG_Change.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_JOG_Change.FillColor2 = System.Drawing.Color.DarkGray;
            this.btn_JOG_Change.FillDisableColor = System.Drawing.Color.DarkGray;
            this.btn_JOG_Change.FillHoverColor = System.Drawing.Color.DarkGray;
            this.btn_JOG_Change.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_JOG_Change.ForeColor = System.Drawing.Color.Black;
            this.btn_JOG_Change.ForeDisableColor = System.Drawing.Color.DimGray;
            this.btn_JOG_Change.ForeHoverColor = System.Drawing.Color.Gray;
            this.btn_JOG_Change.ForePressColor = System.Drawing.Color.DimGray;
            this.btn_JOG_Change.ForeSelectedColor = System.Drawing.Color.Silver;
            this.btn_JOG_Change.Location = new System.Drawing.Point(145, 200);
            this.btn_JOG_Change.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_JOG_Change.Name = "btn_JOG_Change";
            this.btn_JOG_Change.Size = new System.Drawing.Size(107, 58);
            this.btn_JOG_Change.Style = Sunny.UI.UIStyle.Custom;
            this.btn_JOG_Change.TabIndex = 20;
            this.btn_JOG_Change.Text = "确认";
            this.btn_JOG_Change.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_JOG_Change.Click += new System.EventHandler(this.btn_JOG_Change_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(33, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "X点动速度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(33, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Z点动速度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(33, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Y点动速度";
            // 
            // btn_JOG_Zred
            // 
            this.btn_JOG_Zred.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_JOG_Zred.FillColor = System.Drawing.Color.Black;
            this.btn_JOG_Zred.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_JOG_Zred.Location = new System.Drawing.Point(270, 4);
            this.btn_JOG_Zred.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_JOG_Zred.Name = "btn_JOG_Zred";
            this.btn_JOG_Zred.Size = new System.Drawing.Size(111, 84);
            this.btn_JOG_Zred.Style = Sunny.UI.UIStyle.Custom;
            this.btn_JOG_Zred.TabIndex = 1;
            this.btn_JOG_Zred.Text = "Z-";
            this.btn_JOG_Zred.TipsFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_JOG_Zred.Click += new System.EventHandler(this.btn_JOG_Zred_Click);
            // 
            // btn_JOG_Zadd
            // 
            this.btn_JOG_Zadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_JOG_Zadd.FillColor = System.Drawing.Color.Black;
            this.btn_JOG_Zadd.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_JOG_Zadd.Location = new System.Drawing.Point(18, 4);
            this.btn_JOG_Zadd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_JOG_Zadd.Name = "btn_JOG_Zadd";
            this.btn_JOG_Zadd.Size = new System.Drawing.Size(111, 84);
            this.btn_JOG_Zadd.Style = Sunny.UI.UIStyle.Custom;
            this.btn_JOG_Zadd.TabIndex = 7;
            this.btn_JOG_Zadd.Text = "Z+";
            this.btn_JOG_Zadd.TipsFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_JOG_Zadd.Click += new System.EventHandler(this.btn_JOG_Zadd_Click);
            // 
            // btn_JOG_Yadd
            // 
            this.btn_JOG_Yadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_JOG_Yadd.FillColor = System.Drawing.Color.Black;
            this.btn_JOG_Yadd.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_JOG_Yadd.Location = new System.Drawing.Point(143, 188);
            this.btn_JOG_Yadd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_JOG_Yadd.Name = "btn_JOG_Yadd";
            this.btn_JOG_Yadd.Size = new System.Drawing.Size(111, 84);
            this.btn_JOG_Yadd.Style = Sunny.UI.UIStyle.Custom;
            this.btn_JOG_Yadd.TabIndex = 2;
            this.btn_JOG_Yadd.Text = "Y+";
            this.btn_JOG_Yadd.TipsFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_JOG_Yadd.Click += new System.EventHandler(this.btn_JOG_Yadd_Click);
            // 
            // btn_JOG_Xadd
            // 
            this.btn_JOG_Xadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_JOG_Xadd.FillColor = System.Drawing.Color.Black;
            this.btn_JOG_Xadd.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_JOG_Xadd.Location = new System.Drawing.Point(18, 97);
            this.btn_JOG_Xadd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_JOG_Xadd.Name = "btn_JOG_Xadd";
            this.btn_JOG_Xadd.Size = new System.Drawing.Size(111, 84);
            this.btn_JOG_Xadd.Style = Sunny.UI.UIStyle.Custom;
            this.btn_JOG_Xadd.TabIndex = 3;
            this.btn_JOG_Xadd.Text = "X+";
            this.btn_JOG_Xadd.TipsFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_JOG_Xadd.Click += new System.EventHandler(this.btn_JOG_Xadd_Click);
            // 
            // btn_JOG_Xred
            // 
            this.btn_JOG_Xred.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_JOG_Xred.FillColor = System.Drawing.Color.Black;
            this.btn_JOG_Xred.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_JOG_Xred.Location = new System.Drawing.Point(270, 97);
            this.btn_JOG_Xred.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_JOG_Xred.Name = "btn_JOG_Xred";
            this.btn_JOG_Xred.Size = new System.Drawing.Size(111, 84);
            this.btn_JOG_Xred.Style = Sunny.UI.UIStyle.Custom;
            this.btn_JOG_Xred.TabIndex = 5;
            this.btn_JOG_Xred.Text = "X-";
            this.btn_JOG_Xred.TipsFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_JOG_Xred.Click += new System.EventHandler(this.btn_JOG_Xred_Click);
            // 
            // btn_JOG_Home
            // 
            this.btn_JOG_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_JOG_Home.FillColor = System.Drawing.Color.Black;
            this.btn_JOG_Home.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_JOG_Home.Location = new System.Drawing.Point(143, 97);
            this.btn_JOG_Home.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_JOG_Home.Name = "btn_JOG_Home";
            this.btn_JOG_Home.Size = new System.Drawing.Size(111, 84);
            this.btn_JOG_Home.Style = Sunny.UI.UIStyle.Custom;
            this.btn_JOG_Home.TabIndex = 4;
            this.btn_JOG_Home.Text = "回零";
            this.btn_JOG_Home.TipsFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_JOG_Home.Click += new System.EventHandler(this.btn_JOG_Home_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(0, 299);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(837, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "点运动控制";
            // 
            // num_Y_Run_Point
            // 
            this.num_Y_Run_Point.Decimal = 4;
            this.num_Y_Run_Point.DecimalPlaces = 4;
            this.num_Y_Run_Point.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_Y_Run_Point.Location = new System.Drawing.Point(191, 56);
            this.num_Y_Run_Point.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_Y_Run_Point.Maximum = 500D;
            this.num_Y_Run_Point.Minimum = 0D;
            this.num_Y_Run_Point.MinimumSize = new System.Drawing.Size(100, 0);
            this.num_Y_Run_Point.Name = "num_Y_Run_Point";
            this.num_Y_Run_Point.RectColor = System.Drawing.Color.Black;
            this.num_Y_Run_Point.ShowText = false;
            this.num_Y_Run_Point.Size = new System.Drawing.Size(190, 30);
            this.num_Y_Run_Point.Step = 0.0005D;
            this.num_Y_Run_Point.Style = Sunny.UI.UIStyle.Custom;
            this.num_Y_Run_Point.TabIndex = 22;
            this.num_Y_Run_Point.Text = "uiDoubleUpDown5";
            this.num_Y_Run_Point.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_X_Run_Point
            // 
            this.num_X_Run_Point.Decimal = 4;
            this.num_X_Run_Point.DecimalPlaces = 4;
            this.num_X_Run_Point.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_X_Run_Point.Location = new System.Drawing.Point(191, 12);
            this.num_X_Run_Point.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_X_Run_Point.Maximum = 500D;
            this.num_X_Run_Point.Minimum = 0D;
            this.num_X_Run_Point.MinimumSize = new System.Drawing.Size(100, 0);
            this.num_X_Run_Point.Name = "num_X_Run_Point";
            this.num_X_Run_Point.RectColor = System.Drawing.Color.Black;
            this.num_X_Run_Point.ShowText = false;
            this.num_X_Run_Point.Size = new System.Drawing.Size(190, 30);
            this.num_X_Run_Point.Step = 0.0005D;
            this.num_X_Run_Point.Style = Sunny.UI.UIStyle.Custom;
            this.num_X_Run_Point.TabIndex = 22;
            this.num_X_Run_Point.Text = "uiDoubleUpDown6";
            this.num_X_Run_Point.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_Z_Run_Point
            // 
            this.num_Z_Run_Point.Decimal = 4;
            this.num_Z_Run_Point.DecimalPlaces = 4;
            this.num_Z_Run_Point.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_Z_Run_Point.Location = new System.Drawing.Point(191, 96);
            this.num_Z_Run_Point.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_Z_Run_Point.Maximum = 500D;
            this.num_Z_Run_Point.Minimum = 0D;
            this.num_Z_Run_Point.MinimumSize = new System.Drawing.Size(100, 0);
            this.num_Z_Run_Point.Name = "num_Z_Run_Point";
            this.num_Z_Run_Point.RectColor = System.Drawing.Color.Black;
            this.num_Z_Run_Point.ShowText = false;
            this.num_Z_Run_Point.Size = new System.Drawing.Size(190, 30);
            this.num_Z_Run_Point.Step = 0.0005D;
            this.num_Z_Run_Point.Style = Sunny.UI.UIStyle.Custom;
            this.num_Z_Run_Point.TabIndex = 23;
            this.num_Z_Run_Point.Text = "uiDoubleUpDown4";
            this.num_Z_Run_Point.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.num_Z_Run_Speed);
            this.panel3.Controls.Add(this.num_Y_Run_Speed);
            this.panel3.Controls.Add(this.num_X_Run_Speed);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.btn_Run_Change);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Location = new System.Drawing.Point(422, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 231);
            this.panel3.TabIndex = 22;
            // 
            // num_Z_Run_Speed
            // 
            this.num_Z_Run_Speed.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_Z_Run_Speed.Location = new System.Drawing.Point(156, 102);
            this.num_Z_Run_Speed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_Z_Run_Speed.Maximum = 999999D;
            this.num_Z_Run_Speed.Minimum = 0D;
            this.num_Z_Run_Speed.MinimumSize = new System.Drawing.Size(100, 0);
            this.num_Z_Run_Speed.Name = "num_Z_Run_Speed";
            this.num_Z_Run_Speed.RectColor = System.Drawing.Color.Black;
            this.num_Z_Run_Speed.ShowText = false;
            this.num_Z_Run_Speed.Size = new System.Drawing.Size(200, 30);
            this.num_Z_Run_Speed.Style = Sunny.UI.UIStyle.Custom;
            this.num_Z_Run_Speed.TabIndex = 48;
            this.num_Z_Run_Speed.Text = "uiDoubleUpDown7";
            this.num_Z_Run_Speed.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_Y_Run_Speed
            // 
            this.num_Y_Run_Speed.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_Y_Run_Speed.Location = new System.Drawing.Point(156, 62);
            this.num_Y_Run_Speed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_Y_Run_Speed.Maximum = 999999D;
            this.num_Y_Run_Speed.Minimum = 0D;
            this.num_Y_Run_Speed.MinimumSize = new System.Drawing.Size(100, 0);
            this.num_Y_Run_Speed.Name = "num_Y_Run_Speed";
            this.num_Y_Run_Speed.RectColor = System.Drawing.Color.Black;
            this.num_Y_Run_Speed.ShowText = false;
            this.num_Y_Run_Speed.Size = new System.Drawing.Size(200, 30);
            this.num_Y_Run_Speed.Style = Sunny.UI.UIStyle.Custom;
            this.num_Y_Run_Speed.TabIndex = 47;
            this.num_Y_Run_Speed.Text = "uiDoubleUpDown8";
            this.num_Y_Run_Speed.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_X_Run_Speed
            // 
            this.num_X_Run_Speed.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_X_Run_Speed.Location = new System.Drawing.Point(156, 21);
            this.num_X_Run_Speed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_X_Run_Speed.Maximum = 999999D;
            this.num_X_Run_Speed.Minimum = 0D;
            this.num_X_Run_Speed.MinimumSize = new System.Drawing.Size(100, 0);
            this.num_X_Run_Speed.Name = "num_X_Run_Speed";
            this.num_X_Run_Speed.RectColor = System.Drawing.Color.Black;
            this.num_X_Run_Speed.ShowText = false;
            this.num_X_Run_Speed.Size = new System.Drawing.Size(200, 30);
            this.num_X_Run_Speed.Style = Sunny.UI.UIStyle.Custom;
            this.num_X_Run_Speed.TabIndex = 46;
            this.num_X_Run_Speed.Text = "uiDoubleUpDown9";
            this.num_X_Run_Speed.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.ForeColor = System.Drawing.SystemColors.Control;
            this.label22.Location = new System.Drawing.Point(33, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(105, 21);
            this.label22.TabIndex = 43;
            this.label22.Text = "X运行速度";
            // 
            // btn_Run_Change
            // 
            this.btn_Run_Change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Run_Change.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Run_Change.FillColor2 = System.Drawing.Color.DarkGray;
            this.btn_Run_Change.FillDisableColor = System.Drawing.Color.DarkGray;
            this.btn_Run_Change.FillHoverColor = System.Drawing.Color.DarkGray;
            this.btn_Run_Change.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Run_Change.ForeColor = System.Drawing.Color.Black;
            this.btn_Run_Change.ForeDisableColor = System.Drawing.Color.DimGray;
            this.btn_Run_Change.ForeHoverColor = System.Drawing.Color.Gray;
            this.btn_Run_Change.ForePressColor = System.Drawing.Color.DimGray;
            this.btn_Run_Change.ForeSelectedColor = System.Drawing.Color.Silver;
            this.btn_Run_Change.Location = new System.Drawing.Point(145, 155);
            this.btn_Run_Change.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Run_Change.Name = "btn_Run_Change";
            this.btn_Run_Change.Size = new System.Drawing.Size(107, 64);
            this.btn_Run_Change.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Run_Change.TabIndex = 19;
            this.btn_Run_Change.Text = "确认";
            this.btn_Run_Change.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Run_Change.Click += new System.EventHandler(this.btn_Run_Change_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.ForeColor = System.Drawing.SystemColors.Control;
            this.label21.Location = new System.Drawing.Point(33, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 21);
            this.label21.TabIndex = 44;
            this.label21.Text = "Z运行速度";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(33, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 21);
            this.label20.TabIndex = 45;
            this.label20.Text = "Y运行速度";
            // 
            // btn_Point_Move
            // 
            this.btn_Point_Move.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Point_Move.FillColor = System.Drawing.Color.Black;
            this.btn_Point_Move.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Point_Move.Location = new System.Drawing.Point(143, 146);
            this.btn_Point_Move.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Point_Move.Name = "btn_Point_Move";
            this.btn_Point_Move.Size = new System.Drawing.Size(111, 64);
            this.btn_Point_Move.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Point_Move.TabIndex = 21;
            this.btn_Point_Move.Text = "移动";
            this.btn_Point_Move.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "X运动坐标点/mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(14, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y运动坐标点/mm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Z运动坐标点/mm";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Start, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Close_System, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_SettingMean, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Stop, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Minimizid_System, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Reset, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(846, 57);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_Start
            // 
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start.FillColor = System.Drawing.Color.Black;
            this.btn_Start.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Start.FillHoverColor = System.Drawing.Color.Lime;
            this.btn_Start.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Start.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Start.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Start.Location = new System.Drawing.Point(3, 3);
            this.btn_Start.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.RectColor = System.Drawing.Color.SpringGreen;
            this.btn_Start.Size = new System.Drawing.Size(54, 50);
            this.btn_Start.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Start.TabIndex = 8;
            this.btn_Start.Text = "启动";
            this.btn_Start.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Close_System
            // 
            this.btn_Close_System.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close_System.FillColor = System.Drawing.Color.Red;
            this.btn_Close_System.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Close_System.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Close_System.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Close_System.FillSelectedColor = System.Drawing.Color.Red;
            this.btn_Close_System.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Close_System.Location = new System.Drawing.Point(789, 3);
            this.btn_Close_System.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Close_System.Name = "btn_Close_System";
            this.btn_Close_System.RectColor = System.Drawing.Color.Red;
            this.btn_Close_System.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Close_System.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Close_System.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Close_System.RectSelectedColor = System.Drawing.Color.Red;
            this.btn_Close_System.Size = new System.Drawing.Size(51, 50);
            this.btn_Close_System.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Close_System.TabIndex = 0;
            this.btn_Close_System.Text = "×";
            this.btn_Close_System.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Close_System.Click += new System.EventHandler(this.btn_Close_System_Click);
            // 
            // btn_SettingMean
            // 
            this.btn_SettingMean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SettingMean.FillColor = System.Drawing.Color.Black;
            this.btn_SettingMean.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SettingMean.Location = new System.Drawing.Point(183, 3);
            this.btn_SettingMean.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_SettingMean.Name = "btn_SettingMean";
            this.btn_SettingMean.Size = new System.Drawing.Size(54, 50);
            this.btn_SettingMean.Style = Sunny.UI.UIStyle.Custom;
            this.btn_SettingMean.TabIndex = 6;
            this.btn_SettingMean.Text = "设置";
            this.btn_SettingMean.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SettingMean.Click += new System.EventHandler(this.btn_SettingMean_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stop.FillColor = System.Drawing.Color.Black;
            this.btn_Stop.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Stop.FillHoverColor = System.Drawing.Color.Red;
            this.btn_Stop.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Stop.FillSelectedColor = System.Drawing.Color.Red;
            this.btn_Stop.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Stop.Location = new System.Drawing.Point(63, 3);
            this.btn_Stop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.RectColor = System.Drawing.Color.Red;
            this.btn_Stop.Size = new System.Drawing.Size(54, 50);
            this.btn_Stop.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Stop.TabIndex = 10;
            this.btn_Stop.Text = "停止";
            this.btn_Stop.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Minimizid_System
            // 
            this.btn_Minimizid_System.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimizid_System.FillColor = System.Drawing.Color.Black;
            this.btn_Minimizid_System.FillColor2 = System.Drawing.Color.Gray;
            this.btn_Minimizid_System.FillHoverColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Minimizid_System.FillPressColor = System.Drawing.Color.LightGray;
            this.btn_Minimizid_System.FillSelectedColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Minimizid_System.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Minimizid_System.Location = new System.Drawing.Point(729, 3);
            this.btn_Minimizid_System.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Minimizid_System.Name = "btn_Minimizid_System";
            this.btn_Minimizid_System.Size = new System.Drawing.Size(52, 50);
            this.btn_Minimizid_System.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Minimizid_System.TabIndex = 1;
            this.btn_Minimizid_System.Text = "-";
            this.btn_Minimizid_System.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Minimizid_System.Click += new System.EventHandler(this.btn_Minimizid_System_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(243, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 51);
            this.panel4.TabIndex = 11;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.FillColor = System.Drawing.Color.Black;
            this.btn_Reset.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Reset.FillHoverColor = System.Drawing.Color.Yellow;
            this.btn_Reset.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Reset.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Reset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Reset.Location = new System.Drawing.Point(123, 3);
            this.btn_Reset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.RectColor = System.Drawing.Color.Yellow;
            this.btn_Reset.Size = new System.Drawing.Size(54, 50);
            this.btn_Reset.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Reset.TabIndex = 12;
            this.btn_Reset.Text = "复位";
            this.btn_Reset.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lab_PLCStatus,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2,
            this.lab_X,
            this.toolStripStatusLabel5,
            this.lab_Y,
            this.toolStripStatusLabel7,
            this.lab_Z,
            this.lab_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 627);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(846, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Silver;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel1.Text = "PLC";
            // 
            // lab_PLCStatus
            // 
            this.lab_PLCStatus.BackColor = System.Drawing.Color.DimGray;
            this.lab_PLCStatus.ForeColor = System.Drawing.Color.White;
            this.lab_PLCStatus.Name = "lab_PLCStatus";
            this.lab_PLCStatus.Size = new System.Drawing.Size(20, 17);
            this.lab_PLCStatus.Text = "-1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Silver;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel2.Text = "X:";
            // 
            // lab_X
            // 
            this.lab_X.ForeColor = System.Drawing.Color.White;
            this.lab_X.Name = "lab_X";
            this.lab_X.Size = new System.Drawing.Size(46, 17);
            this.lab_X.Text = "0.0000";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackColor = System.Drawing.Color.Silver;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(18, 17);
            this.toolStripStatusLabel5.Text = "Y:";
            // 
            // lab_Y
            // 
            this.lab_Y.ForeColor = System.Drawing.Color.White;
            this.lab_Y.Name = "lab_Y";
            this.lab_Y.Size = new System.Drawing.Size(46, 17);
            this.lab_Y.Text = "0.0000";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.BackColor = System.Drawing.Color.Silver;
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(18, 17);
            this.toolStripStatusLabel7.Text = "Z:";
            // 
            // lab_Z
            // 
            this.lab_Z.ForeColor = System.Drawing.Color.White;
            this.lab_Z.Name = "lab_Z";
            this.lab_Z.Size = new System.Drawing.Size(70, 17);
            this.lab_Z.Text = "0.0000      ";
            // 
            // lab_status
            // 
            this.lab_status.Name = "lab_status";
            this.lab_status.Size = new System.Drawing.Size(131, 17);
            this.lab_status.Text = "toolStripStatusLabel4";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.70288F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.29713F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 649);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.num_Y_Run_Point);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.num_X_Run_Point);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.num_Z_Run_Point);
            this.panel1.Controls.Add(this.btn_Point_Move);
            this.panel1.Location = new System.Drawing.Point(9, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 222);
            this.panel1.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_JOG_Zadd);
            this.panel5.Controls.Add(this.btn_JOG_Yred);
            this.panel5.Controls.Add(this.btn_JOG_Home);
            this.panel5.Controls.Add(this.btn_JOG_Zred);
            this.panel5.Controls.Add(this.btn_JOG_Xred);
            this.panel5.Controls.Add(this.btn_JOG_Xadd);
            this.panel5.Controls.Add(this.btn_JOG_Yadd);
            this.panel5.Location = new System.Drawing.Point(9, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(410, 273);
            this.panel5.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 647);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "领先光学运动控制平台";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lab_PLCStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UIButton btn_Start;
        private Sunny.UI.UIButton btn_Close_System;
        private Sunny.UI.UIButton btn_SettingMean;
        private Sunny.UI.UIButton btn_Stop;
        private Sunny.UI.UIButton btn_Minimizid_System;
        private System.Windows.Forms.Panel panel4;
        private Sunny.UI.UIButton btn_Reset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UIButton btn_JOG_Yred;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UIDoubleUpDown num_Z_JOG_Speed;
        private Sunny.UI.UIDoubleUpDown num_Y_JOG_Speed;
        private Sunny.UI.UIDoubleUpDown num_X_JOG_Speed;
        private Sunny.UI.UIButton btn_JOG_Change;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UIButton btn_JOG_Zred;
        private Sunny.UI.UIButton btn_JOG_Zadd;
        private Sunny.UI.UIButton btn_JOG_Yadd;
        private Sunny.UI.UIButton btn_JOG_Xadd;
        private Sunny.UI.UIButton btn_JOG_Xred;
        private Sunny.UI.UIButton btn_JOG_Home;
        private System.Windows.Forms.GroupBox groupBox2;
        private Sunny.UI.UIDoubleUpDown num_Y_Run_Point;
        private Sunny.UI.UIDoubleUpDown num_X_Run_Point;
        private Sunny.UI.UIDoubleUpDown num_Z_Run_Point;
        private System.Windows.Forms.Panel panel3;
        private Sunny.UI.UIDoubleUpDown num_Z_Run_Speed;
        private Sunny.UI.UIDoubleUpDown num_Y_Run_Speed;
        private Sunny.UI.UIDoubleUpDown num_X_Run_Speed;
        private System.Windows.Forms.Label label22;
        private Sunny.UI.UIButton btn_Run_Change;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private Sunny.UI.UIButton btn_Point_Move;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lab_X;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lab_Y;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel lab_Z;
        private Sunny.UI.UIDoubleUpDown num_JOG_Step;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripStatusLabel lab_status;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
    }
}

