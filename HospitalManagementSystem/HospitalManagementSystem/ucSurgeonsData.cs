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
            LoadSurgeonDataInDtv(csHospital.Instence.getSurgeons());
            dtvSurgeons.AllowUserToAddRows = false;

        }

        private void LoadSurgeonDataInDtv(List<csSurgeon> surgeons)
        {
            dtvSurgeons.Rows.Clear();
            for (int i = 0; i < surgeons.Count; i++)
            {
                dtvSurgeons.Rows.Add(surgeons[i].Staff_Id, surgeons[i].Name, surgeons[i].Cnic, surgeons[i].PhoneNumber);
            }
        }
        private void LoadSearchedDataInDtv(List<csSurgeon> surgeons, String searchedValue)
        {
            dtvSurgeons.Rows.Clear();
            for (int i = 0; i < surgeons.Count; i++)
            {
                if (surgeons[i].Name.Contains(searchedValue, StringComparison.CurrentCultureIgnoreCase) == true || surgeons[i].Staff_Id.Contains(searchedValue, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    dtvSurgeons.Rows.Add(surgeons[i].Staff_Id, surgeons[i].Name, surgeons[i].Cnic, surgeons[i].PhoneNumber);
                }
            }
        }

        private int getSurgeonIndex(int indx)
        {
            List<csSurgeon> surgeons = csHospital.Instence.getSurgeons();
            for (int i = 0; i < surgeons.Count; i++)
            {
                if (surgeons[i].Staff_Id.Equals(dtvSurgeons.Rows[indx].Cells[0].Value.ToString()) == true && surgeons[i].Name.Equals(dtvSurgeons.Rows[indx].Cells[1].Value.ToString()) == true)
                {
                    return i;
                }
            }
            return -1;
        }
        private void DeleteSurgeonRow(int index)
        {
            csHospital.Instence.DeleteSurgeon(getSurgeonIndex(index));
            dtvSurgeons.Rows.RemoveAt(index);
            txtSearch.Text = "";
        }


        private void btnRegisterSurgeon_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucAddSurgeon();
        }

        private void txtSearchSurgeon_TextChanged(object sender, EventArgs e)
        {
            LoadSearchedDataInDtv(csHospital.Instence.getSurgeons(), txtSearch.Text);
        }

        private void dtvSurgeons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete this surgeon.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        DeleteSurgeonRow(e.RowIndex);
                    }
                }
                if (e.ColumnIndex == 5)
                {
                    if (!MainForn.main_Panel.Controls.Contains(ucAddSurgeon.Instence))
                    {
                        MainForn.main_Panel.Controls.Add(ucAddSurgeon.Instence);
                        ucAddSurgeon.Instence.Dock = DockStyle.Fill;
                        ucAddSurgeon.Instence.UpdateColumnClicked(getSurgeonIndex(e.RowIndex));
                        ucAddSurgeon.Instence.BringToFront();
                    }
                    else
                    {
                        ucAddSurgeon.Instence.UpdateColumnClicked(getSurgeonIndex(e.RowIndex));
                        ucAddSurgeon.Instence.BringToFront();
                    }
                }
                if (e.ColumnIndex == 4)
                {
                    csHospital.Instence.ViewSurgeon(getSurgeonIndex(e.RowIndex));
                    txtSearch.Text = "";
                }
            }
        }
        public void RefreshUC()
        {
            txtSearch.Text = "";
            LoadSurgeonDataInDtv(csHospital.Instence.getSurgeons());
        }
    }
}
