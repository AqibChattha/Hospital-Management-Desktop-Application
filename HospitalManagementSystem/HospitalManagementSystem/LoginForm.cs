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
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmailField.Text.Equals(""))
            {
                label3.Text = "Empty Email";

            }
            else
            {
                label3.Text = "";
                
            }
            if (txtPasswordField.Text.Equals(""))
            {
                label4.Text = "Empty Password";
            }
            else
            {
               
                label4.Text = "";
            }
            
        }

        private void chboxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxPass.Checked == true) {
               
                txtPasswordField.UseSystemPasswordChar = false;
            }
            else
            {
                txtPasswordField.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
