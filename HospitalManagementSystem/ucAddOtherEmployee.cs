using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAddOtherEmployee : UserControl
    {
        private int update_Index;
        private static ucAddOtherEmployee _instence;
        public static ucAddOtherEmployee Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAddOtherEmployee();
                }
                return _instence;
            }
        }
        public ucAddOtherEmployee()
        {
            InitializeComponent();
            LoadComboBox(csHospital.Instence.getOtherStaffTypes());
            lbInvalidInput.Hide();
        }
        private void LoadComboBox(List<String> t)
        {
            cbType.Items.Clear();
            for (int i = 0; i < t.Count; i++)
            {
                cbType.Items.Add(t[i]);
            }
        }
        private void ClearAllFields()
        {
            txtName.Text = "";
            txtCnic.Text = "";
            txtPhoneNo.Text = "";
            txtAddress.Text = "";
            cbType.Text = "";
            dtpWHend.Value = DateTime.Today;
            dtpWHstart.Value = DateTime.Today;
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            nudSalary.Value = 0;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucOtherStaffData();
        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {
            String othEmp_Name = txtName.Text;
            String othEmp_Cnic = txtCnic.Text;
            String othEmp_PhoneNumber = txtPhoneNo.Text;
            String othEmp_Type = "";
            if (cbType.SelectedItem == null)
            { }
            else
            {
                othEmp_Type = cbType.SelectedItem.ToString();
            }
            String othEmp_Address = txtAddress.Text;
            int othEmp_Salary = (int)nudSalary.Value;
            DateTime othEmpDate_OF_Birth = dtpDateOfBirth.Value;
            DateTime othEmp_WHstart = dtpWHstart.Value;
            DateTime othEmp_WHend = dtpWHend.Value;
            String othEmp_Gender;
            if (rbtnFemale.Checked)
            {
                othEmp_Gender = "Female";
            }
            else
            {
                othEmp_Gender = "Male";
            }
            if (Validat.OtherStaff(othEmp_Name, othEmp_Cnic, othEmp_PhoneNumber, othEmp_Type, othEmp_Address, othEmp_Gender,
                othEmp_Salary, othEmpDate_OF_Birth, othEmp_WHstart, othEmp_WHend))
            {
                csOtherStaff othEmp = new csOtherStaff(othEmp_Name, othEmp_Cnic, othEmp_PhoneNumber, othEmp_Type, othEmp_Address,
                    othEmp_Gender, othEmp_Salary, othEmpDate_OF_Birth, othEmp_WHstart, othEmp_WHend);
                if (btnAddInput.Text.Equals("Add"))
                {
                    csHospital.Instence.AddOtherStaff(othEmp);
                }
                else
                {
                    csHospital.Instence.UpdateOtherStaff(update_Index, othEmp);
                }
                ChangeUC.To_ucOtherStaffData();
            }
            else
            {
                lbInvalidInput.Show();
            }
        }
        public void RefreshUC()
        {
            LoadComboBox(csHospital.Instence.getOtherStaffTypes());
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

            csOtherStaff staff = csHospital.Instence.getOtherStaffs()[index];
            txtName.Text = staff.Name;
            txtCnic.Text = staff.Cnic;
            txtPhoneNo.Text = staff.PhoneNumber;
            cbType.SelectedItem = staff.Type;
            txtAddress.Text = staff.Address;
            nudSalary.Value = staff.Salary;
            dtpDateOfBirth.Value = staff.DateOfBirth;
            dtpWHstart.Value = staff.WH_Start_Time;
            dtpWHend.Value = staff.WH_End_Time;
            if (staff.Gender.Equals("Male"))
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
