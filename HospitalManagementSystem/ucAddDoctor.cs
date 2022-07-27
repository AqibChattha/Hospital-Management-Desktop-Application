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
        private int update_Index;

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
            LoadComboBox(csHospital.Instence.getDepartments(), csHospital.Instence.getDoctorQualifications());
            lbInvalidInput.Hide();
        }

        private void LoadComboBox(List<String> d, List<String> q)
        {
            cbDepartment.Items.Clear();
            cbQualification.Items.Clear();
            for (int i = 0; i < d.Count; i++)
            {
                cbDepartment.Items.Add(d[i]);
            }
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
            cbDepartment.Text = "";
            cbQualification.Text = "";
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            nudSalary.Value = 0;
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucDoctorsData();
        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {
            String doctor_Name = txtName.Text;
            String doctor_Cnic = txtCnic.Text;
            String doctor_PhoneNumber = txtPhoneNo.Text;
            String doctor_Email = txtEmail.Text;
            String doctor_PAssworsd = txtPassword.Text;
            String doctor_Qualification = "";
            String doctor_Depaartment = "";
            if (cbDepartment.SelectedItem == null || cbQualification.SelectedItem == null)
            { }
            else
            {
                doctor_Qualification = cbQualification.SelectedItem.ToString();
                doctor_Depaartment = cbDepartment.SelectedItem.ToString();
            }
            String doctor_Address = txtAddress.Text;
            int doctor_Salary = (int)nudSalary.Value;
            DateTime doctorDate_OF_Birth = dtpDateOfBirth.Value;
            DateTime doctor_WHstart = dtpWHstart.Value;
            DateTime doctor_WHend = dtpWHend.Value;
            String doctor_Gender;
            if (rbtnFemale.Checked)
            {
                doctor_Gender = "Female";
            }
            else
            {
                doctor_Gender = "Male";
            }
            if (Validat.Doctor(doctor_Name, doctor_Cnic, doctor_PhoneNumber, doctor_Email, doctor_PAssworsd,
                doctor_Qualification, doctor_Depaartment, doctor_Address, doctor_Gender, doctor_Salary,
                doctorDate_OF_Birth, doctor_WHstart, doctor_WHend))
            {
                csDoctor doctor = new csDoctor(doctor_Name, doctor_Cnic, doctor_PhoneNumber, doctor_Email, doctor_PAssworsd,
                doctor_Qualification, doctor_Depaartment, doctor_Address, doctor_Gender, doctor_Salary,
                doctorDate_OF_Birth, doctor_WHstart, doctor_WHend);
                if (btnAddInput.Text.Equals("Add"))
                {
                    csHospital.Instence.AddDoctor(doctor);
                }
                else
                {
                    csHospital.Instence.UpdateDoctor(update_Index, doctor);
                }
                ChangeUC.To_ucDoctorsData();
            }
            else
            {
                lbInvalidInput.Show();
            }
        }
        public void RefreshUC()
        {
            LoadComboBox(csHospital.Instence.getDepartments(), csHospital.Instence.getDoctorQualifications());
            ClearAllFields();
            lbInvalidInput.Hide();
            btnAddInput.Text = "Add";
        }
        public void UpdateColumnClicked(int index)
        {
            update_Index = index;
            lbInvalidInput.Hide();
            btnAddInput.Text = "Update";

            csDoctor doc = csHospital.Instence.getDoctors()[index];
            txtName.Text = doc.Name;
            txtCnic.Text = doc.Cnic;
            txtPhoneNo.Text = doc.PhoneNumber;
            txtEmail.Text = doc.Email;
            txtPassword.Text = doc.Password;
            cbQualification.SelectedItem = doc.Qualification;
            cbDepartment.SelectedItem = doc.Department;
            txtAddress.Text = doc.Address;
            nudSalary.Value = doc.Salary;
            dtpDateOfBirth.Value = doc.DateOfBirth;
            dtpWHstart.Value = doc.WH_Start_Time;
            dtpWHend.Value = doc.WH_End_Time;
            if (doc.Gender.Equals("Male"))
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
