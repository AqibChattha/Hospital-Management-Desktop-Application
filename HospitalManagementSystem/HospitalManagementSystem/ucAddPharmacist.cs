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

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (!MainForn.main_Panel.Controls.Contains(ucPharmacistData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucPharmacistData.Instence);
                ucPharmacistData.Instence.Dock = DockStyle.Fill;
                ucPharmacistData.Instence.BringToFront();
            }
            else
            {
                ucPharmacistData.Instence.BringToFront();
            }
        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {
            String pharmacist_Name = txtName.Text;
            String pharmacist_Cnic = txtCnic.Text;
            String pharmacist_PhoneNumber = txtPhoneNo.Text;
            String pharmacist_Email = txtEmail.Text;
            String pharmacist_PAssworsd = txtPassword.Text;
            String pharmacist_Qualification = cbQualification.SelectedItem.ToString();
            String pharmacist_Address = txtAddress.Text;
            String pharmacist_Gender;
            if (rbtnFemale.Checked)
            {
                pharmacist_Gender = "Female";
            }
            else
            {
                pharmacist_Gender = "Male";
            }
            int pharmacist_Salary = (int)nudSalary.Value;
            DateTime pharmacistDate_OF_Birth = dtpDateOfBirth.Value;
            DateTime pharmacist_WHstart = dtpWHstart.Value;
            DateTime pharmacist_WHend = dtpWHend.Value;

            MessageBox.Show(pharmacist_Name + "\n" + pharmacist_Cnic + "\n" + pharmacist_PhoneNumber + "\n" + pharmacist_Qualification + "\n" + pharmacist_Gender + "\n" + pharmacist_Salary + "\n" + pharmacist_WHstart + "\n" + pharmacist_WHend);
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
            dtpWHstart.Value = DateTime.Today;
            cbQualification.Text = "";
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            nudSalary.Value = 0;
        }
    }
}
