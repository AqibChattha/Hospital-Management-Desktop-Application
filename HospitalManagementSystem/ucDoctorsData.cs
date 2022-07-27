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
            LoadDoctorDataInDtv(csHospital.Instence.getDoctors());
            dtvDoctor.AllowUserToAddRows = false;
        }

        private void LoadDoctorDataInDtv(List<csDoctor> doctors)
        {
            dtvDoctor.Rows.Clear();
            for (int i = 0; i < doctors.Count; i++)
            {
                dtvDoctor.Rows.Add(doctors[i].Staff_Id, doctors[i].Name, doctors[i].Cnic, doctors[i].PhoneNumber);
            }
        }
        private void LoadSearchedDataInDtv(List<csDoctor> doctors, String searchedValue)
        {
            dtvDoctor.Rows.Clear();
            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctors[i].Name.Contains(searchedValue, StringComparison.CurrentCultureIgnoreCase) == true || doctors[i].Staff_Id.Contains(searchedValue, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    dtvDoctor.Rows.Add(doctors[i].Staff_Id, doctors[i].Name, doctors[i].Cnic, doctors[i].PhoneNumber);
                }
            }
        }

        private int getDoctorIndex(int indx)
        {
            List<csDoctor> doctors = csHospital.Instence.getDoctors();
            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctors[i].Staff_Id.Equals(dtvDoctor.Rows[indx].Cells[0].Value.ToString()) == true && doctors[i].Name.Equals(dtvDoctor.Rows[indx].Cells[1].Value.ToString()) == true)
                {
                    return i;
                }
            }
            return -1;
        }
        private void DeleteDoctorRow(int index)
        {
            csHospital.Instence.DeleteDoctor(getDoctorIndex(index));
            dtvDoctor.Rows.RemoveAt(index);
            txtSearch.Text = "";
        }

        private void btnRegisterDoctor_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucAddDoctor();
        }
        public void RefreshUC()
        {
            txtSearch.Text = "";
            LoadDoctorDataInDtv(csHospital.Instence.getDoctors());
        }

        private void dtvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete this doctor.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        DeleteDoctorRow(e.RowIndex);
                    }
                }
                if (e.ColumnIndex == 5)
                {
                    if (!MainForn.main_Panel.Controls.Contains(ucAddDoctor.Instence))
                    {
                        MainForn.main_Panel.Controls.Add(ucAddDoctor.Instence);
                        ucAddDoctor.Instence.Dock = DockStyle.Fill;
                        ucAddDoctor.Instence.UpdateColumnClicked(getDoctorIndex(e.RowIndex));
                        ucAddDoctor.Instence.BringToFront();
                    }
                    else
                    {
                        ucAddDoctor.Instence.UpdateColumnClicked(getDoctorIndex(e.RowIndex));
                        ucAddDoctor.Instence.BringToFront();
                    }
                }

                if (e.ColumnIndex == 4)
                {
                    csHospital.Instence.ViewDoctor(getDoctorIndex(e.RowIndex));
                    txtSearch.Text = "";
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSearchedDataInDtv(csHospital.Instence.getDoctors(), txtSearch.Text);
        }
    }
}
