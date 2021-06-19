using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAddReceptionist : UserControl
    {
        private static ucAddReceptionist _instence;
        public static ucAddReceptionist Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAddReceptionist();
                }
                return _instence;
            }
        }
        public ucAddReceptionist()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucReceptionistsData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucReceptionistsData.Instence);
                ucReceptionistsData.Instence.Dock = DockStyle.Fill;
                ucReceptionistsData.Instence.BringToFront();
            }
            else
            {
                ucReceptionistsData.Instence.BringToFront();
            }
        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {
            String receptionist_Name = txtName.Text;
            String receptionist_Cnic = txtCnic.Text;
            String receptionist_PhoneNumber = txtPhoneNo.Text;
            String receptionist_Email = txtEmail.Text;
            String receptionist_PAssworsd = txtPassword.Text;
            String receptionist_Qualification = cbQualification.SelectedItem.ToString();
            String receptionist_Address = txtAddress.Text;
            String receptionist_Gender;
            if (rbtnFemale.Checked)
            {
                receptionist_Gender = "Female";
            }
            else
            {
                receptionist_Gender = "Male";
            }
            int receptionist_Salary = (int)nudSalary.Value;
            DateTime receptionistDate_OF_Birth = dtpDateOfBirth.Value;
            DateTime receptionist_WHstart = dtpWHstart.Value;
            DateTime receptionist_WHend = dtpWHend.Value;

            MessageBox.Show(receptionist_Name + "\n" + receptionist_Cnic + "\n" + receptionist_PhoneNumber + "\n" + receptionist_Qualification + "\n" + receptionist_Gender + "\n" + receptionist_Salary + "\n" + receptionist_WHstart + "\n" + receptionist_WHend);
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
