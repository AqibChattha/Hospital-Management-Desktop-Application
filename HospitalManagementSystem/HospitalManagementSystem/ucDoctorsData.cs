using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucDoctorsData : UserControl
    {
        private static ucDoctorsData _instence;
        public static ucDoctorsData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucDoctorsData();
                }
                return _instence;
            }
        }
        public ucDoctorsData()
        {
            InitializeComponent();
        }

        private void btnRegisterDoctor_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddDoctor.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddDoctor.Instence);
                ucAddDoctor.Instence.Dock = DockStyle.Fill;
                ucAddDoctor.Instence.BringToFront();
            }
            else
            {
                ucAddDoctor.Instence.BringToFront();
            }
        }

        private void ucDoctorsData_Load(object sender, EventArgs e)
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

            dtvDoctor.Columns.Add(cellName);
            dtvDoctor.Columns.Add(cellCnic);
            dtvDoctor.Columns.Add(cellPhNo);
            dtvDoctor.Columns.Add(cellEmail);
            dtvDoctor.Columns.Add(cellDepartment);
            dtvDoctor.Columns.Add(cellGender);
            dtvDoctor.Columns.Add(cellDelete) ;
            dtvDoctor.Columns.Add(cellView);
            dtvDoctor.Columns.Add(cellEdit);

            var btmp1 = new Bitmap(Images.view);
            var btmp2 = new Bitmap(Images.edit);
            var btmp3 = new Bitmap(Images.delete);
            dtvDoctor.Rows.Add("", "", "", "", "", "",btmp1,btmp2,btmp3);

            dtvDoctor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvDoctor.AllowUserToAddRows = false;
            dtvDoctor.ReadOnly = true;
            
        }
    }
}
