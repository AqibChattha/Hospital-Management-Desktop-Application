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
        private int update_Index;
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
            LoadComboBox(csHospital.Instence.getDepartments(), csHospital.Instence.getSurgeonQualifications(), csHospital.Instence.getSurgeonSpecializations());
            lbInvalidInput.Hide();
        }

        private void LoadComboBox(List<String> d, List<String> q, List<String> s)
        {
            cbDepartment.Items.Clear();
            cbQualification.Items.Clear();
            cbSpecialization.Items.Clear();
            for (int i = 0; i < d.Count; i++)
            {
                cbDepartment.Items.Add(d[i]);
            }
            for (int i = 0; i < q.Count; i++)
            {
                cbQualification.Items.Add(q[i]);
            }
            for (int i = 0; i < s.Count; i++)
            {
                cbSpecialization.Items.Add(s[i]);
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
            cbDepartment.Text = "";
            cbQualification.Text = "";
            cbSpecialization.Text = "";
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            nudSalary.Value = 0;
            nudEcperiance.Value = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucSurgeonsData();
        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {
            String surgeon_Name = txtName.Text;
            String surgeon_Cnic = txtCnic.Text;
            String surgeon_PhoneNumber = txtPhoneNo.Text;
            String surgeon_Email = txtEmail.Text;
            String surgeon_PAssworsd = txtPassword.Text;
            String surgeon_Qualification = "";
            String surgeon_Depaartment = "";
            String surgeon_Specialization = "";
            if (cbDepartment.SelectedItem == null || cbQualification.SelectedItem == null || cbSpecialization.SelectedItem == null)
            { }
            else
            {
                surgeon_Qualification = cbQualification.SelectedItem.ToString();
                surgeon_Depaartment = cbDepartment.SelectedItem.ToString();
                surgeon_Specialization = cbSpecialization.SelectedItem.ToString();
            }
            int surgeon_Experience = (int)nudEcperiance.Value;
            String surgeon_Address = txtAddress.Text;
            int surgeon_Salary = (int)nudSalary.Value;
            DateTime surgeonDate_OF_Birth = dtpDateOfBirth.Value;
            DateTime surgeon_WHstart = dtpWHstart.Value;
            DateTime surgeon_WHend = dtpWHend.Value;
            String surgeon_Gender = "";
            if (rbtnFemale.Checked)
            {
                surgeon_Gender = "Female";
            }
            else
            {
                surgeon_Gender = "Male";
            }


            if (Validat.Surgeon(surgeon_Name, surgeon_Cnic, surgeon_PhoneNumber, surgeon_Email, surgeon_PAssworsd,
                surgeon_Qualification, surgeon_Depaartment, surgeon_Specialization, surgeon_Address, surgeon_Gender, surgeon_Salary,
                surgeonDate_OF_Birth, surgeon_WHstart, surgeon_WHend))
            {
                csSurgeon surgeon = new csSurgeon(surgeon_Name, surgeon_Cnic, surgeon_PhoneNumber, surgeon_Email, surgeon_PAssworsd,
                surgeon_Qualification, surgeon_Depaartment, surgeon_Specialization, surgeon_Experience, surgeon_Address, surgeon_Gender, surgeon_Salary,
                surgeonDate_OF_Birth, surgeon_WHstart, surgeon_WHend);
                if (btnAddInput.Text.Equals("Add"))
                {
                    csHospital.Instence.AddSurgeon(surgeon);
                }
                else
                {
                    csHospital.Instence.UpdateSurgeon(update_Index, surgeon);
                }
                ChangeUC.To_ucSurgeonsData();
            }
            else
            {
                lbInvalidInput.Show();
            }
        }
        public void RefreshUC()
        {
            LoadComboBox(csHospital.Instence.getDepartments(), csHospital.Instence.getSurgeonQualifications(), csHospital.Instence.getSurgeonSpecializations());
            ClearAllFields();
            lbInvalidInput.Hide();
            btnAddInput.Text = "Add";
        }
        private void btnClearInput_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        public void UpdateColumnClicked(int index)
        {
            update_Index = index;
            lbInvalidInput.Hide();
            btnAddInput.Text = "Update";

            csSurgeon surgeon = csHospital.Instence.getSurgeons()[index];
            txtName.Text = surgeon.Name;
            txtCnic.Text = surgeon.Cnic;
            txtPhoneNo.Text = surgeon.PhoneNumber;
            txtEmail.Text = surgeon.Email;
            txtPassword.Text = surgeon.Password;
            cbQualification.SelectedItem = surgeon.Qualification;
            cbDepartment.SelectedItem = surgeon.Department;
            cbSpecialization.SelectedItem = surgeon.Specialization;
            txtAddress.Text = surgeon.Address;
            nudSalary.Value = surgeon.Salary;
            nudEcperiance.Value = surgeon.Experience;
            dtpDateOfBirth.Value = surgeon.DateOfBirth;
            dtpWHstart.Value = surgeon.WH_Start_Time;
            dtpWHend.Value = surgeon.WH_End_Time;
            if (surgeon.Gender.Equals("Male"))
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
