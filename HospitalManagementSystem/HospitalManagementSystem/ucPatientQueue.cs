using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace HospitalManagementSystem
{
    public partial class ucPatientQueue : UserControl
    {
        private static ucPatientQueue _instence;
        public static ucPatientQueue Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucPatientQueue();
                }
                return _instence;
            }
        }
        public ucPatientQueue()
        {
            InitializeComponent();
            dtvPatientQueue.AllowUserToAddRows = false;
            dtvPatientQueue.RowHeadersVisible = false;
            LoadDataInDtv();
        }
        private void LoadDataInDtv()
        {
            dtvPatientQueue.Rows.Clear();
            List<csOutPatient> patients = csHospital.Instence.getPatientQueue().ToList();
            for(int i=0; i<patients.Count; i++)
            {
                dtvPatientQueue.Rows.Add(patients[i].PhoneNumber, patients[i].Patient_Id, patients[i].Name, patients[i].Gender);
            }
        }

        public void RefreshUC()
        {
            LoadDataInDtv();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            ucAddPatient.Instence.select_OutPatient();
            ChangeUC.To_ucAddPatient();
        }
    }
}
