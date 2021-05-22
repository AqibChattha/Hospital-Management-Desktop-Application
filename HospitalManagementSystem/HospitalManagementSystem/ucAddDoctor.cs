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
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtCnic.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtPhoneNo.Text = "";
            txtAddress.Text = "";
            cbDepartment.Text = "";
        }

        private void dataGridViewDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
