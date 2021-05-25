using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucReceptionistsData : UserControl
    {
        private static ucReceptionistsData _instence;
        public static ucReceptionistsData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucReceptionistsData();
                }
                return _instence;
            }
        }
        public ucReceptionistsData()
        {
            InitializeComponent();
        }

        private void btnRegisterReceptionist_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddReceptionist.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddReceptionist.Instence);
                ucAddReceptionist.Instence.Dock = DockStyle.Fill;
                ucAddReceptionist.Instence.BringToFront();
            }
            else
            {
                ucAddReceptionist.Instence.BringToFront();
            }
        }

        private void ucReceptionistsData_Load(object sender, EventArgs e)
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
            cellDepartment.HeaderText = "Type";
            cellDepartment.Selected = false;
            cellDepartment.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

            DataGridViewTextBoxColumn cellGender = new DataGridViewTextBoxColumn();
            cellGender.HeaderText = "Gender";
            cellGender.Selected = false;
            cellGender.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

            dtvReceptionists.Columns.Add(cellName);
            dtvReceptionists.Columns.Add(cellCnic);
            dtvReceptionists.Columns.Add(cellPhNo);
            dtvReceptionists.Columns.Add(cellEmail);
            dtvReceptionists.Columns.Add(cellDepartment);
            dtvReceptionists.Columns.Add(cellGender);
            dtvReceptionists.Columns.Add(cellDelete);
            dtvReceptionists.Columns.Add(cellView);
            dtvReceptionists.Columns.Add(cellEdit);

            dtvReceptionists.Rows.Add("", "", "", "", "", "", Image.FromFile("E:/New Folder/Hospital Management System/Icons/delete.png"), Image.FromFile("E:/New Folder/Hospital Management System/Icons/view.png"), Image.FromFile("E:/New Folder/Hospital Management System/Icons/edit.png"));

            dtvReceptionists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvReceptionists.AllowUserToAddRows = false;
            dtvReceptionists.ReadOnly = true;
        }
    }
}
