using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucAddPatient();
        }
    }
}
