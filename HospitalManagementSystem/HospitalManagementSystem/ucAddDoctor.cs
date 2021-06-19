using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAddDoctor : UserControl
    {
        private static ucAddDoctor _instence;
        public static ucAddDoctor Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAddDoctor();
                }
                return _instence;
            }
        }
        public ucAddDoctor()
        {
            InitializeComponent();
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtCnic.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtPhoneNo.Text = "";
            txtAddress.Text = "";
            dtpWHend.Value = DateTime.Today;
            dtpWHstart.Value =DateTime.Today;
            cbDepartment.Text = "";
            cbQualification.Text = "";
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            nudSalary.Value = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucDoctorsData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucDoctorsData.Instence);
                ucDoctorsData.Instence.Dock = DockStyle.Fill;
                ucDoctorsData.Instence.BringToFront();
            }
            else
            {
                ucDoctorsData.Instence.BringToFront();
            }
        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {
            String doctor_Name = txtName.Text;
            String doctor_Cnic = txtCnic.Text;
            String doctor_PhoneNumber = txtPhoneNo.Text;
            String doctor_Email = txtEmail.Text;
            String doctor_PAssworsd = txtPassword.Text;
            String doctor_Qualification = cbQualification.SelectedItem.ToString();
            String doctor_Depaartment = cbDepartment.SelectedItem.ToString();
            String doctor_Address = txtAddress.Text;
            String doctor_Gender;
            if (rbtnFemale.Checked)
            {
                doctor_Gender = "Female";
            }
            else
            {
                doctor_Gender = "Male";
            }
            int doctor_Salary = (int)nudSalary.Value;
            DateTime doctorDate_OF_Birth = dtpDateOfBirth.Value;
            DateTime doctor_WHstart = dtpWHstart.Value;
            DateTime doctor_WHend = dtpWHend.Value;

            MessageBox.Show(doctor_Name + "\n" + doctor_Cnic + "\n" + doctor_PhoneNumber + "\n" + doctor_Qualification + "\n" + doctor_Gender + "\n" + doctor_Salary + "\n" + doctor_WHstart + "\n" + doctor_WHend);
        }
    }
}
