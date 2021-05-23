using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAddPharmacist : UserControl
    {
        private static ucAddPharmacist _instence;
        public static ucAddPharmacist Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAddPharmacist();
                }
                return _instence;
            }
        }
        public ucAddPharmacist()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtCnic.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtPhoneNo.Text = "";
            txtAddress.Text = "";
            cbDepartment.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            cbDepartment.Text = "";
            cbQualification.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            nupSalary.Value = 0;
        }
    }
}
