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
        private int update_Index;
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
            LoadComboBox(csHospital.Instence.getLabTechrQualifications());
            lbInvalidInput.Hide();
        }
        private void LoadComboBox(List<String> d)
        {

            cbQualification.Items.Clear();
            for (int i = 0; i < d.Count; i++)
            {
                cbQualification.Items.Add(d[i]);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucLaboratoryTechniciansData();
        }

        private void ClearAllFields()
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
        private void btnAddInput_Click(object sender, EventArgs e)
        {
            String LabTech_Name = txtName.Text;
            String LabTech_Cnic = txtCnic.Text;
            String LabTech_PhoneNumber = txtPhoneNo.Text;
            String LabTech_Email = txtEmail.Text;
            String LabTech_PAssworsd = txtPassword.Text;
            String LabTech_Qualification = "";
            if (cbQualification.SelectedItem == null)
            { }
            else
            {
                LabTech_Qualification = cbQualification.SelectedItem.ToString();
            }
            String LabTech_Address = txtAddress.Text;
            int LabTech_Salary = (int)nudSalary.Value;
            DateTime LabTechDate_OF_Birth = dtpDateOfBirth.Value;
            DateTime LabTech_WHstart = dtpWHstart.Value;
            DateTime LabTech_WHend = dtpWHend.Value;
            String LabTech_Gender;
            if (rbtnFemale.Checked)
            {
                LabTech_Gender = "Female";
            }
            else
            {
                LabTech_Gender = "Male";
            }
            if (Validat.LabTech_Pharmacist(LabTech_Name, LabTech_Cnic, LabTech_PhoneNumber, LabTech_Email, LabTech_PAssworsd,
                LabTech_Qualification, csHospital.Instence.getLabTechrQualifications(), LabTech_Address, LabTech_Gender, LabTech_Salary,
                LabTechDate_OF_Birth, LabTech_WHstart, LabTech_WHend))
            {
                csLabTechnician LabTech = new csLabTechnician(LabTech_Name, LabTech_Cnic, LabTech_PhoneNumber, LabTech_Email, LabTech_PAssworsd,
                LabTech_Qualification, LabTech_Address, LabTech_Gender, LabTech_Salary,
                LabTechDate_OF_Birth, LabTech_WHstart, LabTech_WHend);
                if (btnAddInput.Text.Equals("Add"))
                {
                    csHospital.Instence.AddLabTech(LabTech);
                }
                else
                {
                    csHospital.Instence.UpdateLabTech(update_Index, LabTech);
                }
                ChangeUC.To_ucLaboratoryTechniciansData();
            }
            else
            {
                lbInvalidInput.Show();
            }
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
        public void RefreshUC()
        {
            ClearAllFields();
            LoadComboBox(csHospital.Instence.getLabTechrQualifications());
            lbInvalidInput.Hide();
            btnAddInput.Text = "Add";
        }

        public void UpdateColumnClicked(int index)
        {
            update_Index = index;
            lbInvalidInput.Hide();
            csLabTechnician getLabTech = csHospital.Instence.getLabTech()[index];

            txtName.Text = getLabTech.Name;
            txtCnic.Text = getLabTech.Cnic;
            txtPhoneNo.Text = getLabTech.PhoneNumber;
            txtEmail.Text = getLabTech.Email;
            txtPassword.Text = getLabTech.Password;
            cbQualification.SelectedItem = getLabTech.Qualification;
            txtAddress.Text = getLabTech.Address;
            nudSalary.Value = getLabTech.Salary;
            dtpDateOfBirth.Value = getLabTech.DateOfBirth;
            dtpWHstart.Value = getLabTech.WH_Start_Time;
            dtpWHend.Value = getLabTech.WH_End_Time;

            btnAddInput.Text = "Update";
            if (getLabTech.Gender.Equals("Male"))
            {
                rbtnMale.Checked = true;
            }
            else
            {
                rbtnFemale.Checked = true;
            }
        }
    }
}
