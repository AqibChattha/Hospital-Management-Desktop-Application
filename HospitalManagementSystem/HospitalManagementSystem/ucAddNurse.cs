using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAddNurse : UserControl
    {
        private static ucAddNurse _instence;
        public static ucAddNurse Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAddNurse();
                }
                return _instence;
            }
        }
        public ucAddNurse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtCnic.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtPhoneNo.Text = "";
            txtAddress.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            cbDepartment.Text = "";
            cbQualification.Text = "";
            cbNurseType.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            nupSalary.Value = 0;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
