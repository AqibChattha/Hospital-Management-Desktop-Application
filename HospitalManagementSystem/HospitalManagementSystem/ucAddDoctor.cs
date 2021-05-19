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
        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {
            dataGridViewDoctors.Rows.Add(txtName.Text, txtCnic.Text, txtPhoneNo.Text, txtEmail.Text, comboBoxDep.SelectedItem.ToString());
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtCnic.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtPhoneNo.Text = "";
            txtAddress.Text = "";
            comboBoxDep.Text = "";
            comboBoxGender.Text = "";
        }
    }
}
