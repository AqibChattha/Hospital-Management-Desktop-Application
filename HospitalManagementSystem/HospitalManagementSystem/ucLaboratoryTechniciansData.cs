using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucLaboratoryTechniciansData : UserControl
    {
        private static ucLaboratoryTechniciansData _instence;
        public static ucLaboratoryTechniciansData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucLaboratoryTechniciansData();
                }
                return _instence;
            }
        }
        public ucLaboratoryTechniciansData()
        {
            InitializeComponent();
        }

        private void btnRegisterLabTech_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddLaboratoryTechnician.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddLaboratoryTechnician.Instence);
                ucAddLaboratoryTechnician.Instence.Dock = DockStyle.Fill;
                ucAddLaboratoryTechnician.Instence.BringToFront();
            }
            else
            {
                ucAddLaboratoryTechnician.Instence.BringToFront();
            }
        }

        private void ucLaboratoryTechniciansData_Load(object sender, EventArgs e)
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
            cellDepartment.HeaderText = "Age";
            cellDepartment.Selected = false;
            cellDepartment.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

            DataGridViewTextBoxColumn cellGender = new DataGridViewTextBoxColumn();
            cellGender.HeaderText = "Gender";
            cellGender.Selected = false;
            cellGender.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

            dtvLabTechnician.Columns.Add(cellName);
            dtvLabTechnician.Columns.Add(cellCnic);
            dtvLabTechnician.Columns.Add(cellPhNo);
            dtvLabTechnician.Columns.Add(cellEmail);
            dtvLabTechnician.Columns.Add(cellDepartment);
            dtvLabTechnician.Columns.Add(cellGender);
            dtvLabTechnician.Columns.Add(cellDelete);
            dtvLabTechnician.Columns.Add(cellView);
            dtvLabTechnician.Columns.Add(cellEdit);

            var btmp1 = new Bitmap(Images.view);
            var btmp2 = new Bitmap(Images.edit);
            var btmp3 = new Bitmap(Images.delete);
            dtvLabTechnician.Rows.Add("", "", "", "", "", "",btmp1,btmp2,btmp3);

            dtvLabTechnician.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvLabTechnician.AllowUserToAddRows = false;
            dtvLabTechnician.ReadOnly = true;
        }
    }
}
