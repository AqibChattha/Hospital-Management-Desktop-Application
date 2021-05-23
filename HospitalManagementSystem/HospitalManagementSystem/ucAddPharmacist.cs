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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtCnic.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtPhoneNo.Text = "";
            txtAddress.Text = "";
            dtpStartTime.Value = DateTime.Today;
            dtpEndTime.Value = DateTime.Today;
            cbQualification.Text = "";
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            nudSalary.Value = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (!MainForn.main_Panel.Controls.Contains(ucPharmacistData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucPharmacistData.Instence);
                ucPharmacistData.Instence.Dock = DockStyle.Fill;
                ucPharmacistData.Instence.BringToFront();
            }
            else
            {
                ucPharmacistData.Instence.BringToFront();
            }
        }
    }
}
