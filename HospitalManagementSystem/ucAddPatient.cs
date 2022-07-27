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
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            List<csRoom> rooms = csHospital.Instence.getRooms();
            List<String> wardsids = new List<String>();
            for (int i = 0; i < rooms.Count; i++)
            {
                if (rooms[i].GetType() == new csWard().GetType())
                {
                    wardsids.Add(rooms[i].Id);
                }
            }
            cbRoomId.DataSource = wardsids;
            cbStaffType.DataSource = csHospital.Instence.getStaffTypes();
            cbStaffId.DataSource = csHospital.Instence.getStaffIdsByType(cbStaffType.Text);
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
            ClearOutPatientEntries();
            ClearInPatientEntries();
            ClearIllStaffEntries();
        }

        private void btnAddToQueue_Click(object sender, EventArgs e)
        {
            String outPatient_Name = txtName.Text;
            String outPatient_Cnic = txtCnic.Text;
            String outPatient_PhoneNumber = txtPhoneNo.Text;
            String outPatient_Email = txtEmail.Text;
            String outPatient_PAssworsd = txtPassword.Text;
            String outPatient_Address = txtAddress.Text;
            DateTime outPatient_DateOFBirth = dtpDateOfBirth.Value;
            string outPatient_Gender = "";
            if (rbtnFemale.Checked)
            {
                outPatient_Gender = "Female";
            }
            else
            {
                outPatient_Gender = "Male";
            }

            if (txtName.Text != "" && txtCnic.Text != "" && txtPhoneNo.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && outPatient_Gender != "")
            {
                if (Validat.OutPatient(outPatient_Name, outPatient_Cnic, outPatient_PhoneNumber, outPatient_DateOFBirth, outPatient_Address, outPatient_Email, outPatient_PAssworsd))
                {
                    csOutPatient outPatient = new csOutPatient(outPatient_Name, outPatient_Cnic, outPatient_PhoneNumber, outPatient_Gender, outPatient_DateOFBirth, outPatient_Address, outPatient_Email, outPatient_PAssworsd);
                    csHospital.Instence.AddPatient(outPatient);
                    csHospital.Instence.AddPatientInQueue(outPatient);
                    ChangeUC.To_ucPatientQueue();
                    return;
                }
            }
            MessageBox.Show("Invalid information, try again.");
        }

        private void btnAddToData_Click(object sender, EventArgs e)
        {
            String inPatient_Name = txtName2.Text;
            String inPatient_Cnic = txtCnic2.Text;
            String inPatient_PhoneNumber = txtPhoneNo2.Text;
            String inPatient_Address = txtAddress2.Text;
            string inPatient_Gender = "";
            string room_id = "";
            if (cbRoomId.SelectedItem != null)
            {
                room_id = cbRoomId.SelectedItem.ToString();
            }
            DateTime inPatient_DateOFBirth = dtpDateOfBirth2.Value;
            if (rbtnFemale2.Checked)
            {
                inPatient_Gender = "Female";
            }
            else
            {
                inPatient_Gender = "Male";
            }
            if (inPatient_Gender != "" && room_id != "")
            {
                if (Validat.InPatient(inPatient_Name, inPatient_Cnic, inPatient_PhoneNumber, inPatient_DateOFBirth, inPatient_Address, room_id)) {
                    csInPatient inPatient = new csInPatient(inPatient_Name, inPatient_Cnic, inPatient_PhoneNumber, inPatient_Gender, inPatient_DateOFBirth, inPatient_Address, room_id);
                    csHospital.Instence.AddPatient(inPatient);
                    ChangeUC.To_ucPatientsData();
                    return;
                }
            }
            MessageBox.Show("Invalid information, try again.");
        }

        private void btnAddToData2_Click(object sender, EventArgs e)
        {
            String illpatient_Name = txtName3.Text;
            String illpatient_Cnic = txtCnic3.Text;
            String illpatient_PhoneNumber = txtPhoneNo3.Text;
            String illpatient_Address = txtAddress3.Text;
            DateTime illpatient_DateOFBirth = dtpDateOfBirth3.Value;
            string illpatient_StaffType = "";
            string illpatient_StaffId = "";
            string illpatient_Gender = "";

            if (cbStaffType.SelectedItem != null && cbStaffId.SelectedItem != null)
            {
                illpatient_StaffType = cbStaffType.SelectedItem.ToString();
                illpatient_StaffId = cbStaffId.SelectedItem.ToString();
            }
            if (rbtnFemale3.Checked)
            {
                illpatient_Gender = "Female";
            }
            else
            {
                illpatient_Gender = "Male";
            }
            if (illpatient_Gender != "" && illpatient_StaffId != "" && illpatient_StaffType != "")
            {
                if (Validat.IllStaff(illpatient_Name, illpatient_Cnic, illpatient_PhoneNumber, illpatient_DateOFBirth, illpatient_Address, illpatient_StaffType, illpatient_StaffId))
                {
                    csIllStaff illStaff = new csIllStaff(illpatient_Name, illpatient_Cnic, illpatient_PhoneNumber, illpatient_Gender, illpatient_DateOFBirth, illpatient_Address, illpatient_StaffType, illpatient_StaffId);
                    csHospital.Instence.AddPatient(illStaff);
                    ChangeUC.To_ucPatientsData();
                    return;
                }
            }
            MessageBox.Show("Invalid information, try again.");
        }

        public void ClearOutPatientEntries()
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
        private void btnClearOutPatient_Click(object sender, EventArgs e)
        {
            ClearOutPatientEntries();
        }
        public void ClearInPatientEntries()
        {
            txtName2.Text = "";
            txtCnic2.Text = "";
            txtPhoneNo2.Text = "";
            txtAddress2.Text = "";
            dtpDateOfBirth2.Value = DateTime.Today;
            rbtnMale2.Checked = false;
            rbtnFemale2.Checked = false;
        }
        private void btnClearInPatient_Click(object sender, EventArgs e)
        {
            ClearInPatientEntries();
        }
        public void ClearIllStaffEntries()
        {
            txtName3.Text = "";
            txtCnic3.Text = "";
            txtPhoneNo3.Text = "";
            txtAddress3.Text = "";
            cbStaffType.Text = "";
            cbStaffId.Text = "";
            dtpDateOfBirth3.Value = DateTime.Today;
            rbtnMale3.Checked = false;
            rbtnFemale3.Checked = false;
        }
        private void btnClearIllStaff_Click(object sender, EventArgs e)
        {
            ClearIllStaffEntries();
        }

        public void RefreshUC()
        {
            LoadComboBoxes();
            ClearOutPatientEntries();
            ClearInPatientEntries();
            ClearIllStaffEntries();
        }

        private void cbStaffType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStaffId.DataSource = csHospital.Instence.getStaffIdsByType(cbStaffType.Text);
        }

        public void UpdateColumnClicked(int index)
        {
            csPatient patient = csHospital.Instence.getPatients()[index];
            if (patient.GetType() == new csOutPatient().GetType())
            {
                cbPatientType.SelectedIndex = 0;
                csOutPatient outPatient = (csOutPatient)patient;
                txtName.Text = outPatient.Name;
                txtCnic.Text = outPatient.Cnic;
                txtPassword.Text = outPatient.Password;
                txtEmail.Text = outPatient.Email;
                txtPhoneNo.Text = outPatient.PhoneNumber;
                txtAddress.Text = outPatient.Address;
                dtpDateOfBirth.Value = outPatient.DateOfBirth;
                if (outPatient.Gender.Equals("Male"))
                {
                    rbtnMale.Checked = true;
                }
                else
                {
                    rbtnFemale.Checked = true;
                }

            }
            else if (csHospital.Instence.getPatients()[index].GetType() == new csInPatient().GetType())
            {
                cbPatientType.SelectedIndex = 1;
                csInPatient inPatient = (csInPatient)patient;
                txtName2.Text = inPatient.Name;
                txtCnic2.Text = inPatient.Cnic;
                txtPhoneNo2.Text = inPatient.PhoneNumber;
                txtAddress2.Text = inPatient.Address;
                dtpDateOfBirth2.Value = inPatient.DateOfBirth;
                if (inPatient.Gender.Equals("Male"))
                {
                    rbtnMale2.Checked = true;
                }
                else
                {
                    rbtnFemale2.Checked = true;
                }
            }
            else if (csHospital.Instence.getPatients()[index].GetType() == new csIllStaff().GetType())
            {
                cbPatientType.SelectedIndex = 2;
                csIllStaff illStaff = (csIllStaff)patient;
                txtName3.Text = illStaff.Name;
                txtCnic3.Text = illStaff.Cnic;
                txtPhoneNo3.Text = illStaff.PhoneNumber;
                txtAddress3.Text = illStaff.Address;
                cbStaffType.Text = illStaff.Staff_Type;
                cbStaffId.Text = illStaff.Staff_Id;
                dtpDateOfBirth3.Value = illStaff.DateOfBirth;
                if (illStaff.Gender.Equals("Male"))
                {
                    rbtnMale3.Checked = true;
                }
                else
                {
                    rbtnFemale3.Checked = true;
                }
            }
        }
        public void select_OutPatient() {
            cbPatientType.SelectedIndex = 0;
        }

    }
}
