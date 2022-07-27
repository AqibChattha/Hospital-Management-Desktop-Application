using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucNursesData : UserControl
    {
        private static ucNursesData _instence;
        public static ucNursesData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucNursesData();
                }
                return _instence;
            }
        }
        public ucNursesData()
        {
            InitializeComponent();
            dtvNurse.AllowUserToAddRows = false;
            LoadNurseDataInDtv(csHospital.Instence.getNurses());
        }

        private void LoadNurseDataInDtv(List<csNurse> nurses)
        {
            dtvNurse.Rows.Clear();
            for (int i = 0; i < nurses.Count; i++)
            {
                dtvNurse.Rows.Add(nurses[i].Staff_Id, nurses[i].Name, nurses[i].Cnic, nurses[i].PhoneNumber);
            }
        }
        private void LoadSearchedDataInDtv(List<csNurse> nurses, String searchedValue)
        {
            dtvNurse.Rows.Clear();
            for (int i = 0; i < nurses.Count; i++)
            {
                if (nurses[i].Name.Contains(searchedValue, StringComparison.CurrentCultureIgnoreCase) == true || nurses[i].Staff_Id.Contains(searchedValue, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    dtvNurse.Rows.Add(nurses[i].Staff_Id, nurses[i].Name, nurses[i].Cnic, nurses[i].PhoneNumber);
                }
            }
        }
        private int getNurseIndex(int indx)
        {
            List<csNurse> nurses = csHospital.Instence.getNurses();
            for (int i = 0; i < nurses.Count; i++)
            {
                if (nurses[i].Staff_Id.Equals(dtvNurse.Rows[indx].Cells[0].Value.ToString()) == true && nurses[i].Name.Equals(dtvNurse.Rows[indx].Cells[1].Value.ToString()) == true)
                {
                    return i;
                }
            }
            return -1;
        }
        private void DeleteNurseRow(int index)
        {
            csHospital.Instence.DeleteNurse(getNurseIndex(index));
            dtvNurse.Rows.RemoveAt(index);
            txtSearch.Text = "";
        }

        private void btnRegisterNurse_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucAddNurse();
        }
        public void RefreshUC()
        {
            txtSearch.Text = "";
            LoadNurseDataInDtv(csHospital.Instence.getNurses());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSearchedDataInDtv(csHospital.Instence.getNurses(), txtSearch.Text);
        }

        private void dtvNurse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete this Nurse.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        DeleteNurseRow(e.RowIndex);
                    }
                }

                if (e.ColumnIndex == 5)
                {
                    if (!MainForn.main_Panel.Controls.Contains(ucAddNurse.Instence))
                    {
                        MainForn.main_Panel.Controls.Add(ucAddNurse.Instence);
                        ucAddNurse.Instence.Dock = DockStyle.Fill;
                        ucAddNurse.Instence.UpdateColumnClicked(getNurseIndex(e.RowIndex));
                        ucAddNurse.Instence.BringToFront();
                    }
                    else
                    {
                        ucAddNurse.Instence.UpdateColumnClicked(getNurseIndex(e.RowIndex));
                        ucAddNurse.Instence.BringToFront();
                    }
                }

                if (e.ColumnIndex == 4)
                {
                    csHospital.Instence.ViewNurse(getNurseIndex(e.RowIndex));
                    txtSearch.Text = "";
                }
            }
        }
    }
}
