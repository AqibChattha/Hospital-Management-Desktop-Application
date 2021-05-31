using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucPatientsData : UserControl
    {
        private static ucPatientsData _instence;
        public static ucPatientsData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucPatientsData();
                }
                return _instence;
            }
        }
        public ucPatientsData()
        {
            InitializeComponent();
        }

        private void usPatientsData_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn cellDelete = new DataGridViewImageColumn();
            cellDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            cellDelete.FillWeight = 15;
            cellDelete.Selected = false;
            cellDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;


            DataGridViewImageColumn cellView = new DataGridViewImageColumn();
            cellView.ImageLayout = DataGridViewImageCellLayout.Zoom;
            cellView.FillWeight = 15;
            cellView.Selected = false;
            cellView.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

            DataGridViewImageColumn cellEdit = new DataGridViewImageColumn();
            cellEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            cellEdit.FillWeight = 15;
            cellEdit.Selected = false;
            cellEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

            DataGridViewTextBoxColumn cellName = new DataGridViewTextBoxColumn();
            cellName.HeaderText = "Name";
            cellName.Selected = false;
            cellName.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

            DataGridViewTextBoxColumn cellCnic = new DataGridViewTextBoxColumn();
            cellCnic.HeaderText = "CNIC";
            cellCnic.Selected = false;
            cellCnic.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

            DataGridViewTextBoxColumn cellPhNo = new DataGridViewTextBoxColumn();
            cellPhNo.HeaderText = "Phone Number";
            cellPhNo.Selected = false;
            cellPhNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

            DataGridViewTextBoxColumn cellEmail = new DataGridViewTextBoxColumn();
            cellEmail.HeaderText = "Email";
            cellEmail.Selected = false;
            cellEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

            DataGridViewTextBoxColumn cellDepartment = new DataGridViewTextBoxColumn();
            cellDepartment.HeaderText = "Department";
            cellDepartment.Selected = false;
            cellDepartment.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

            DataGridViewTextBoxColumn cellGender = new DataGridViewTextBoxColumn();
            cellGender.HeaderText = "Gender";
            cellGender.Selected = false;
            cellGender.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

            dtvPatients.Columns.Add(cellName);
            dtvPatients.Columns.Add(cellCnic);
            dtvPatients.Columns.Add(cellPhNo);
            dtvPatients.Columns.Add(cellEmail);
            dtvPatients.Columns.Add(cellDepartment);
            dtvPatients.Columns.Add(cellGender);
            dtvPatients.Columns.Add(cellDelete);
            dtvPatients.Columns.Add(cellView);
            dtvPatients.Columns.Add(cellEdit);

            dtvPatients.Rows.Add("", "", "", "", "", "", Image.FromFile("E:/New Folder/Hospital Management System/Icons/delete.png"), Image.FromFile("E:/New Folder/Hospital Management System/Icons/view.png"), Image.FromFile("E:/New Folder/Hospital Management System/Icons/edit.png"));

            dtvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvPatients.AllowUserToAddRows = false;
            dtvPatients.ReadOnly = true;
        }

        private void btnRegisterPatient_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddPatient.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddPatient.Instence);
                ucAddPatient.Instence.Dock = DockStyle.Fill;
                ucAddPatient.Instence.BringToFront();
            }
            else
            {
                ucAddPatient.Instence.BringToFront();
            }
        }
    }
}
