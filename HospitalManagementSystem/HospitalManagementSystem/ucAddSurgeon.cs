using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAddSurgeon : UserControl
    {
        private static ucAddSurgeon _instence;
        public static ucAddSurgeon Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAddSurgeon();
                }
                return _instence;
            }
        }
        public ucAddSurgeon()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucSurgeonsData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucSurgeonsData.Instence);
                ucSurgeonsData.Instence.Dock = DockStyle.Fill;
                ucSurgeonsData.Instence.BringToFront();
            }
            else
            {
                ucSurgeonsData.Instence.BringToFront();
            }
        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {
            String surgeon_Name = txtName.Text;
            String surgeon_Cnic = txtCnic.Text;
            String surgeon_PhoneNumber = txtPhoneNo.Text;
            String surgeon_Email = txtEmail.Text;
            String surgeon_PAssworsd = txtPassword.Text;
            String surgeon_Qualification = cbQualification.SelectedItem.ToString();
            String surgeon_Address = txtAddress.Text;
            String surgeon_Gender;
            if (rbtnFemale.Checked)
            {
                surgeon_Gender = "Female";
            }
            else
            {
                surgeon_Gender = "Male";
            }
            int surgeon_Salary = (int)nudSalary.Value;
            DateTime surgeonDate_OF_Birth = dtpDateOfBirth.Value;
            DateTime surgeon_WHstart = dtpWHstart.Value;
            DateTime surgeon_WHend = dtpWHend.Value;

            MessageBox.Show(surgeon_Name + "\n" + surgeon_Cnic + "\n" + surgeon_PhoneNumber + "\n" + surgeon_Qualification + "\n" + surgeon_Gender + "\n" + surgeon_Salary + "\n" + surgeon_WHstart + "\n" + surgeon_WHend);
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
