using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucUnitsData : UserControl
    {
        private static ucUnitsData _instence;
        public static ucUnitsData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucUnitsData();
                }
                return _instence;
            }
        }
        public ucUnitsData()
        {
            InitializeComponent();
        }

        private void ucUnitsData_Load(object sender, EventArgs e)
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
            cellName.FillWeight = 50;
            cellName.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

            DataGridViewTextBoxColumn cellAddress = new DataGridViewTextBoxColumn();
            cellAddress.HeaderText = "Address";
            cellAddress.Selected = false;
            cellAddress.FillWeight = 150;
            cellAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

          

            dtvNurse.Columns.Add(cellName);
            dtvNurse.Columns.Add(cellAddress);
            dtvNurse.Columns.Add(cellDelete);
            dtvNurse.Columns.Add(cellView);
            dtvNurse.Columns.Add(cellEdit);

            var btmp1 = new Bitmap(Images.view);
            var btmp2 = new Bitmap(Images.edit);
            var btmp3 = new Bitmap(Images.delete);
            dtvNurse.Rows.Add("", "",btmp1,btmp2,btmp3);

            dtvNurse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvNurse.AllowUserToAddRows = false;
            dtvNurse.ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }
    }
}
