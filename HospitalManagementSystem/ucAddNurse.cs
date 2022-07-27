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
        private int update_Index;
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
            lbInvalidInput.Hide();
        }

        private void ClearAllFields()
        {
            txtName.Text = "";
            txtCnic.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtPhoneNo.Text = "";
            txtAddress.Text = "";
            dtpWHstart.Value = DateTime.Today;
            dtpWHend.Value = DateTime.Today;
            txtDuty.Text = "";
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            nudSalary.Value = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucNursesData();
        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {

            String nurse_Name = txtName.Text;
            String nurse_Cnic = txtCnic.Text;
            String nurse_PhoneNumber = txtPhoneNo.Text;
            String nurse_Email = txtEmail.Text;
            String nurse_PAssworsd = txtPassword.Text;
            String nurse_Duty = txtDuty.Text;
            String nurse_Address = txtAddress.Text;
            String nurse_Gender;
            int nurse_Salary = (int)nudSalary.Value;
            DateTime nurseDate_OF_Birth = dtpDateOfBirth.Value;
            DateTime nurse_WHstart = dtpWHstart.Value;
            DateTime nurse_WHend = dtpWHend.Value;
            if (rbtnFemale.Checked)
            {
                nurse_Gender = "Female";
            }
            else
            {
                nurse_Gender = "Male";
            }
            if (Validat.Nurse(nurse_Name, nurse_Cnic, nurse_PhoneNumber, nurse_Email, nurse_PAssworsd,
                nurse_Duty, nurse_Address, nurse_Gender, nurse_Salary,
                nurseDate_OF_Birth, nurse_WHstart, nurse_WHend))
            {
                csNurse nurse = new csNurse(nurse_Name, nurse_Cnic, nurse_PhoneNumber, nurse_Email, nurse_PAssworsd,
                nurse_Duty, nurse_Address, nurse_Gender, nurse_Salary,
                nurseDate_OF_Birth, nurse_WHstart, nurse_WHend);
                if (btnAddInput.Text.Equals("Add"))
                {
                    csHospital.Instence.AddNurse(nurse);
                }
                else
                {
                    csHospital.Instence.UpdateNurse(update_Index, nurse);
                }
                ChangeUC.To_ucNursesData();
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
            lbInvalidInput.Hide();
            btnAddInput.Text = "Add";
        }
        public void UpdateColumnClicked(int index)
        {
            update_Index = index;
            csNurse nurse = csHospital.Instence.getNurses()[index];

            txtName.Text = nurse.Name;
            txtCnic.Text = nurse.Cnic;
            txtPhoneNo.Text = nurse.PhoneNumber;
            txtEmail.Text = nurse.Email;
            txtPassword.Text = nurse.Password;
            txtDuty.Text = nurse.Duty;
            txtAddress.Text = nurse.Address;
            nudSalary.Value = nurse.Salary;
            dtpDateOfBirth.Value = nurse.DateOfBirth;
            dtpWHstart.Value = nurse.WH_Start_Time;
            dtpWHend.Value = nurse.WH_End_Time;

            btnAddInput.Text = "Update";
            if (nurse.Gender.Equals("Male"))
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
