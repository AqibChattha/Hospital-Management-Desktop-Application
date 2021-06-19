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
            dtpWHstart.Value = DateTime.Today;
            dtpWHend.Value = DateTime.Today;
            cbQualification.Text = "";
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            nudSalary.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String nurse_Name = txtName.Text;
            String nurse_Cnic = txtCnic.Text;
            String nurse_PhoneNumber = txtPhoneNo.Text;
            String nurse_Email = txtEmail.Text;
            String nurse_PAssworsd = txtPassword.Text;
            String nurse_Qualification = cbQualification.SelectedItem.ToString();
            String nurse_Address = txtAddress.Text;
            String nurse_Gender;
            if (rbtnFemale.Checked)
            {
                nurse_Gender = "Female";
            }
            else
            {
                nurse_Gender = "Male";
            }
            int nurse_Salary = (int)nudSalary.Value;
            DateTime nurseDate_OF_Birth = dtpDateOfBirth.Value;
            DateTime nurse_WHstart = dtpWHstart.Value;
            DateTime nurse_WHend = dtpWHend.Value;
            MessageBox.Show(nurse_Name + "\n" + nurse_Cnic + "\n"+nurse_PhoneNumber+"\n"+nurse_Qualification+"\n"+nurse_Gender+"\n"+nurse_Salary+"\n"+nurse_WHstart+"\n"+nurse_WHend);
        }
    }
}
