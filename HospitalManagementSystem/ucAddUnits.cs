using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAddUnits : UserControl
    {
        private static ucAddUnits _instence;
        public static ucAddUnits Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAddUnits();
                }
                return _instence;
            }
        }
        public ucAddUnits()
        {
            InitializeComponent();
        }

        private void btnAddWardData_Click(object sender, EventArgs e)
        {
            String ward_Name = txtName1.Text;
            int ward_Number = (int)nudWardNo.Value;
            String ward_Rating = cbRating.SelectedItem.ToString();
            String ward_Address = txtAddress.Text;
        }

        private void btnAddLaboratoryData_Click(object sender, EventArgs e)
        {
            String laboratory_Name = txtName2.Text;
            String laboratory_Address = txtAddress2.Text;
        }

        private void btnAddPharmacyData_Click(object sender, EventArgs e)
        {
            String pharmacy_Name = txtName3.Text;
            String pharmacy_Address = txtAddress3.Text;
        }

        private void btnAddOTData_Click(object sender, EventArgs e)
        {
            String OT_Name = txtName4.Text;
            String OT_Address = txtAddress4.Text;
        }

        private void btnAddBloodBankData_Click(object sender, EventArgs e)
        {
            String BloodBank_Name = txtName5.Text;
            String BloodBank_Address = txtAddress5.Text;
        }

        private void btnAddDepartmentData_Click(object sender, EventArgs e)
        {
            String Department_Name = txtName6.Text;
            String Department_Address = txtAddress6.Text;
        }

        private void btnClearWardData_Click(object sender, EventArgs e)
        {
            txtName1.Text = "";
            cbRating.Text = "";
            txtAddress.Text = "";
        }

        private void btnClearLabortoryData_Click(object sender, EventArgs e)
        {
            txtName2.Text = "";
            txtAddress2.Text = "";
        }

        private void btnClearPharmacyData_Click(object sender, EventArgs e)
        {
            txtName3.Text = "";
            txtAddress3.Text = "";
        }

        private void btnClearOTData_Click(object sender, EventArgs e)
        {
            txtName4.Text = "";
            txtAddress4.Text = "";
        }

        private void btnClearBloodBankData_Click(object sender, EventArgs e)
        {
            txtName5.Text = "";
            txtAddress5.Text = "";
        }

        private void btnClearDepartmentData_Click(object sender, EventArgs e)
        {
            txtName6.Text = "";
            txtAddress6.Text = "";
        }
    }
}
