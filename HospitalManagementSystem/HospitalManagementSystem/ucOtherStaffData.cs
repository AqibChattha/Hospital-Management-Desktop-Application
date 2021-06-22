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
            LoadOtherStaffDataInDtv(csHospital.Instence.getOtherStaffs());
            dtvOtherStaff.AllowUserToAddRows = false;
            LoadComboBox(csHospital.Instence.getOtherStaffTypes());
        }
        private void LoadComboBox(List<String> t)
        {
            cbOtherStaffType.Items.Clear();
            for (int i = 0; i < t.Count; i++)
            {
                cbOtherStaffType.Items.Add(t[i]);
            }
        }
        private void LoadOtherStaffDataInDtv(List<csOtherStaff> otherStaffs)
        {
            dtvOtherStaff.Rows.Clear();
            for (int i = 0; i < otherStaffs.Count; i++)
            {
                dtvOtherStaff.Rows.Add(otherStaffs[i].Staff_Id, otherStaffs[i].Name, otherStaffs[i].Cnic, otherStaffs[i].PhoneNumber);
            }
        }
        private void LoadSearchedDataInDtv(List<csOtherStaff> otherStaffs, String searchedValue)
        {
            dtvOtherStaff.Rows.Clear();
            for (int i = 0; i < otherStaffs.Count; i++)
            {
                if (otherStaffs[i].Name.Contains(searchedValue, StringComparison.CurrentCultureIgnoreCase) == true || otherStaffs[i].Staff_Id.Contains(searchedValue, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    dtvOtherStaff.Rows.Add(otherStaffs[i].Staff_Id, otherStaffs[i].Name, otherStaffs[i].Cnic, otherStaffs[i].PhoneNumber);
                }
            }
        }

        private int getOtherStaffIndex(int indx)
        {
            List<csOtherStaff> otherStaffs = csHospital.Instence.getOtherStaffs();
            for (int i = 0; i < otherStaffs.Count; i++)
            {
                if (otherStaffs[i].Staff_Id.Equals(dtvOtherStaff.Rows[indx].Cells[0].Value.ToString()) == true && otherStaffs[i].Name.Equals(dtvOtherStaff.Rows[indx].Cells[1].Value.ToString()) == true)
                {
                    return i;
                }
            }
            return -1;
        }
        private void DeleteOtherStaffRow(int index)
        {
            csHospital.Instence.DeleteOtherStaff(getOtherStaffIndex(index));
            dtvOtherStaff.Rows.RemoveAt(index);
            txtSearch.Text = "";
        }

        private void btnRegisterOtherStaff_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucAddOtherEmployee();
        }

        public void RefreshUC()
        {
            txtSearch.Text = "";
            cbOtherStaffType.Text = "";
            LoadOtherStaffDataInDtv(csHospital.Instence.getOtherStaffs());
            LoadComboBox(csHospital.Instence.getOtherStaffTypes());
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSearchedDataInDtv(csHospital.Instence.getOtherStaffs(), txtSearch.Text);
        }

        private void dtvOtherStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete this employee.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        DeleteOtherStaffRow(e.RowIndex);
                    }
                }

                if (e.ColumnIndex == 5)
                {
                    if (!MainForn.main_Panel.Controls.Contains(ucAddOtherEmployee.Instence))
                    {
                        MainForn.main_Panel.Controls.Add(ucAddOtherEmployee.Instence);
                        ucAddOtherEmployee.Instence.Dock = DockStyle.Fill;
                        ucAddOtherEmployee.Instence.UpdateColumnClicked(getOtherStaffIndex(e.RowIndex));
                        ucAddOtherEmployee.Instence.BringToFront();
                    }
                    else
                    {
                        ucAddOtherEmployee.Instence.UpdateColumnClicked(getOtherStaffIndex(e.RowIndex));
                        ucAddOtherEmployee.Instence.BringToFront();
                    }
                }

                if (e.ColumnIndex == 4)
                {
                    csHospital.Instence.ViewOtherStaff(getOtherStaffIndex(e.RowIndex));
                    txtSearch.Text = "";
                }
            }
        }

        private void cbOtherStaffType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtvOtherStaff.Rows.Clear();
            List<csOtherStaff> list = csHospital.Instence.getOtherStaffs();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Type.Equals(cbOtherStaffType.SelectedItem.ToString(), StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    dtvOtherStaff.Rows.Add(list[i].Staff_Id, list[i].Name, list[i].Cnic, list[i].PhoneNumber);
                }
            }
        }
    }
}
