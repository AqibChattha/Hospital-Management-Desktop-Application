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
            dtvPharmacist.AllowUserToAddRows = false;
            LoadPharmacistDataInDtv(csHospital.Instence.getPharmacist());
        }

        private void LoadPharmacistDataInDtv(List<csPharmacist> Pharmacists)
        {
            dtvPharmacist.Rows.Clear();
            for (int i = 0; i < Pharmacists.Count; i++)
            {
                dtvPharmacist.Rows.Add(Pharmacists[i].Staff_Id, Pharmacists[i].Name, Pharmacists[i].Cnic, Pharmacists[i].PhoneNumber);
            }
        }

        private void LoadSearchedDataInDtv(List<csPharmacist> Pharmacists, String searchedValue)
        {
            dtvPharmacist.Rows.Clear();
            for (int i = 0; i < Pharmacists.Count; i++)
            {
                if (Pharmacists[i].Name.Contains(searchedValue, StringComparison.CurrentCultureIgnoreCase) == true || Pharmacists[i].Staff_Id.Contains(searchedValue, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    dtvPharmacist.Rows.Add(Pharmacists[i].Staff_Id, Pharmacists[i].Name, Pharmacists[i].Cnic, Pharmacists[i].PhoneNumber);
                }
            }
        }

        private int getPharmacistIndex(int indx)
        {
            List<csPharmacist> Pharmacists = csHospital.Instence.getPharmacist();
            for (int i = 0; i < Pharmacists.Count; i++)
            {
                if (Pharmacists[i].Staff_Id.Equals(dtvPharmacist.Rows[indx].Cells[0].Value.ToString()) == true && Pharmacists[i].Name.Equals(dtvPharmacist.Rows[indx].Cells[1].Value.ToString()) == true)
                {
                    return i;
                }
            }
            return -1;
        }
        private void DeletePharmacistRow(int index)
        {
            csHospital.Instence.DeletePharmacist(getPharmacistIndex(index));
            dtvPharmacist.Rows.RemoveAt(index);
            txtSearch.Text = "";
        }

        private void btnRegisterPharmacist_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucAddPharmacist();
        }
        public void RefreshUC()
        {
            txtSearch.Text = "";
            LoadPharmacistDataInDtv(csHospital.Instence.getPharmacist());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSearchedDataInDtv(csHospital.Instence.getPharmacist(), txtSearch.Text);
        }

        private void dtvPharmacist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete this Pharmacist.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        DeletePharmacistRow(e.RowIndex);
                    }
                }

                if (e.ColumnIndex == 5)
                {
                    if (!MainForn.main_Panel.Controls.Contains(ucAddPharmacist.Instence))
                    {
                        MainForn.main_Panel.Controls.Add(ucAddPharmacist.Instence);
                        ucAddPharmacist.Instence.Dock = DockStyle.Fill;
                        ucAddPharmacist.Instence.UpdateColumnClicked(getPharmacistIndex(e.RowIndex));
                        ucAddPharmacist.Instence.BringToFront();
                    }
                    else
                    {
                        ucAddPharmacist.Instence.UpdateColumnClicked(getPharmacistIndex(e.RowIndex));
                        ucAddPharmacist.Instence.BringToFront();
                    }
                }

                if (e.ColumnIndex == 4)
                {
                    csHospital.Instence.ViewPharmacist(getPharmacistIndex(e.RowIndex));
                    txtSearch.Text = "";
                }
            }
        }
    }
}
