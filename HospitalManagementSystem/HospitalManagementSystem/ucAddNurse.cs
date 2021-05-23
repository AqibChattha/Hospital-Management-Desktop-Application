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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucNursesData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucNursesData.Instence);
                ucNursesData.Instence.Dock = DockStyle.Fill;
                ucNursesData.Instence.BringToFront();
            }
            else
            {
                ucNursesData.Instence.BringToFront();
            }
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
    }
}
