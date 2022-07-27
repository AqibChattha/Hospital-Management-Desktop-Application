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
        private int update_Index;
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
            LoadComboBox(csHospital.Instence.getPharmacistrQualifications());
            lbInvalidInput.Hide();
        }
        private void LoadComboBox(List<String> q)
        {
            cbQualification.Items.Clear();
            for (int i = 0; i < q.Count; i++)
            {
                cbQualification.Items.Add(q[i]);
            }
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucPharmacistData();
        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {
            String pharmacist_Name = txtName.Text;
            String pharmacist_Cnic = txtCnic.Text;
            String pharmacist_PhoneNumber = txtPhoneNo.Text;
            String pharmacist_Email = txtEmail.Text;
            String pharmacist_PAssworsd = txtPassword.Text;
            String pharmacist_Qualification = "";
            if (cbQualification.SelectedItem == null)
            { }
            else
            {
                pharmacist_Qualification = cbQualification.SelectedItem.ToString();
            }
            String pharmacist_Address = txtAddress.Text;
            int pharmacist_Salary = (int)nudSalary.Value;
            DateTime pharmacistDate_OF_Birth = dtpDateOfBirth.Value;
            DateTime pharmacist_WHstart = dtpWHstart.Value;
            DateTime pharmacist_WHend = dtpWHend.Value;
            String pharmacist_Gender = "";
            if (rbtnFemale.Checked)
            {
                pharmacist_Gender = "Female";
            }
            else
            {
                pharmacist_Gender = "Male";
            }
            if (Validat.LabTech_Pharmacist(pharmacist_Name, pharmacist_Cnic, pharmacist_PhoneNumber, pharmacist_Email, pharmacist_PAssworsd,
                pharmacist_Qualification, csHospital.Instence.getPharmacistrQualifications(), pharmacist_Address, pharmacist_Gender, pharmacist_Salary,
                pharmacistDate_OF_Birth, pharmacist_WHstart, pharmacist_WHend))
            {
                csPharmacist Pharmacist = new csPharmacist(pharmacist_Name, pharmacist_Cnic, pharmacist_PhoneNumber, pharmacist_Email, pharmacist_PAssworsd,
                pharmacist_Qualification, pharmacist_Address, pharmacist_Gender, pharmacist_Salary,
                pharmacistDate_OF_Birth, pharmacist_WHstart, pharmacist_WHend);
                if (btnAddInput.Text.Equals("Add"))
                {
                    csHospital.Instence.AddPharmacist(Pharmacist);
                }
                else
                {
                    csHospital.Instence.UpdatePharmacist(update_Index, Pharmacist);
                }
                ChangeUC.To_ucPharmacistData();
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
            LoadComboBox(csHospital.Instence.getPharmacistrQualifications());
            lbInvalidInput.Hide();
            btnAddInput.Text = "Add";
        }

        public void UpdateColumnClicked(int index)
        {
            update_Index = index;
            lbInvalidInput.Hide();
            csPharmacist getPharmacist = csHospital.Instence.getPharmacist()[index];

            txtName.Text = getPharmacist.Name;
            txtCnic.Text = getPharmacist.Cnic;
            txtPhoneNo.Text = getPharmacist.PhoneNumber;
            txtEmail.Text = getPharmacist.Email;
            txtPassword.Text = getPharmacist.Password;
            cbQualification.SelectedItem = getPharmacist.Qualification;
            txtAddress.Text = getPharmacist.Address;
            nudSalary.Value = getPharmacist.Salary;
            dtpDateOfBirth.Value = getPharmacist.DateOfBirth;
            dtpWHstart.Value = getPharmacist.WH_Start_Time;
            dtpWHend.Value = getPharmacist.WH_End_Time;

            btnAddInput.Text = "Update";
            if (getPharmacist.Gender.Equals("Male"))
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
