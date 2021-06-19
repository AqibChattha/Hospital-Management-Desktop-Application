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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucOtherStaffData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucOtherStaffData.Instence);
                ucOtherStaffData.Instence.Dock = DockStyle.Fill;
                ucOtherStaffData.Instence.BringToFront();
            }
            else
            {
                ucOtherStaffData.Instence.BringToFront();
            }
        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {
            String othEmp_Name = txtName.Text;
            String othEmp_Cnic = txtCnic.Text;
            String othEmp_PhoneNumber = txtPhoneNo.Text;

            String othEmp_Address = txtAddress.Text;
            String othEmp_Gender;
            if (rbtnFemale.Checked)
            {
                othEmp_Gender = "Female";
            }
            else
            {
                othEmp_Gender = "Male";
            }
            int othEmp_Salary = (int)nudSalary.Value;
            DateTime othEmpDate_OF_Birth = dtpDateOfBirth.Value;
            DateTime othEmp_WHstart = dtpWHstart.Value;
            DateTime othEmp_WHend = dtpWHend.Value;

            MessageBox.Show(othEmp_Name + "\n" + othEmp_Cnic + "\n" + othEmp_PhoneNumber + "\n" + othEmp_Gender + "\n" + othEmp_Salary + "\n" + othEmp_WHstart + "\n" + othEmp_WHend);
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtCnic.Text = "";
            txtPhoneNo.Text = "";
            txtAddress.Text = "";
            dtpWHend.Value = DateTime.Today;
            dtpWHstart.Value = DateTime.Today;
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            nudSalary.Value = 0;
        }
    }
}
