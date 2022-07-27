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
            LoadReceptionistDataInDtv(csHospital.Instence.getReceptionists());
            dtvReceptionists.AllowUserToAddRows = false;
        }

        private void LoadReceptionistDataInDtv(List<csReceptionist> receptionists)
        {
            dtvReceptionists.Rows.Clear();
            for (int i = 0; i < receptionists.Count; i++)
            {
                dtvReceptionists.Rows.Add(receptionists[i].Staff_Id, receptionists[i].Name, receptionists[i].Cnic, receptionists[i].PhoneNumber);
            }
        }
        private void LoadSearchedDataInDtv(List<csReceptionist> receptionists, String searchedValue)
        {
            dtvReceptionists.Rows.Clear();
            for (int i = 0; i < receptionists.Count; i++)
            {
                if (receptionists[i].Name.Contains(searchedValue, StringComparison.CurrentCultureIgnoreCase) == true || receptionists[i].Staff_Id.Contains(searchedValue, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    dtvReceptionists.Rows.Add(receptionists[i].Staff_Id, receptionists[i].Name, receptionists[i].Cnic, receptionists[i].PhoneNumber);
                }
            }
        }

        private int getReceptionistIndex(int indx)
        {
            List<csReceptionist> receptionists = csHospital.Instence.getReceptionists();
            for (int i = 0; i < receptionists.Count; i++)
            {
                if (receptionists[i].Staff_Id.Equals(dtvReceptionists.Rows[indx].Cells[0].Value.ToString()) == true && receptionists[i].Name.Equals(dtvReceptionists.Rows[indx].Cells[1].Value.ToString()) == true)
                {
                    return i;
                }
            }
            return -1;
        }
        private void DeleteReceptionistRow(int index)
        {
            csHospital.Instence.DeleteReceptionist(getReceptionistIndex(index));
            dtvReceptionists.Rows.RemoveAt(index);
            txtSearch.Text = "";
        }


        private void btnRegisterReceptionist_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucAddReceptionist();
        }

        public void RefreshUC()
        {
            txtSearch.Text = "";
            LoadReceptionistDataInDtv(csHospital.Instence.getReceptionists());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSearchedDataInDtv(csHospital.Instence.getReceptionists(), txtSearch.Text);
        }

        private void dtvReceptionists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete this receptionist.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        DeleteReceptionistRow(e.RowIndex);
                    }
                }

                if (e.ColumnIndex == 5)
                {
                    if (!MainForn.main_Panel.Controls.Contains(ucAddReceptionist.Instence))
                    {
                        MainForn.main_Panel.Controls.Add(ucAddReceptionist.Instence);
                        ucAddReceptionist.Instence.Dock = DockStyle.Fill;
                        ucAddReceptionist.Instence.UpdateColumnClicked(getReceptionistIndex(e.RowIndex));
                        ucAddReceptionist.Instence.BringToFront();
                    }
                    else
                    {
                        ucAddReceptionist.Instence.UpdateColumnClicked(getReceptionistIndex(e.RowIndex));
                        ucAddReceptionist.Instence.BringToFront();
                    }
                }

                if (e.ColumnIndex == 4)
                {
                    csHospital.Instence.ViewReceptionist(getReceptionistIndex(e.RowIndex));
                    txtSearch.Text = "";
                }
            }
        }
    }
}
