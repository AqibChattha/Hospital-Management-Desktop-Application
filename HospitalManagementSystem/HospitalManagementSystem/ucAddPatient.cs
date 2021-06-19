using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAddPatient : UserControl
    {

        private static ucAddPatient _instence;
        public static ucAddPatient Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAddPatient();
                }
                return _instence;
            }
        }
        public ucAddPatient()
        {
            InitializeComponent();
            cbPatientType.SelectedIndex = 0;
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void cbPatientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPatientType.SelectedIndex == 0)
            {
                panel1.Visible = true;
                panel1.Dock = DockStyle.Fill;
                panel3.Visible = false;
                panel4.Visible = false;
            }
            if (cbPatientType.SelectedIndex == 1)
            {
                panel3.Visible = true;
                panel3.Dock = DockStyle.Fill;
                panel1.Visible = false;
                panel4.Visible = false;
            }
            if (cbPatientType.SelectedIndex == 2)
            {
                panel4.Visible = true;
                panel4.Dock = DockStyle.Fill;
                panel1.Visible = false;
                panel3.Visible = false;
            }
        }

        private void btnAddToQueue_Click(object sender, EventArgs e)
        {
            String outPatient_Name = txtName.Text;
            String outPatient_Cnic = txtCnic.Text;
            String outPatient_PhoneNumber = txtPhoneNo.Text;
            String outPatient_Email = txtEmail.Text;
            String outPatient_PAssworsd = txtPassword.Text;
            String outPatient_Address = txtAddress.Text;
            String outPatient_Gender;
            if (rbtnFemale.Checked)
            {
                outPatient_Gender = "Female";
            }
            else
            {
                outPatient_Gender = "Male";
            }

            DateTime outPatient_DateOFBirth = dtpDateOfBirth.Value;

            MessageBox.Show(outPatient_Name + "\n" + outPatient_Cnic + "\n" + outPatient_PhoneNumber + "\n" + outPatient_Gender + "\n");


            if (!MainForn.main_Panel.Controls.Contains(ucPatientQueue.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucPatientQueue.Instence);
                ucPatientQueue.Instence.Dock = DockStyle.Fill;
                ucPatientQueue.Instence.BringToFront();
            }
            else
            {
                ucPatientQueue.Instence.BringToFront();
            }
        }

        private void btnAddToData_Click(object sender, EventArgs e)
        {
            String inPatient_Name = txtName2.Text;
            String inPatient_Cnic = txtCnic2.Text;
            String inPatient_PhoneNumber = txtPhoneNo2.Text;
            String inPatient_Address = txtAddress2.Text;
            String inPatient_Gender;
            if (rbtnFemale2.Checked)
            {
                inPatient_Gender = "Female";
            }
            else
            {
                inPatient_Gender = "Male";
            }

            DateTime outPatient_DateOFBirth = dtpDateOfBirth2.Value;

            MessageBox.Show(inPatient_Name + "\n" + inPatient_Cnic + "\n" + inPatient_PhoneNumber + "\n" + inPatient_Gender + "\n");


            if (!MainForn.main_Panel.Controls.Contains(ucPatientsData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucPatientsData.Instence);
                ucPatientsData.Instence.Dock = DockStyle.Fill;
                ucPatientsData.Instence.BringToFront();
            }
            else
            {
                ucPatientsData.Instence.BringToFront();
            }
        }

        private void btnAddToData2_Click(object sender, EventArgs e)
        {
            String illpatient_Name = txtName3.Text;
            String illpatient_Cnic = txtCnic3.Text;
            String illpatient_PhoneNumber = txtPhoneNo3.Text;
            String illpatient_Address = txtAddress3.Text;
            String illpatient_StaffType = txtStaffType.Text;
            String illpatient_StaffId = txtStaffId.Text;
            String illpatient_Gender;
            if (rbtnFemale3.Checked)
            {
                illpatient_Gender = "Female";
            }
            else
            {
                illpatient_Gender = "Male";
            }

            DateTime outPatient_DateOFBirth = dtpDateOfBirth3.Value;

            MessageBox.Show(illpatient_Name + "\n" + illpatient_Cnic + "\n" + illpatient_PhoneNumber + "\n" + illpatient_Gender + "\n");

            if (!MainForn.main_Panel.Controls.Contains(ucPatientsData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucPatientsData.Instence);
                ucPatientsData.Instence.Dock = DockStyle.Fill;
                ucPatientsData.Instence.BringToFront();
            }
            else
            {
                ucPatientsData.Instence.BringToFront();
            }

        }

        private void btnClearOutPatient_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtCnic.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtPhoneNo.Text = "";
            txtAddress.Text = "";
            dtpDateOfBirth.Value = DateTime.Today;
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
        }

        private void btnClearInPatient_Click(object sender, EventArgs e)
        {
            txtName2.Text = "";
            txtCnic2.Text = "";
            txtPhoneNo2.Text = "";
            txtAddress2.Text = "";
            dtpDateOfBirth2.Value = DateTime.Today;
            rbtnMale2.Checked = false;
            rbtnFemale2.Checked = false;
        }

        private void btnClearIllStaff_Click(object sender, EventArgs e)
        {
            txtName3.Text = "";
            txtCnic3.Text = "";
            txtPhoneNo3.Text = "";
            txtAddress3.Text = "";
            txtStaffType.Text = "";
            txtStaffId.Text = "";
            dtpDateOfBirth3.Value = DateTime.Today;
            rbtnMale3.Checked = false;
            rbtnFemale3.Checked = false;
        }
    }
}
