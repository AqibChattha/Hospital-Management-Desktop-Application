using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();

            label3.Text = "";

            //for removing the default mouse hover effect
            rbtnLogin.FlatAppearance.MouseOverBackColor = rbtnLogin.BackColor;
            rbtnLogin.BackColorChanged += (s, e) => {
                rbtnLogin.FlatAppearance.MouseOverBackColor = rbtnLogin.BackColor;
            };
            rbtnExit.FlatAppearance.MouseOverBackColor = rbtnExit.BackColor;
            rbtnExit.BackColorChanged += (s, e) => {
                rbtnExit.FlatAppearance.MouseOverBackColor = rbtnExit.BackColor;
            };

            btnHidePassword.FlatAppearance.BorderSize = 0;
            btnShowPassword.FlatAppearance.BorderSize = 0;
            btnHidePassword.Visible = false;
        }

        private void Login()
        {
            if (txtEmailField.Text.Equals("admin") && txtPasswordField.Text.Equals("admin"))
            {
                this.Hide();
                MainForn mainForn = new MainForn();
                mainForn.ShowDialog();
                csHospital.SaveData();
                this.Close();
            }
            else
            {
                label3.Text = "Invalid Credentials";
            }
        }

        private void rbtnLogin_Click(object sender, EventArgs e)
        {
            label4.Focus();
            Login();
        }

        private void rbtnLogin_MouseEnter(object sender, EventArgs e)
        {
            rbtnLogin.BorderSize = 0;
            rbtnLogin.BackColor = Color.FromArgb(0, 156, 208);
            rbtnLogin.ForeColor = Color.White;
        }

        private void rbtnLogin_MouseLeave(object sender, EventArgs e)
        {
            rbtnLogin.BorderSize = 1;
            rbtnLogin.BackColor = Color.FromArgb(250, 249, 246);
            rbtnLogin.ForeColor = Color.FromArgb(0, 156, 208);
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            label4.Focus();
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            label4.Focus();
            txtPasswordField.UseSystemPasswordChar = false;
            btnShowPassword.Visible = false;
            btnHidePassword.Visible = true;
            SendKeys.Send("{TAB}");
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            label4.Focus();
            txtPasswordField.UseSystemPasswordChar = true;
            btnHidePassword.Visible = false;
            btnShowPassword.Visible = true;
            SendKeys.Send("{TAB}");
        }

        private void rbtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void rbtnExit_MouseEnter(object sender, EventArgs e)
        {
            rbtnExit.BorderSize = 0;
            rbtnExit.BackColor = Color.FromArgb(0, 156, 208);
            rbtnExit.ForeColor = Color.White;
        }

        private void rbtnExit_MouseLeave(object sender, EventArgs e)
        {
            rbtnExit.BorderSize = 1;
            rbtnExit.BackColor = Color.FromArgb(250, 249, 246);
            rbtnExit.ForeColor = Color.FromArgb(0, 156, 208);
        }

        private void txtEmailField_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");        
            }else if (!label3.Equals(""))
            {
                label3.Text = "";
            }
        }

        private void txtPasswordField_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmailField.Text.Equals(""))
                {
                    SendKeys.Send("+{TAB}");
                }
                else
                {
                    Login();
                }
            }else if (!label3.Equals(""))
            {
                label3.Text = "";
            }
        }
    }
}
