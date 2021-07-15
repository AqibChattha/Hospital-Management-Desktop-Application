using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucPatientsData : UserControl
    {
        private static ucPatientsData _instence;
        public static ucPatientsData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucPatientsData();
                }
                return _instence;
            }
        }
        public ucPatientsData()
        {
            InitializeComponent();
            dtvPatients.AllowUserToAddRows = false;
            dtvPatients.RowHeadersVisible = false;
            LoadDataInDtv();
        }

        private void LoadDataInDtv()
        {
            dtvPatients.Rows.Clear();
            List<csPatient> patients = csHospital.Instence.getPatients();
            for(int i = 0; i<patients.Count; i++)
            {
                dtvPatients.Rows.Add(patients[i].Name, patients[i].Patient_Id, patients[i].Cnic, patients[i].PhoneNumber);
            }
        }

        public void RefreshUC()
        {
            LoadDataInDtv();
        }


        private void DeletePatientRow(int index)
        {
            csHospital.Instence.RemovePatient(index);
            dtvPatients.Rows.RemoveAt(index);
            txtSearch.Text = "";
        }

        private void dtvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete this Patient.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        DeletePatientRow(e.RowIndex);
                    }
                }

                if (e.ColumnIndex == 5)
                {
                    if (!MainForn.main_Panel.Controls.Contains(ucAddPatient.Instence))
                    {
                        MainForn.main_Panel.Controls.Add(ucAddPatient.Instence);
                        ucAddPatient.Instence.Dock = DockStyle.Fill;
                        ucAddPatient.Instence.UpdateColumnClicked(e.RowIndex);
                        ucAddPatient.Instence.BringToFront();
                    }
                    else
                    {
                        ucAddPatient.Instence.UpdateColumnClicked(e.RowIndex);
                        ucAddPatient.Instence.BringToFront();
                    }
                }

                if (e.ColumnIndex == 4)
                {
                    csHospital.Instence.ViewPatient(e.RowIndex);
                    txtSearch.Text = "";
                }
            }
        }
    }
}
