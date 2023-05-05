﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WY_App
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();           
        }

        private void btn_Close_System_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(bunifuCustomTextbox2.Text.Contains("toptics888"))
            {
                this.Close();               
                ParamSettings paramSettings = new ParamSettings();
                paramSettings.ShowDialog();
            }
            else
            {               
                MessageBox.Show("密码错误");
            }
            
        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {
            if(this.bunifuCustomTextbox2.Text.Length==10)
            {
                btn_login.Focus();
            }
        }
    }
}
