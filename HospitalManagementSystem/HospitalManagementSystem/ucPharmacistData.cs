using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucPharmacistData : UserControl
    {
        private static ucPharmacistData _instence;
        public static ucPharmacistData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucPharmacistData();
                }
                return _instence;
            }
        }
        public ucPharmacistData()
        {
            InitializeComponent();
        }

        private void btnRegisterPharmacist_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddPharmacist.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddPharmacist.Instence);
                ucAddPharmacist.Instence.Dock = DockStyle.Fill;
                ucAddPharmacist.Instence.BringToFront();
            }
            else
            {
                ucAddPharmacist.Instence.BringToFront();
            }
        }

        private void ucPharmacistData_Load(object sender, EventArgs e)
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

            dtvPharmacist.Columns.Add(cellName);
            dtvPharmacist.Columns.Add(cellCnic);
            dtvPharmacist.Columns.Add(cellPhNo);
            dtvPharmacist.Columns.Add(cellEmail);
            dtvPharmacist.Columns.Add(cellDepartment);
            dtvPharmacist.Columns.Add(cellGender);
            dtvPharmacist.Columns.Add(cellDelete);
            dtvPharmacist.Columns.Add(cellView);
            dtvPharmacist.Columns.Add(cellEdit);

            dtvPharmacist.Rows.Add("", "", "", "", "", "", Image.FromFile("E:/New Folder/Hospital Management System/Icons/delete.png"), Image.FromFile("E:/New Folder/Hospital Management System/Icons/view.png"), Image.FromFile("E:/New Folder/Hospital Management System/Icons/edit.png"));

            dtvPharmacist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvPharmacist.AllowUserToAddRows = false;
            dtvPharmacist.ReadOnly = true;
        }
    }
}
