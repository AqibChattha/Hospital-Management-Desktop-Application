using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAddLaboratoryTechnician : UserControl
    {
        private static ucAddLaboratoryTechnician _instence;
        public static ucAddLaboratoryTechnician Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAddLaboratoryTechnician();
                }
                return _instence;
            }
        }
        public ucAddLaboratoryTechnician()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucLaboratoryTechniciansData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucLaboratoryTechniciansData.Instence);
                ucLaboratoryTechniciansData.Instence.Dock = DockStyle.Fill;
                ucLaboratoryTechniciansData.Instence.BringToFront();
            }
            else
            {
                ucLaboratoryTechniciansData.Instence.BringToFront();
            }
        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {
            String LabTech_Name = txtName.Text;
            String LabTech_Cnic = txtCnic.Text;
            String LabTech_PhoneNumber = txtPhoneNo.Text;
            String LabTech_Email = txtEmail.Text;
            String LabTech_PAssworsd = txtPassword.Text;
            String LabTech_Qualification = cbQualification.SelectedItem.ToString();
            String LabTech_Address = txtAddress.Text;
            String LabTech_Gender;
            if (rbtnFemale.Checked)
            {
                LabTech_Gender = "Female";
            }
            else
            {
                LabTech_Gender = "Male";
            }
            int LabTech_Salary = (int)nudSalary.Value;
            DateTime LabTechDate_OF_Birth = dtpDateOfBirth.Value;
            DateTime LabTech_WHstart = dtpWHstart.Value;
            DateTime LabTech_WHend = dtpWHend.Value;
           
            MessageBox.Show(LabTech_Name + "\n" + LabTech_Cnic + "\n" + LabTech_PhoneNumber + "\n" + LabTech_Qualification + "\n" + LabTech_Gender + "\n" + LabTech_Salary + "\n" + LabTech_WHstart + "\n" + LabTech_WHend);
           
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
