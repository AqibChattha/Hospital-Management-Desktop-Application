using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucLaboratoryTechniciansData : UserControl
    {
        private static ucLaboratoryTechniciansData _instence;
        public static ucLaboratoryTechniciansData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucLaboratoryTechniciansData();
                }
                return _instence;
            }
        }
        public ucLaboratoryTechniciansData()
        {
            InitializeComponent();
            dtvLabTechnician.AllowUserToAddRows = false;
            LoadLabTechDataInDtv(csHospital.Instence.getLabTech());
            
        }

        private void LoadLabTechDataInDtv(List<csLabTechnician> LabTech)
        {
            dtvLabTechnician.Rows.Clear();
            for (int i = 0; i < LabTech.Count; i++)
            {
                dtvLabTechnician.Rows.Add(LabTech[i].Staff_Id, LabTech[i].Name, LabTech[i].Cnic, LabTech[i].PhoneNumber);
            }
        }

        private void LoadSearchedDataInDtv(List<csLabTechnician> LabTech, String searchedValue)
        {
            dtvLabTechnician.Rows.Clear();
            for (int i = 0; i < LabTech.Count; i++)
            {
                if (LabTech[i].Name.Contains(searchedValue, StringComparison.CurrentCultureIgnoreCase) == true || LabTech[i].Staff_Id.Contains(searchedValue, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    dtvLabTechnician.Rows.Add(LabTech[i].Staff_Id, LabTech[i].Name, LabTech[i].Cnic, LabTech[i].PhoneNumber);
                }
            }
        }

        private int getLabTechIndex(int indx)
        {
            List<csLabTechnician> LabTech = csHospital.Instence.getLabTech();
            for (int i = 0; i < LabTech.Count; i++)
            {
                if (LabTech[i].Staff_Id.Equals(dtvLabTechnician.Rows[indx].Cells[0].Value.ToString()) == true && LabTech[i].Name.Equals(dtvLabTechnician.Rows[indx].Cells[1].Value.ToString()) == true)
                {
                    return i;
                }
            }
            return -1;
        }
        private void DeleteLabTechRow(int index)
        {
            csHospital.Instence.DeleteLabTech(getLabTechIndex(index));
            dtvLabTechnician.Rows.RemoveAt(index);
            txtSearch.Text = "";
        }
        private void btnRegisterLabTech_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucAddLaboratoryTechnician();
        }
        public void RefreshUC()
        {
            txtSearch.Text = "";
            LoadLabTechDataInDtv(csHospital.Instence.getLabTech());
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSearchedDataInDtv(csHospital.Instence.getLabTech(), txtSearch.Text);
        }

        private void dtvLabTechnician_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete this Lab Technecian.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        DeleteLabTechRow(e.RowIndex);
                    }
                }

                if (e.ColumnIndex == 5)
                {
                    if (!MainForn.main_Panel.Controls.Contains(ucAddLaboratoryTechnician.Instence))
                    {
                        MainForn.main_Panel.Controls.Add(ucAddLaboratoryTechnician.Instence);
                        ucAddLaboratoryTechnician.Instence.Dock = DockStyle.Fill;
                        ucAddLaboratoryTechnician.Instence.UpdateColumnClicked(getLabTechIndex(e.RowIndex));
                        ucAddLaboratoryTechnician.Instence.BringToFront();
                    }
                    else
                    {
                        ucAddLaboratoryTechnician.Instence.UpdateColumnClicked(getLabTechIndex(e.RowIndex));
                        ucAddLaboratoryTechnician.Instence.BringToFront();
                    }
                }

                if (e.ColumnIndex == 4)
                {
                    csHospital.Instence.ViewLabTech(getLabTechIndex(e.RowIndex));
                    txtSearch.Text = "";
                }
            }
        }
    }
}
