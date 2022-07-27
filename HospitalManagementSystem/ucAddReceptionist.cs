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
        private int update_Index;
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
            dtpWHend.Value = DateTime.Today;
            dtpWHstart.Value = DateTime.Today;
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            nudSalary.Value = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucReceptionistsData();
        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {
            String receptionist_Name = txtName.Text;
            String receptionist_Cnic = txtCnic.Text;
            String receptionist_PhoneNumber = txtPhoneNo.Text;
            String receptionist_Email = txtEmail.Text;
            String receptionist_PAssworsd = txtPassword.Text;
            String receptionist_Address = txtAddress.Text;
            int receptionist_Salary = (int)nudSalary.Value;
            DateTime receptionistDate_OF_Birth = dtpDateOfBirth.Value;
            DateTime receptionist_WHstart = dtpWHstart.Value;
            DateTime receptionist_WHend = dtpWHend.Value;
            String receptionist_Gender;
            if (rbtnFemale.Checked)
            {
                receptionist_Gender = "Female";
            }
            else
            {
                receptionist_Gender = "Male";
            }
            if (Validat.Receptionist(receptionist_Name, receptionist_Cnic, receptionist_PhoneNumber, receptionist_Email, receptionist_PAssworsd,
                receptionist_Address, receptionist_Gender, receptionist_Salary, receptionistDate_OF_Birth, receptionist_WHstart, receptionist_WHend))
            {
                csReceptionist receptionist = new csReceptionist(receptionist_Name, receptionist_Cnic, receptionist_PhoneNumber, receptionist_Email, receptionist_PAssworsd,
                receptionist_Address, receptionist_Gender, receptionist_Salary, receptionistDate_OF_Birth, receptionist_WHstart, receptionist_WHend);
                if (btnAddInput.Text.Equals("Add"))
                {
                    csHospital.Instence.AddReceptionist(receptionist);
                }
                else
                {
                    csHospital.Instence.UpdateReceptionist(update_Index, receptionist);
                }
                ChangeUC.To_ucReceptionistsData();
            }
            else
            {
                lbInvalidInput.Show();
            }
        }
        public void RefreshUC()
        {
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

            csReceptionist receptionist = csHospital.Instence.getReceptionists()[index];
            txtName.Text = receptionist.Name;
            txtCnic.Text = receptionist.Cnic;
            txtPhoneNo.Text = receptionist.PhoneNumber;
            txtEmail.Text = receptionist.Email;
            txtPassword.Text = receptionist.Password;
            txtAddress.Text = receptionist.Address;
            nudSalary.Value = receptionist.Salary;
            dtpDateOfBirth.Value = receptionist.DateOfBirth;
            dtpWHstart.Value = receptionist.WH_Start_Time;
            dtpWHend.Value = receptionist.WH_End_Time;
            if (receptionist.Gender.Equals("Male"))
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
