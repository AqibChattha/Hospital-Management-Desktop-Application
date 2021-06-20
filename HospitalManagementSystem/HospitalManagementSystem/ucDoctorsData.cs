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
            try
            {
                for (int i = 0; i < doctors.Count; i++)
                {
                    dtvDoctor.Rows.Add(doctors[i].Name, doctors[i].Cnic, doctors[i].PhoneNumber, doctors[i].Gender);
                }
            }catch(NullReferenceException e) { 
            }
        }

        private void btnRegisterDoctor_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucAddDoctor();
        }

        private void ucDoctorsData_Load(object sender, EventArgs e)
        {
            LoadDoctorDataInDtv(csHospital.Instence.getDoctors());
        }
        public void RefreshUC()
        {
            LoadDoctorDataInDtv(csHospital.Instence.getDoctors());
        }
    }
}
