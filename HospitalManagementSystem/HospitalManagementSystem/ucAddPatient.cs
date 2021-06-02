using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAddPatient : UserControl
    {

        private static ucAddPatient _instence;
        public static ucAddPatient Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAddPatient();
                }
                return _instence;
            }
        }
        public ucAddPatient()
        {
            InitializeComponent();
            cbPatientType.SelectedIndex = 0;
            panel1.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void cbPatientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPatientType.SelectedIndex == 0)
            {
                panel1.Visible = true;
                panel3.Visible = false;
                panel4.Visible = false;
            }
            if (cbPatientType.SelectedIndex == 1)
            {
                panel3.Visible = true;
                panel1.Visible = false;
                panel4.Visible = false;
            }
            if (cbPatientType.SelectedIndex == 2)
            {
                panel4.Visible = true;
                panel1.Visible = false;
                panel3.Visible = false;
            }
        }
    }
}
