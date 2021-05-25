using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucOtherStaffData : UserControl
    {
        private static ucOtherStaffData _instence;
        public static ucOtherStaffData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucOtherStaffData();
                }
                return _instence;
            }
        }
        public ucOtherStaffData()
        {
            InitializeComponent();
        }

        private void btnRegisterOtherStaff_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddOtherEmployee.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddOtherEmployee.Instence);
                ucAddOtherEmployee.Instence.Dock = DockStyle.Fill;
                ucAddOtherEmployee.Instence.BringToFront();
            }
            else
            {
                ucAddOtherEmployee.Instence.BringToFront();
            }
        }

        private void ucOtherStaffData_Load(object sender, EventArgs e)
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
            cellEmail.HeaderText = "Type";
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

            dtvOtherStaff.Columns.Add(cellName);
            dtvOtherStaff.Columns.Add(cellCnic);
            dtvOtherStaff.Columns.Add(cellPhNo);
            dtvOtherStaff.Columns.Add(cellEmail);
            dtvOtherStaff.Columns.Add(cellDepartment);
            dtvOtherStaff.Columns.Add(cellGender);
            dtvOtherStaff.Columns.Add(cellDelete);
            dtvOtherStaff.Columns.Add(cellView);
            dtvOtherStaff.Columns.Add(cellEdit);

            dtvOtherStaff.Rows.Add("", "", "", "", "", "", Image.FromFile("E:/New Folder/Hospital Management System/Icons/delete.png"), Image.FromFile("E:/New Folder/Hospital Management System/Icons/view.png"), Image.FromFile("E:/New Folder/Hospital Management System/Icons/edit.png"));

            dtvOtherStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvOtherStaff.AllowUserToAddRows = false;
            dtvOtherStaff.ReadOnly = true;
        }
    }
}
