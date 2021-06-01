using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucSurgeonsData : UserControl
    {
        private static ucSurgeonsData _instence;
        public static ucSurgeonsData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucSurgeonsData();
                }
                return _instence;
            }
        }
        public ucSurgeonsData()
        {
            InitializeComponent();
        }

        private void btnRegisterSurgeon_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddSurgeon.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddSurgeon.Instence);
                ucAddSurgeon.Instence.Dock = DockStyle.Fill;
                ucAddSurgeon.Instence.BringToFront();
            }
            else
            {
                ucAddSurgeon.Instence.BringToFront();
            }
        }

        private void ucSurgeonsData_Load(object sender, EventArgs e)
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

            dtvSurgeons.Columns.Add(cellName);
            dtvSurgeons.Columns.Add(cellCnic);
            dtvSurgeons.Columns.Add(cellPhNo);
            dtvSurgeons.Columns.Add(cellEmail);
            dtvSurgeons.Columns.Add(cellDepartment);
            dtvSurgeons.Columns.Add(cellGender);
            dtvSurgeons.Columns.Add(cellDelete);
            dtvSurgeons.Columns.Add(cellView);
            dtvSurgeons.Columns.Add(cellEdit);

            var btmp1 = new Bitmap(Images.view);
            var btmp2 = new Bitmap(Images.edit);
            var btmp3 = new Bitmap(Images.delete);
            dtvSurgeons.Rows.Add("", "", "", "", "", "",btmp1,btmp2,btmp3);

            dtvSurgeons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvSurgeons.AllowUserToAddRows = false;
            dtvSurgeons.ReadOnly = true;
        }
    }
}
